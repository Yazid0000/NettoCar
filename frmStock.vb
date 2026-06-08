Public Class frmStock

    Private Sub frmStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChargerProduits()
        ChargerFournisseurs()
        ChargerHistorique()
    End Sub

    Private Sub ChargerProduits()
        Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT idproduit, nomproduit, quantite FROM produit ORDER BY nomproduit")

        cboProduitE.DataSource = dt.Copy()
        cboProduitE.DisplayMember = "nomproduit"
        cboProduitE.ValueMember = "idproduit"

        cboProduitS.DataSource = dt.Copy()
        cboProduitS.DisplayMember = "nomproduit"
        cboProduitS.ValueMember = "idproduit"

        AfficherStockE()
        AfficherStockS()
    End Sub

    Private Sub ChargerFournisseurs()
        Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT id_fournisseur, raison_sociale FROM fournisseur ORDER BY raison_sociale")
        cboFournisseur.DataSource = dt
        cboFournisseur.DisplayMember = "raison_sociale"
        cboFournisseur.ValueMember = "id_fournisseur"
    End Sub

    Private Sub AfficherStockE()
        If cboProduitE.SelectedIndex < 0 Then Exit Sub
        Dim dt As DataTable = CType(cboProduitE.DataSource, DataTable)
        txtStockActuelE.Text = dt.Rows(cboProduitE.SelectedIndex)("quantite").ToString()
    End Sub

    Private Sub AfficherStockS()
        If cboProduitS.SelectedIndex < 0 Then Exit Sub
        Dim dt As DataTable = CType(cboProduitS.DataSource, DataTable)
        txtStockActuelS.Text = dt.Rows(cboProduitS.SelectedIndex)("quantite").ToString()
    End Sub

    Private Sub cboProduitE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduitE.SelectedIndexChanged
        AfficherStockE()
    End Sub

    Private Sub cboProduitS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduitS.SelectedIndexChanged
        AfficherStockS()
    End Sub

    Private Sub btnEntree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntree.Click
        If cboProduitE.SelectedIndex < 0 Then
            MsgBox("Veuillez sélectionner un produit.", MsgBoxStyle.Exclamation, "Validation") : Exit Sub
        End If
        Dim qte As Integer = 0
        If Not Integer.TryParse(txtQuantiteE.Text.Trim(), qte) OrElse qte <= 0 Then
            MsgBox("Quantité invalide.", MsgBoxStyle.Exclamation, "Validation") : Exit Sub
        End If

        Dim idProduit As Integer = CInt(cboProduitE.SelectedValue)
        Dim idFournisseur As Integer = 0
        If cboFournisseur.SelectedIndex >= 0 AndAlso cboFournisseur.SelectedValue IsNot Nothing Then
            idFournisseur = CInt(cboFournisseur.SelectedValue)
        End If
        Dim nomProduit As String = cboProduitE.Text
        Dim nomFournisseur As String = cboFournisseur.Text
        Dim stockActuel As Integer = CInt(txtStockActuelE.Text)

        ' 1. Enregistrer le mouvement
        Dim params As New List(Of System.Data.OleDb.OleDbParameter)
        params.Add(New System.Data.OleDb.OleDbParameter("@idp", idProduit))
        params.Add(New System.Data.OleDb.OleDbParameter("@type", "ENTREE"))
        params.Add(New System.Data.OleDb.OleDbParameter("@qte", qte))
        params.Add(New System.Data.OleDb.OleDbParameter("@emp", AppSession.IdEmployeConnecte))

        Dim pDate As New System.Data.OleDb.OleDbParameter("@date", System.Data.OleDb.OleDbType.Date)
        pDate.Value = Date.Now
        params.Add(pDate)
        params.Add(New System.Data.OleDb.OleDbParameter("@motif", txtMotifE.Text.Trim()))

        If idFournisseur > 0 Then
            params.Add(New System.Data.OleDb.OleDbParameter("@four", idFournisseur))
            DBConnection.ExecuteNonQuery("INSERT INTO mouvementstock (idproduit, typemouvement, quantite, idemploye, datemouvement, motif, id_fournisseur) VALUES (?,?,?,?,?,?,?)", params)
        Else
            DBConnection.ExecuteNonQuery("INSERT INTO mouvementstock (idproduit, typemouvement, quantite, idemploye, datemouvement, motif) VALUES (?,?,?,?,?,?)", params)
        End If

        ' 2. Mettre à jour le stock
        Dim paramsUpd As New List(Of System.Data.OleDb.OleDbParameter)
        paramsUpd.Add(New System.Data.OleDb.OleDbParameter("@qte", stockActuel + qte))
        paramsUpd.Add(New System.Data.OleDb.OleDbParameter("@id", idProduit))
        DBConnection.ExecuteNonQuery("UPDATE produit SET quantite=? WHERE idproduit=?", paramsUpd)

        ' 3. Journaliser
        DBConnection.JournaliserEvenement("MOUVEMENT_STOCK", AppSession.IdEmployeConnecte, 0, _
            "ENTREE : " & qte & " x " & nomProduit & " - Fournisseur: " & nomFournisseur & _
            " - Stock avant: " & stockActuel & " apres: " & (stockActuel + qte))

        MsgBox("Entrée de " & qte & " unité(s) de « " & nomProduit & " » enregistrée !", MsgBoxStyle.Information, "Succès")
        txtQuantiteE.Clear()
        txtMotifE.Clear()
        ChargerProduits()
        ChargerHistorique()
    End Sub

    Private Sub btnSortie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortie.Click
        If cboProduitS.SelectedIndex < 0 Then
            MsgBox("Veuillez sélectionner un produit.", MsgBoxStyle.Exclamation, "Validation") : Exit Sub
        End If
        Dim qte As Integer = 0
        If Not Integer.TryParse(txtQuantiteS.Text.Trim(), qte) OrElse qte <= 0 Then
            MsgBox("Quantité invalide.", MsgBoxStyle.Exclamation, "Validation") : Exit Sub
        End If

        Dim idProduit As Integer = CInt(cboProduitS.SelectedValue)
        Dim nomProduit As String = cboProduitS.Text
        Dim stockActuel As Integer = CInt(txtStockActuelS.Text)

        If qte > stockActuel Then
            MsgBox("Stock insuffisant ! Stock actuel : " & stockActuel & " unité(s).", MsgBoxStyle.Exclamation, "Stock insuffisant")
            Exit Sub
        End If

        ' 1. Enregistrer le mouvement
        Dim params As New List(Of System.Data.OleDb.OleDbParameter)
        params.Add(New System.Data.OleDb.OleDbParameter("@idp", idProduit))
        params.Add(New System.Data.OleDb.OleDbParameter("@type", "SORTIE"))
        params.Add(New System.Data.OleDb.OleDbParameter("@qte", qte))
        params.Add(New System.Data.OleDb.OleDbParameter("@emp", AppSession.IdEmployeConnecte))
        Dim pDate As New System.Data.OleDb.OleDbParameter("@date", System.Data.OleDb.OleDbType.Date)
        pDate.Value = Date.Now
        params.Add(pDate)
        params.Add(New System.Data.OleDb.OleDbParameter("@motif", txtMotifS.Text.Trim()))
        DBConnection.ExecuteNonQuery("INSERT INTO mouvementstock (idproduit, typemouvement, quantite, idemploye, datemouvement, motif) VALUES (?,?,?,?,?,?)", params)

        ' 2. Mettre à jour le stock
        Dim paramsUpd As New List(Of System.Data.OleDb.OleDbParameter)
        paramsUpd.Add(New System.Data.OleDb.OleDbParameter("@qte", stockActuel - qte))
        paramsUpd.Add(New System.Data.OleDb.OleDbParameter("@id", idProduit))
        DBConnection.ExecuteNonQuery("UPDATE produit SET quantite=? WHERE idproduit=?", paramsUpd)

        ' 3. Journaliser
        DBConnection.JournaliserEvenement("MOUVEMENT_STOCK", AppSession.IdEmployeConnecte, 0, _
            "SORTIE : " & qte & " x " & nomProduit & _
            " - Stock avant: " & stockActuel & " → après: " & (stockActuel - qte))

        MsgBox("Sortie de " & qte & " unité(s) de « " & nomProduit & " » enregistrée !", MsgBoxStyle.Information, "Succès")
        txtQuantiteS.Clear()
        txtMotifS.Clear()
        ChargerProduits()
        ChargerHistorique()
    End Sub

    Private Sub ChargerHistorique()
        Dim sql As String = "SELECT m.datemouvement AS [Date], m.typemouvement AS [Type], " & _
                    "p.nomproduit AS [Produit], m.quantite AS [Quantite], " & _
                    "e.nom AS [Employe], m.motif AS [Motif] " & _
                    "FROM ((mouvementstock m " & _
                    "LEFT JOIN produit p ON m.idproduit = p.idproduit) " & _
                    "LEFT JOIN employe e ON m.idemploye = e.idEmploye) " & _
                    "ORDER BY m.datemouvement DESC"
        dgvHistorique.DataSource = DBConnection.ExecuteQuery(sql)

        ' Colorier ENTREE en vert, SORTIE en rouge
        For Each row As DataGridViewRow In dgvHistorique.Rows
            If row.Cells(1).Value IsNot Nothing Then
                If row.Cells(1).Value.ToString() = "ENTREE" Then
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(100, 220, 150)
                Else
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100)
                End If
            End If
        Next
    End Sub

    Private Sub btnActualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualiser.Click
        ChargerHistorique()
    End Sub

    Private Sub btnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

End Class