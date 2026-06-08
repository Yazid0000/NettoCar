Public Class frmEmployes

    Private Sub frmEmployes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR 1.0 - GESTION DES EMPLOYES"
        StyleHelper.AppliquerIcones(tsMenu)
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
                DBConnection.JournaliserEvenement("SUPPRESSION", AppSession.IdEmployeConnecte, 0, _
                    "Employé supprimé : " & nom)
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
