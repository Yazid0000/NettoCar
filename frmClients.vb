Public Class frmClients

    Private Sub frmClients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR 1.0 - GESTION DES CLIENTS"
        StyleHelper.StylerDGV(dgvClients)
        StyleHelper.AppliquerIcones(tsMenu)
        ChargerClients()
    End Sub

    Public Sub ChargerClients()
        Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT * FROM client ORDER BY nom")
        dgvClients.DataSource = dt
        StyleHelper.StylerCompteur(lblCompteur, "Nombre de clients", dt.Rows.Count)
    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        Dim frm As New frmDialogClient(False, 0)
        frm.ShowDialog()
        ChargerClients()
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        If dgvClients.CurrentRow Is Nothing OrElse dgvClients.Rows.Count = 0 Then
            MsgBox("Veuillez sélectionner un client.", MsgBoxStyle.Exclamation, "Info") : Exit Sub
        End If
        Dim frm As New frmDialogClient(True, CInt(dgvClients.CurrentRow.Cells("idclient").Value))
        frm.ShowDialog()
        ChargerClients()
    End Sub

    Private Sub btnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimer.Click
        If dgvClients.CurrentRow Is Nothing OrElse dgvClients.Rows.Count = 0 Then
            MsgBox("Veuillez sélectionner un client.", MsgBoxStyle.Exclamation, "Info") : Exit Sub
        End If
        Dim nom As String = dgvClients.CurrentRow.Cells("nom").Value.ToString()
        Dim id As Integer = CInt(dgvClients.CurrentRow.Cells("idclient").Value)
        If MsgBox("Supprimer « " & nom & " » ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation") = MsgBoxResult.Yes Then
            Dim params As New List(Of OleDb.OleDbParameter)
            params.Add(New OleDb.OleDbParameter("@id", id))
            If DBConnection.ExecuteNonQuery("DELETE FROM client WHERE idclient=?", params) Then
                DBConnection.JournaliserEvenement("SUPPRESSION", AppSession.IdEmployeConnecte, 0, _
                    "Client supprimé : " & nom)
                MsgBox("Client supprimé.", MsgBoxStyle.Information, "Succès")
                ChargerClients()
            End If
        End If
    End Sub

    Private Sub btnActualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualiser.Click
        ChargerClients()
    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim terme As String = txtSearch.Text.Trim().ToLower()
        If terme = "" Then ChargerClients() : Return
        Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT * FROM client ORDER BY nom")
        Dim dtF As DataTable = dt.Clone()
        For Each row As DataRow In dt.Rows
            For Each col As DataColumn In dt.Columns
                If row(col) IsNot DBNull.Value AndAlso row(col).ToString().ToLower().Contains(terme) Then
                    dtF.ImportRow(row) : Exit For
                End If
            Next
        Next
        dgvClients.DataSource = dtF
        StyleHelper.StylerCompteur(lblCompteur, "Nombre de clients", dtF.Rows.Count)
    End Sub

    Private Sub btnImprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimer.Click
        StyleHelper.ImprimerDGV(dgvClients, "GESTION DES CLIENTS")
    End Sub

    Public Sub SurbrillanceLigne(ByVal valeurId As Object)
        For Each row As DataGridViewRow In dgvClients.Rows
            Dim cellVal As Object = Nothing
            Try : cellVal = row.Cells("idclient").Value : Catch : End Try
            If cellVal IsNot Nothing AndAlso cellVal.ToString() = valeurId.ToString() Then
                Dim rowLocal As DataGridViewRow = row
                rowLocal.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(180, 230, 180)
                dgvClients.FirstDisplayedScrollingRowIndex = rowLocal.Index
                Dim t As New System.Windows.Forms.Timer()
                t.Interval = 2000
                AddHandler t.Tick, Sub(s As Object, ev As System.EventArgs)
                                       rowLocal.DefaultCellStyle.BackColor = System.Drawing.Color.Empty
                                       CType(s, System.Windows.Forms.Timer).Stop()
                                       CType(s, System.Windows.Forms.Timer).Dispose()
                                   End Sub
                t.Start()
                Exit For
            End If
        Next
    End Sub

End Class
