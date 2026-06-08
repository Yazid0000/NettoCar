Public Class frmJournal

    Private Sub frmJournal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR - Journal de Prévention des Pertes"

        ' Remplir le filtre type
        cboType.Items.Add("Tous")
        cboType.Items.Add("CONNEXION")
        cboType.Items.Add("LAVAGE_DEBUT")
        cboType.Items.Add("LAVAGE_FIN")
        cboType.Items.Add("ANNULATION")
        cboType.Items.Add("MOUVEMENT_STOCK")
        cboType.Items.Add("SUPPRESSION")
        cboType.SelectedIndex = 0

        ' Dates par défaut : ce mois
        dtpDu.Value = New Date(Date.Today.Year, Date.Today.Month, 1)
        dtpAu.Value = Date.Today

        StyleHelper.StylerDGV(dgvJournal)
        ChargerJournal("")
    End Sub

    Private Sub ChargerJournal(ByVal filtreType As String)
        Dim sql As String
        If filtreType = "" OrElse filtreType = "Tous" Then
            sql = "SELECT j.dateevt AS [Date/Heure], j.typeevt AS [Evenement], " & _
                  "e.nom & ' ' & e.prenom AS [Employe], " & _
                  "j.idlavage AS [Lavage N], j.description AS [Detail] " & _
                  "FROM journal_evenements j " & _
                  "LEFT JOIN employe e ON j.idemploye = e.idemploye " & _
                  "WHERE j.dateevt >= #" & dtpDu.Value.Date.ToString("MM/dd/yyyy") & "# " & _
                  "AND j.dateevt < #" & dtpAu.Value.Date.AddDays(1).ToString("MM/dd/yyyy") & "# " & _
                  "ORDER BY j.dateevt DESC"
        Else
            sql = "SELECT j.dateevt AS [Date/Heure], j.typeevt AS [Evenement], " & _
                  "e.nom & ' ' & e.prenom AS [Employe], " & _
                  "j.idlavage AS [Lavage N], j.description AS [Detail] " & _
                  "FROM journal_evenements j " & _
                  "LEFT JOIN employe e ON j.idemploye = e.idemploye " & _
                  "WHERE j.typeevt = '" & filtreType & "' " & _
                  "AND j.dateevt >= #" & dtpDu.Value.Date.ToString("MM/dd/yyyy") & "# " & _
                  "AND j.dateevt < #" & dtpAu.Value.Date.AddDays(1).ToString("MM/dd/yyyy") & "# " & _
                  "ORDER BY j.dateevt DESC"
        End If

        Dim dt As DataTable = DBConnection.ExecuteQuery(sql)
        dgvJournal.DataSource = dt
        dgvJournal.ReadOnly = True
        If dgvJournal.Columns.Count >= 5 Then
            dgvJournal.Columns(0).Width = 200  ' Date/Heure
            dgvJournal.Columns(1).Width = 180  ' Evenement
            dgvJournal.Columns(2).Width = 100  ' Employe
            dgvJournal.Columns(3).Width = 100   ' Lavage N
            dgvJournal.Columns(4).MinimumWidth = 400
            dgvJournal.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If

        ' Colorier les lignes selon le type d'événement
        For Each row As DataGridViewRow In dgvJournal.Rows
            Dim typeEvt As String = ""
            If row.Cells(1).Value IsNot Nothing Then typeEvt = row.Cells(1).Value.ToString()
            Select Case typeEvt
                Case "CONNEXION"
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(100, 220, 150)
                Case "LAVAGE_DEBUT"
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(100, 180, 255)
                Case "LAVAGE_FIN"
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 220, 100)
                Case "ANNULATION"
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100)
                Case "SUPPRESSION"
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 80, 80)
                Case "MOUVEMENT_STOCK"
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(200, 150, 255)
            End Select
        Next

        lblCompteur.Text = dt.Rows.Count & " événement(s)"
    End Sub

    Private Sub btnFiltrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrer.Click
        ChargerJournal(cboType.SelectedItem.ToString())
    End Sub

    Private Sub btnTout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTout.Click
        cboType.SelectedIndex = 0
        dtpDu.Value = New Date(Date.Today.Year, Date.Today.Month, 1)
        dtpAu.Value = Date.Today
        ChargerJournal("")
    End Sub

    Private Sub btnImprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimer.Click
        StyleHelper.ImprimerDGV(dgvJournal, "JOURNAL DE PREVENTION DES PERTES")
    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub

End Class