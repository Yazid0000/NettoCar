Public Class frmLavages

    Private Sub frmLavages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChargerClients()
        ChargerServices()
        dtpDate.Value = Date.Today
        txtHeureDeb.Text = DateTime.Now.ToString("HH:mm")
        ChargerLavagesEnCours()
    End Sub

    Private Sub ChargerClients()
        Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT idclient, nom FROM client ORDER BY nom")
        cboClient.DataSource = dt
        cboClient.DisplayMember = "nom"
        cboClient.ValueMember = "idclient"
    End Sub

    Private Sub ChargerServices()
        Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT idservice, nomservice, prix FROM service ORDER BY nomservice")
        cboService.DataSource = dt
        cboService.DisplayMember = "nomservice"
        cboService.ValueMember = "idservice"
        AfficherPrix()
    End Sub

    Private Sub AfficherPrix()
        If cboService.SelectedIndex < 0 Then Exit Sub
        Dim dt As DataTable = CType(cboService.DataSource, DataTable)
        If dt Is Nothing Then Exit Sub
        Dim prix As Object = dt.Rows(cboService.SelectedIndex)("prix")
        If prix IsNot DBNull.Value Then
            txtMontant.Text = CDec(prix).ToString("N2")
        End If
    End Sub

    Private Sub cboService_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboService.SelectedIndexChanged
        AfficherPrix()
    End Sub

    Private Sub btnCommencer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommencer.Click
        If cboClient.SelectedIndex < 0 Then
            MsgBox("Veuillez sélectionner un client.", MsgBoxStyle.Exclamation, "Validation") : Exit Sub
        End If
        If cboService.SelectedIndex < 0 Then
            MsgBox("Veuillez sélectionner un service.", MsgBoxStyle.Exclamation, "Validation") : Exit Sub
        End If
        If txtHeureDeb.Text.Trim() = "" Then
            MsgBox("Veuillez saisir l'heure de début.", MsgBoxStyle.Exclamation, "Validation") : Exit Sub
        End If

        Dim newId As Integer = DBConnection.GetNextId("lavage", "idlavage")
        Dim montant As Decimal = 0
        Decimal.TryParse(txtMontant.Text.Replace(",", "."), montant)

        Dim params As New List(Of System.Data.OleDb.OleDbParameter)
        params.Add(New System.Data.OleDb.OleDbParameter("@id", newId))
        params.Add(New System.Data.OleDb.OleDbParameter("@cli", CInt(cboClient.SelectedValue)))
        params.Add(New System.Data.OleDb.OleDbParameter("@emp", AppSession.IdEmployeConnecte))
        params.Add(New System.Data.OleDb.OleDbParameter("@svc", cboService.SelectedValue.ToString()))
        params.Add(New System.Data.OleDb.OleDbParameter("@date", dtpDate.Value.Date))
        params.Add(New System.Data.OleDb.OleDbParameter("@hdeb", txtHeureDeb.Text.Trim()))
        params.Add(New System.Data.OleDb.OleDbParameter("@mnt", montant))
        params.Add(New System.Data.OleDb.OleDbParameter("@stat", "En cours"))
        params.Add(New System.Data.OleDb.OleDbParameter("@obs", txtObservations.Text.Trim()))

        Dim sql As String = "INSERT INTO lavage (idlavage, idclient, idemploye, idservice, datelavage, heuredebut, montant, statut, observations) " & _
                            "VALUES (?,?,?,?,?,?,?,?,?)"

        If DBConnection.ExecuteNonQuery(sql, params) Then
            DBConnection.JournaliserEvenement("LAVAGE_DEBUT", AppSession.IdEmployeConnecte, newId, _
                "Lavage #" & newId & " démarré - Client: " & cboClient.Text & _
                " - Service: " & cboService.Text & " - Montant: " & montant.ToString("N2") & " DH")

            MsgBox("Lavage #" & newId & " démarré !", MsgBoxStyle.Information, "Succès")
            txtObservations.Clear()
            txtHeureDeb.Text = DateTime.Now.ToString("HH:mm")
            tabControl.SelectedTab = tabEnCours
            ChargerLavagesEnCours()
        End If
    End Sub

    Private Sub ChargerLavagesEnCours()
        Dim sql As String = "SELECT l.idlavage AS [N Lavage], c.nom AS [Client], " & _
                            "l.idservice AS [Service], l.heuredebut AS [Heure debut], " & _
                            "l.montant AS [Montant DH], l.statut AS [Statut], " & _
                            "e.nom AS [Employe] " & _
                            "FROM (lavage l " & _
                            "LEFT JOIN client c ON l.idclient = c.idclient) " & _
                            "LEFT JOIN employe e ON l.idemploye = e.idEmploye " & _
                            "WHERE l.statut = 'En cours' " & _
                            "ORDER BY l.datelavage DESC"
        dgvLavages.DataSource = DBConnection.ExecuteQuery(sql)
        dgvLavages.ReadOnly = True
    End Sub

    Private Sub btnCloture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloture.Click
        If dgvLavages.CurrentRow Is Nothing OrElse dgvLavages.Rows.Count = 0 Then
            MsgBox("Veuillez sélectionner un lavage.", MsgBoxStyle.Exclamation, "Info") : Exit Sub
        End If

        Dim idLavage As Integer = CInt(dgvLavages.CurrentRow.Cells(0).Value)
        Dim nomClient As String = dgvLavages.CurrentRow.Cells(1).Value.ToString()

        If MsgBox("Clôturer le lavage #" & idLavage & " - Client: " & nomClient & " ?", _
                  MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation") = MsgBoxResult.Yes Then

            Dim heureFin As String = DateTime.Now.ToString("HH:mm")
            Dim params As New List(Of System.Data.OleDb.OleDbParameter)
            params.Add(New System.Data.OleDb.OleDbParameter("@stat", "Terminé"))
            params.Add(New System.Data.OleDb.OleDbParameter("@hfin", heureFin))
            params.Add(New System.Data.OleDb.OleDbParameter("@id", idLavage))

            If DBConnection.ExecuteNonQuery("UPDATE lavage SET statut=?, heurefinreelle=? WHERE idlavage=?", params) Then
                DBConnection.JournaliserEvenement("LAVAGE_FIN", AppSession.IdEmployeConnecte, idLavage, _
                    "Lavage #" & idLavage & " clôturé - Client: " & nomClient & " - Heure fin: " & heureFin)

                MsgBox("Lavage #" & idLavage & " clôturé avec succès !", MsgBoxStyle.Information, "Succès")
                ChargerLavagesEnCours()
            End If
        End If
    End Sub

    Private Sub btnActualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualiser.Click
        ChargerLavagesEnCours()
    End Sub

    Private Sub btnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

End Class