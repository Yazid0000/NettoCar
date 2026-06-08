Public Class frmServices

    Private Sub frmServices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR 1.0 - GESTION DES SERVICES"
        StyleHelper.StylerDGV(dgvServices)
        StyleHelper.AppliquerIcones(tsMenu)
        ChargerServices()
    End Sub

    Public Sub ChargerServices()
        Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT * FROM service ORDER BY nomservice")
        dgvServices.DataSource = dt
        StyleHelper.StylerCompteur(lblCompteur, "Nombre de services", dt.Rows.Count)
    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        Dim frm As New frmDialogService(False, "")
        frm.ShowDialog()
        ChargerServices()
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        If dgvServices.CurrentRow Is Nothing OrElse dgvServices.Rows.Count = 0 Then
            MsgBox("Veuillez sélectionner un service.", MsgBoxStyle.Exclamation, "Info") : Exit Sub
        End If
        Dim id As String = dgvServices.CurrentRow.Cells("idservice").Value.ToString()
        Dim frm As New frmDialogService(True, id)
        frm.ShowDialog()
        ChargerServices()
    End Sub

    Private Sub btnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimer.Click
        If dgvServices.CurrentRow Is Nothing OrElse dgvServices.Rows.Count = 0 Then
            MsgBox("Veuillez sélectionner un service.", MsgBoxStyle.Exclamation, "Info") : Exit Sub
        End If
        Dim id As String = dgvServices.CurrentRow.Cells("idservice").Value.ToString()
        Dim nom As String = dgvServices.CurrentRow.Cells("nomservice").Value.ToString()
        If MsgBox("Supprimer « " & nom & " » ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation") = MsgBoxResult.Yes Then
            Dim params As New List(Of OleDb.OleDbParameter)
            params.Add(New OleDb.OleDbParameter("@id", id))
            If DBConnection.ExecuteNonQuery("DELETE FROM service WHERE idservice=?", params) Then
                MsgBox("Service supprimé.", MsgBoxStyle.Information, "Succès")
                ChargerServices()
            End If
        End If
    End Sub

    Private Sub btnActualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualiser.Click
        ChargerServices()
    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim terme As String = txtSearch.Text.Trim().ToLower()
        If terme = "" Then ChargerServices() : Return
        Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT * FROM service ORDER BY nomservice")
        Dim dtF As DataTable = dt.Clone()
        For Each row As DataRow In dt.Rows
            For Each col As DataColumn In dt.Columns
                If row(col) IsNot DBNull.Value AndAlso row(col).ToString().ToLower().Contains(terme) Then
                    dtF.ImportRow(row) : Exit For
                End If
            Next
        Next
        dgvServices.DataSource = dtF
        StyleHelper.StylerCompteur(lblCompteur, "Nombre de services", dtF.Rows.Count)
    End Sub

    Private Sub btnImprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimer.Click
        StyleHelper.ImprimerDGV(dgvServices, "GESTION DES SERVICES")
    End Sub

    Public Sub SurbrillanceLigne(ByVal valeurId As Object)
        For Each row As DataGridViewRow In dgvServices.Rows
            Dim cellVal As Object = Nothing
            Try : cellVal = row.Cells("idservice").Value : Catch : End Try
            If cellVal IsNot Nothing AndAlso cellVal.ToString() = valeurId.ToString() Then
                Dim rowLocal As DataGridViewRow = row
                rowLocal.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(180, 230, 180)
                dgvServices.FirstDisplayedScrollingRowIndex = rowLocal.Index
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
