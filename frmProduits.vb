Public Class frmProduits

    Private Sub frmProduits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR 1.0 - GESTION DES PRODUITS"
        StyleHelper.StylerDGV(dgvProduits)
        StyleHelper.AppliquerIcones(tsMenu)
        ChargerProduits()
    End Sub

    Public Sub ChargerProduits()
        Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT * FROM produit ORDER BY nomproduit")
        dgvProduits.DataSource = dt
        StyleHelper.StylerCompteur(lblCompteur, "Nombre de produits", dt.Rows.Count)
        ' Colorier les lignes en alerte
        For Each row As DataGridViewRow In dgvProduits.Rows
            Dim qte As Integer = 0 : Dim seuil As Integer = 0
            If row.Cells("quantite").Value IsNot DBNull.Value Then Integer.TryParse(row.Cells("quantite").Value.ToString(), qte)
            If row.Cells("seuilalerte").Value IsNot DBNull.Value Then Integer.TryParse(row.Cells("seuilalerte").Value.ToString(), seuil)
            If qte <= seuil Then row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 220, 220)
        Next
    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        Dim frm As New frmDialogProduit(False, 0)
        frm.ShowDialog()
        ChargerProduits()
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        If dgvProduits.CurrentRow Is Nothing OrElse dgvProduits.Rows.Count = 0 Then
            MsgBox("Veuillez sélectionner un produit.", MsgBoxStyle.Exclamation, "Info") : Exit Sub
        End If
        Dim frm As New frmDialogProduit(True, CInt(dgvProduits.CurrentRow.Cells("idproduit").Value))
        frm.ShowDialog()
        ChargerProduits()
    End Sub

    Private Sub btnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimer.Click
        If dgvProduits.CurrentRow Is Nothing OrElse dgvProduits.Rows.Count = 0 Then
            MsgBox("Veuillez sélectionner un produit.", MsgBoxStyle.Exclamation, "Info") : Exit Sub
        End If
        Dim id As Integer = CInt(dgvProduits.CurrentRow.Cells("idproduit").Value)
        Dim nom As String = dgvProduits.CurrentRow.Cells("nomproduit").Value.ToString()
        If MsgBox("Supprimer « " & nom & " » ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation") = MsgBoxResult.Yes Then
            Dim params As New List(Of OleDb.OleDbParameter)
            params.Add(New OleDb.OleDbParameter("@id", id))
            If DBConnection.ExecuteNonQuery("DELETE FROM produit WHERE idproduit=?", params) Then
                DBConnection.JournaliserEvenement("SUPPRESSION", AppSession.IdEmployeConnecte, 0, _
                    "Produit supprimé : " & nom)
                MsgBox("Produit supprimé.", MsgBoxStyle.Information, "Succès")
                ChargerProduits()
            End If
        End If
    End Sub

    Private Sub btnActualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualiser.Click
        ChargerProduits()
    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim terme As String = txtSearch.Text.Trim().ToLower()
        If terme = "" Then ChargerProduits() : Return
        Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT * FROM produit ORDER BY nomproduit")
        Dim dtF As DataTable = dt.Clone()
        For Each row As DataRow In dt.Rows
            For Each col As DataColumn In dt.Columns
                If row(col) IsNot DBNull.Value AndAlso row(col).ToString().ToLower().Contains(terme) Then
                    dtF.ImportRow(row) : Exit For
                End If
            Next
        Next
        dgvProduits.DataSource = dtF
        StyleHelper.StylerCompteur(lblCompteur, "Nombre de produits", dtF.Rows.Count)
    End Sub

    Private Sub btnImprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimer.Click
        StyleHelper.ImprimerDGV(dgvProduits, "GESTION DES PRODUITS")
    End Sub

    Public Sub SurbrillanceLigne(ByVal valeurId As Object)
        For Each row As DataGridViewRow In dgvProduits.Rows
            Dim cellVal As Object = Nothing
            Try : cellVal = row.Cells("idproduit").Value : Catch : End Try
            If cellVal IsNot Nothing AndAlso cellVal.ToString() = valeurId.ToString() Then
                Dim rowLocal As DataGridViewRow = row
                rowLocal.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(180, 230, 180)
                dgvProduits.FirstDisplayedScrollingRowIndex = rowLocal.Index
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
