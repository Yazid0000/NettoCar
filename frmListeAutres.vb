' ============================================================
'  frmClients.vb
' ============================================================
Public Class frmClients

    Private Sub frmClients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR 1.0 - GESTION DES CLIENTS"
        StyleHelper.StylerDGV(dgvClients)
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
                DBConnection.JournaliserEvenement("SUPPRESSION", AppSession.IdEmployeConnecte, 0, "Client supprimé : " & nom)
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



' ============================================================
'  frmEmployes.vb
' ============================================================
Public Class frmEmployes

    Private Sub frmEmployes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR 1.0 - GESTION DES EMPLOYES"
        ChargerEmployes()
    End Sub

    Public Sub ChargerEmployes()
        Dim sql As String = "SELECT e.idemploye, e.nom, e.prenom, e.poste, e.salaire, e.dateembauche, e.photo, a.nomagence " & _
                            "FROM employe e LEFT JOIN agence a ON e.idagence = a.idagence ORDER BY e.nom"
        Dim dt As DataTable = DBConnection.ExecuteQuery(sql)

        dgvEmployes.DataSource = Nothing
        dgvEmployes.Columns.Clear()
        dgvEmployes.AutoGenerateColumns = False

        Dim colPhoto As New DataGridViewImageColumn()
        colPhoto.Name = "colPhoto" : colPhoto.HeaderText = "Photo" : colPhoto.Width = 60
        colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom
        colPhoto.DefaultCellStyle.NullValue = Nothing
        dgvEmployes.Columns.Add(colPhoto)

        Dim cols() As String = {"idemploye", "nom", "prenom", "poste", "salaire", "nomagence"}
        Dim hdrs() As String = {"ID", "Nom", "Prénom", "Poste", "Salaire (DH)", "Agence"}
        For i As Integer = 0 To cols.Length - 1
            Dim c As New DataGridViewTextBoxColumn()
            c.Name = cols(i) : c.HeaderText = hdrs(i) : c.DataPropertyName = cols(i)
            dgvEmployes.Columns.Add(c)
        Next

        Dim colChemin As New DataGridViewTextBoxColumn()
        colChemin.Name = "photo" : colChemin.DataPropertyName = "photo" : colChemin.Visible = False
        dgvEmployes.Columns.Add(colChemin)

        Dim colDate As New DataGridViewTextBoxColumn()
        colDate.Name = "dateembauche" : colDate.DataPropertyName = "dateembauche" : colDate.Visible = False
        dgvEmployes.Columns.Add(colDate)

        dgvEmployes.DataSource = dt
        StyleHelper.StylerDGV(dgvEmployes)
        dgvEmployes.RowTemplate.Height = 55

        For Each row As DataGridViewRow In dgvEmployes.Rows
            Dim chemin As String = ""
            If row.Cells("photo").Value IsNot DBNull.Value AndAlso row.Cells("photo").Value IsNot Nothing Then
                chemin = row.Cells("photo").Value.ToString()
            End If
            If chemin <> "" AndAlso System.IO.File.Exists(chemin) Then
                Try
                    row.Cells("colPhoto").Value = System.Drawing.Image.FromFile(chemin)
                Catch
                    row.Cells("colPhoto").Value = Nothing
                End Try
            End If
        Next

        StyleHelper.StylerCompteur(lblCompteur, "Nombre d'employés", dt.Rows.Count)
    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        Dim frm As New frmDialogEmploye(False, 0)
        frm.ShowDialog()
        ChargerEmployes()
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        If dgvEmployes.CurrentRow Is Nothing OrElse dgvEmployes.Rows.Count = 0 Then
            MsgBox("Veuillez sélectionner un employé.", MsgBoxStyle.Exclamation, "Info") : Exit Sub
        End If
        Dim drv As DataRowView = TryCast(dgvEmployes.CurrentRow.DataBoundItem, DataRowView)
        If drv Is Nothing Then Exit Sub
        Dim frm As New frmDialogEmploye(True, CInt(drv.Row("idemploye")))
        frm.ShowDialog()
        ChargerEmployes()
    End Sub

    Private Sub btnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimer.Click
        If dgvEmployes.CurrentRow Is Nothing OrElse dgvEmployes.Rows.Count = 0 Then
            MsgBox("Veuillez sélectionner un employé.", MsgBoxStyle.Exclamation, "Info") : Exit Sub
        End If
        Dim drv As DataRowView = TryCast(dgvEmployes.CurrentRow.DataBoundItem, DataRowView)
        If drv Is Nothing Then Exit Sub
        Dim id As Integer = CInt(drv.Row("idemploye"))
        Dim nom As String = drv.Row("nom").ToString()
        If MsgBox("Supprimer « " & nom & " » ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation") = MsgBoxResult.Yes Then
            Dim params As New List(Of OleDb.OleDbParameter)
            params.Add(New OleDb.OleDbParameter("@id", id))
            If DBConnection.ExecuteNonQuery("DELETE FROM employe WHERE idemploye=?", params) Then
                DBConnection.JournaliserEvenement("SUPPRESSION", AppSession.IdEmployeConnecte, 0, "Employé supprimé : " & nom)
                MsgBox("Employé supprimé.", MsgBoxStyle.Information, "Succès")
                ChargerEmployes()
            End If
        End If
    End Sub

    Private Sub btnActualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualiser.Click
        ChargerEmployes()
    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim terme As String = txtSearch.Text.Trim().ToLower()
        If terme = "" Then ChargerEmployes() : Return
        Dim sql As String = "SELECT e.idemploye, e.nom, e.prenom, e.poste, e.salaire, e.dateembauche, e.photo, a.nomagence " & _
                            "FROM employe e LEFT JOIN agence a ON e.idagence = a.idagence ORDER BY e.nom"
        Dim dt As DataTable = DBConnection.ExecuteQuery(sql)
        Dim dtF As DataTable = dt.Clone()
        For Each row As DataRow In dt.Rows
            For Each col As DataColumn In dt.Columns
                If row(col) IsNot DBNull.Value AndAlso row(col).ToString().ToLower().Contains(terme) Then
                    dtF.ImportRow(row) : Exit For
                End If
            Next
        Next
        ' Rebinder sans reconfigurer les colonnes
        dgvEmployes.DataSource = dtF
        StyleHelper.StylerCompteur(lblCompteur, "Nombre d'employes", dtF.Rows.Count)
    End Sub

    Private Sub btnImprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimer.Click
        StyleHelper.ImprimerDGV(dgvEmployes, "GESTION DES EMPLOYES")
    End Sub

    Public Sub SurbrillanceLigne(ByVal valeurId As Object)
        For Each row As DataGridViewRow In dgvEmployes.Rows
            Dim cellVal As Object = Nothing
            Try : cellVal = row.Cells("idemploye").Value : Catch : End Try
            If cellVal IsNot Nothing AndAlso cellVal.ToString() = valeurId.ToString() Then
                Dim rowLocal As DataGridViewRow = row
                rowLocal.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(180, 230, 180)
                dgvEmployes.FirstDisplayedScrollingRowIndex = rowLocal.Index
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



