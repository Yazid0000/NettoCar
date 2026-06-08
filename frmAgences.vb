Public Class frmAgences

    Private Sub frmAgences_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR 1.0 - GESTION DES AGENCES"
        StyleHelper.StylerDGV(dgvAgences)
        StyleHelper.AppliquerIcones(tsMenu)
        ChargerAgences()
    End Sub

    Public Sub ChargerAgences()
        Dim sql As String = "SELECT * FROM agence ORDER BY nomagence"
        Dim dt As DataTable = DBConnection.ExecuteQuery(sql)
        dgvAgences.DataSource = dt
        StyleHelper.StylerCompteur(lblCompteur, "Nombre d'agences", dt.Rows.Count)
    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        Dim frm As New frmDialogAgence(False, 0)
        frm.ShowDialog()
        ChargerAgences()
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        If dgvAgences.CurrentRow Is Nothing OrElse dgvAgences.Rows.Count = 0 Then
            MsgBox("Veuillez sélectionner une agence.", MsgBoxStyle.Exclamation, "Info")
            Exit Sub
        End If
        Dim id As Integer = CInt(dgvAgences.CurrentRow.Cells("idagence").Value)
        Dim frm As New frmDialogAgence(True, id)
        frm.ShowDialog()
        ChargerAgences()
    End Sub

    Private Sub btnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimer.Click
        If dgvAgences.CurrentRow Is Nothing OrElse dgvAgences.Rows.Count = 0 Then
            MsgBox("Veuillez sélectionner une agence.", MsgBoxStyle.Exclamation, "Info")
            Exit Sub
        End If
        Dim nom As String = dgvAgences.CurrentRow.Cells("nomagence").Value.ToString()
        Dim id As Integer = CInt(dgvAgences.CurrentRow.Cells("idagence").Value)
        Dim rep As MsgBoxResult = MsgBox("Supprimer l'agence « " & nom & " » ?", _
                                         MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
        If rep = MsgBoxResult.Yes Then
            Dim params As New List(Of OleDb.OleDbParameter)
            params.Add(New OleDb.OleDbParameter("@id", id))
            If DBConnection.ExecuteNonQuery("DELETE FROM agence WHERE idagence=?", params) Then
                MsgBox("Agence supprimée.", MsgBoxStyle.Information, "Succès")
                ChargerAgences()
            End If
        End If
    End Sub

    Private Sub btnActualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualiser.Click
        ChargerAgences()
    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim terme As String = txtSearch.Text.Trim().ToLower()
        If terme = "" Then
            ChargerAgences()
            Return
        End If
        Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT * FROM agence ORDER BY nomagence")
        Dim dtFiltree As DataTable = dt.Clone()
        For Each row As DataRow In dt.Rows
            For Each col As DataColumn In dt.Columns
                If row(col) IsNot DBNull.Value Then
                    If row(col).ToString().ToLower().Contains(terme) Then
                        dtFiltree.ImportRow(row)
                        Exit For
                    End If
                End If
            Next
        Next
        dgvAgences.DataSource = dtFiltree
        StyleHelper.StylerCompteur(lblCompteur, "Nombre d'agences", dtFiltree.Rows.Count)
    End Sub

    ' ── Impression ────────────────────────────────────────────
    Private Sub btnImprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimer.Click
        StyleHelper.ImprimerDGV(dgvAgences, "GESTION DES AGENCES")
    End Sub

    ' ── Surbrillance verte après ajout/modif ──────────────────
    Public Sub SurbrillanceLigne(ByVal idColonne As String, ByVal valeurId As Object)
        For Each row As DataGridViewRow In dgvAgences.Rows
            If row.Cells(idColonne).Value IsNot Nothing Then
                If row.Cells(idColonne).Value.ToString() = valeurId.ToString() Then
                    Dim rowLocal As DataGridViewRow = row
                    rowLocal.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(180, 230, 180)
                    dgvAgences.FirstDisplayedScrollingRowIndex = rowLocal.Index
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
            End If
        Next
    End Sub

End Class
