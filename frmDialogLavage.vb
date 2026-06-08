Public Class frmDialogLavage

    Private Sub frmDialogLavage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Nouveau Lavage"

        ' Charger les clients
        Dim dtClients As DataTable = DBConnection.ExecuteQuery("SELECT idclient, nom FROM client ORDER BY nom")
        cboClient.DataSource = dtClients
        cboClient.DisplayMember = "nom"
        cboClient.ValueMember = "idclient"

        ' Charger les services
        Dim dtServices As DataTable = DBConnection.ExecuteQuery("SELECT idservice, nomservice, prix FROM service ORDER BY nomservice")
        cboService.DataSource = dtServices
        cboService.DisplayMember = "nomservice"
        cboService.ValueMember = "idservice"

        dtpDate.Value = Date.Today
        txtHeureDeb.Text = DateTime.Now.ToString("HH:mm")

        ' Afficher le prix du premier service
        AfficherPrix()
    End Sub

    ' Quand on change de service → afficher son prix automatiquement
    Private Sub cboService_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboService.SelectedIndexChanged
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

    Private Sub btnCommencer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommencer.Click
        ' Validation
        If cboClient.SelectedIndex < 0 Then
            MsgBox("Veuillez sélectionner un client.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If
        If cboService.SelectedIndex < 0 Then
            MsgBox("Veuillez sélectionner un service.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If
        If txtHeureDeb.Text.Trim() = "" Then
            MsgBox("Veuillez saisir l'heure de début.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
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
            ' Journaliser immédiatement
            DBConnection.JournaliserEvenement("LAVAGE_DEBUT", AppSession.IdEmployeConnecte, newId, _
                "Lavage #" & newId & " démarré - Client: " & cboClient.Text & _
                " - Service: " & cboService.Text & " - Montant: " & montant.ToString("N2") & " DH")

            MsgBox("Lavage #" & newId & " démarré avec succès !", MsgBoxStyle.Information, "Succès")
            Me.Close()
        End If
    End Sub

    Private Sub btnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub

End Class