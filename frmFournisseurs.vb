Public Class frmFournisseurs

    Private Sub frmFournisseurs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR 1.0 - GESTION DES FOURNISSEURS"
        StyleHelper.StylerDGV(dgvFournisseurs)
        StyleHelper.AppliquerIcones(tsMenu)
        ChargerFournisseurs()
    End Sub

    Public Sub ChargerFournisseurs()
        Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT * FROM fournisseur ORDER BY raison_sociale")
        dgvFournisseurs.DataSource = dt
        StyleHelper.StylerCompteur(lblCompteur, "Nombre de fournisseurs", dt.Rows.Count)
    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        Dim frm As New frmDialogFournisseur(False, 0)
        frm.ShowDialog()
        ChargerFournisseurs()
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        If dgvFournisseurs.CurrentRow Is Nothing OrElse dgvFournisseurs.Rows.Count = 0 Then
            MsgBox("Veuillez sélectionner un fournisseur.", MsgBoxStyle.Exclamation, "Info") : Exit Sub
        End If
        Dim frm As New frmDialogFournisseur(True, CInt(dgvFournisseurs.CurrentRow.Cells("id_fournisseur").Value))
        frm.ShowDialog()
        ChargerFournisseurs()
    End Sub

    Private Sub btnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimer.Click
        If dgvFournisseurs.CurrentRow Is Nothing OrElse dgvFournisseurs.Rows.Count = 0 Then
            MsgBox("Veuillez sélectionner un fournisseur.", MsgBoxStyle.Exclamation, "Info") : Exit Sub
        End If
        Dim id As Integer = CInt(dgvFournisseurs.CurrentRow.Cells("id_fournisseur").Value)
        Dim nom As String = dgvFournisseurs.CurrentRow.Cells("raison_sociale").Value.ToString()
        If MsgBox("Supprimer « " & nom & " » ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation") = MsgBoxResult.Yes Then
            Dim params As New List(Of OleDb.OleDbParameter)
            params.Add(New OleDb.OleDbParameter("@id", id))
            If DBConnection.ExecuteNonQuery("DELETE FROM fournisseur WHERE id_fournisseur=?", params) Then
                DBConnection.JournaliserEvenement("SUPPRESSION", AppSession.IdEmployeConnecte, 0, _
                    "Fournisseur supprimé : " & nom)
                MsgBox("Fournisseur supprimé.", MsgBoxStyle.Information, "Succès")
                ChargerFournisseurs()
            End If
        End If
    End Sub

    Private Sub btnActualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualiser.Click
        ChargerFournisseurs()
    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim terme As String = txtSearch.Text.Trim().ToLower()
        If terme = "" Then ChargerFournisseurs() : Return
        Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT * FROM fournisseur ORDER BY raison_sociale")
        Dim dtF As DataTable = dt.Clone()
        For Each row As DataRow In dt.Rows
            For Each col As DataColumn In dt.Columns
                If row(col) IsNot DBNull.Value AndAlso row(col).ToString().ToLower().Contains(terme) Then
                    dtF.ImportRow(row) : Exit For
                End If
            Next
        Next
        dgvFournisseurs.DataSource = dtF
        StyleHelper.StylerCompteur(lblCompteur, "Nombre de fournisseurs", dtF.Rows.Count)
    End Sub

    Private Sub btnImprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimer.Click
        StyleHelper.ImprimerDGV(dgvFournisseurs, "GESTION DES FOURNISSEURS")
    End Sub

    Public Sub SurbrillanceLigne(ByVal valeurId As Object)
        For Each row As DataGridViewRow In dgvFournisseurs.Rows
            Dim cellVal As Object = Nothing
            Try : cellVal = row.Cells("id_fournisseur").Value : Catch : End Try
            If cellVal IsNot Nothing AndAlso cellVal.ToString() = valeurId.ToString() Then
                Dim rowLocal As DataGridViewRow = row
                rowLocal.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(180, 230, 180)
                dgvFournisseurs.FirstDisplayedScrollingRowIndex = rowLocal.Index
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