' ============================================================
'  frmServices.vb
' ============================================================
Public Class frmServices

    Private Sub frmServices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR 1.0 - GESTION DES SERVICES"
        StyleHelper.StylerDGV(dgvServices)
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
                DBConnection.JournaliserEvenement("SUPPRESSION", AppSession.IdEmployeConnecte, 0, "Service supprimé : " & nom)
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



' ============================================================
'  frmProduits.vb
' ============================================================
Public Class frmProduits

    Private Sub frmProduits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR 1.0 - GESTION DES PRODUITS"
        StyleHelper.StylerDGV(dgvProduits)
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
                DBConnection.JournaliserEvenement("SUPPRESSION", AppSession.IdEmployeConnecte, 0, "Produit supprimé : " & nom)
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



' ============================================================
'  frmFournisseurs.vb
' ============================================================
Public Class frmFournisseurs

    Private Sub frmFournisseurs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR 1.0 - GESTION DES FOURNISSEURS"
        StyleHelper.StylerDGV(dgvFournisseurs)
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
                DBConnection.JournaliserEvenement("SUPPRESSION", AppSession.IdEmployeConnecte, 0, "Fournisseur supprimé : " & nom)
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



' ============================================================
'  frmStatistiques.vb
' ============================================================
Public Class frmStatistiques

    Private Sub frmStatistiques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR 1.0 - STATISTIQUES"
        StyleHelper.StylerDGV(dgvParAgence)
        StyleHelper.StylerDGV(dgvAlertes)
        StyleHelper.StylerDGV(dgvServices)
        StyleHelper.StylerDGV(dgvClientsVille)
        ChargerTableauDeBord()
    End Sub

    Private Sub tabStats_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabStats.SelectedIndexChanged
        Select Case tabStats.SelectedIndex
            Case 0 : ChargerTableauDeBord()
            Case 1 : ChargerParAgence()
            Case 2 : ChargerAlertesStock()
            Case 3 : ChargerServices()
            Case 4 : ChargerClientsVille()
        End Select
    End Sub

    Private Sub ChargerTableauDeBord()
        Dim nbAgences As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM agence")
        Dim nbClients As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM client")
        Dim nbEmployes As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM employe")
        Dim nbServices As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM service")
        Dim nbProduits As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM produit")
        lblNbAgences.Text = If(nbAgences IsNot Nothing, nbAgences.ToString(), "0")
        lblNbClients.Text = If(nbClients IsNot Nothing, nbClients.ToString(), "0")
        lblNbEmployes.Text = If(nbEmployes IsNot Nothing, nbEmployes.ToString(), "0")
        lblNbServices.Text = If(nbServices IsNot Nothing, nbServices.ToString(), "0")
        lblNbProduits.Text = If(nbProduits IsNot Nothing, nbProduits.ToString(), "0")
        Dim totalSal As Object = DBConnection.ExecuteScalar("SELECT SUM(salaire) FROM employe")
        lblTotalSalaires.Text = If(totalSal IsNot Nothing AndAlso totalSal IsNot DBNull.Value, CDec(totalSal).ToString("N2") & " DH", "0,00 DH")
        Dim valStock As Object = DBConnection.ExecuteScalar("SELECT SUM(prixachat * quantite) FROM produit")
        lblValeurStock.Text = If(valStock IsNot Nothing AndAlso valStock IsNot DBNull.Value, CDec(valStock).ToString("N2") & " DH", "0,00 DH")
    End Sub

    Private Sub ChargerParAgence()
        Dim sql As String = "SELECT a.nomagence AS [Agence], COUNT(e.idemploye) AS [Nb employes], " & _
                            "IIF(COUNT(e.idemploye)=0,0,SUM(e.salaire)) AS [Masse salariale DH] " & _
                            "FROM agence a LEFT JOIN employe e ON a.idagence=e.idagence GROUP BY a.nomagence ORDER BY a.nomagence"
        dgvParAgence.DataSource = DBConnection.ExecuteQuery(sql)
        dgvParAgence.ReadOnly = True
    End Sub

    Private Sub ChargerAlertesStock()
        Dim sql As String = "SELECT nomproduit AS [Produit], quantite AS [Qte actuelle], seuilalerte AS [Seuil alerte] " & _
                            "FROM produit WHERE quantite <= seuilalerte ORDER BY quantite ASC"
        dgvAlertes.DataSource = DBConnection.ExecuteQuery(sql)
        dgvAlertes.ReadOnly = True
        For Each row As DataGridViewRow In dgvAlertes.Rows
            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 200, 200)
            row.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed
        Next
        lblNbAlertes.Text = dgvAlertes.Rows.Count & " produit(s) en alerte"
    End Sub

    Private Sub ChargerServices()
        dgvServices.DataSource = DBConnection.ExecuteQuery("SELECT nomservice AS [Service], prix AS [Prix DH], dureeestimee AS [Duree min] FROM service ORDER BY prix DESC")
        dgvServices.ReadOnly = True
    End Sub

    Private Sub ChargerClientsVille()
        Dim sql As String = "SELECT ville AS [Ville], COUNT(*) AS [Nb clients] FROM client WHERE ville IS NOT NULL AND ville <> '' GROUP BY ville ORDER BY COUNT(*) DESC"
        dgvClientsVille.DataSource = DBConnection.ExecuteQuery(sql)
        dgvClientsVille.ReadOnly = True
    End Sub

    Private Sub btnActualiser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnActualiser.Click
        tabStats_SelectedIndexChanged(Nothing, Nothing)
        MsgBox("Données actualisées.", MsgBoxStyle.Information, "Actualisation")
    End Sub

    Private Sub btnQuitter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub


    ' ── Ligne colorée en bas de chaque GroupBox KPI ───────────
    Private Sub frmStatistiques_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        AjouterLigne(grpAgences,      System.Drawing.Color.FromArgb(30, 80, 162))
        AjouterLigne(grpClients,      System.Drawing.Color.FromArgb(0, 150, 136))
        AjouterLigne(grpEmployes,     System.Drawing.Color.FromArgb(156, 39, 176))
        AjouterLigne(grpServices,     System.Drawing.Color.FromArgb(230, 81, 0))
        AjouterLigne(grpProduits,     System.Drawing.Color.FromArgb(21, 101, 192))
        AjouterLigne(grpSalaires,     System.Drawing.Color.FromArgb(183, 28, 28))
        AjouterLigne(grpStock,        System.Drawing.Color.FromArgb(46, 125, 50))
    End Sub

    Private Sub AjouterLigne(ByVal grp As System.Windows.Forms.GroupBox, ByVal couleur As System.Drawing.Color)
        Dim ligne As New System.Windows.Forms.Panel()
        ligne.BackColor = couleur
        ligne.Height = 5
        ligne.Dock = System.Windows.Forms.DockStyle.Bottom
        grp.Controls.Add(ligne)
    End Sub

End Class