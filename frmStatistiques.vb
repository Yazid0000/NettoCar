Public Class frmStatistiques

    Private Sub frmStatistiques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR 1.0 - STATISTIQUES"
        StyleHelper.StylerDGV(dgvParAgence)
        StyleHelper.StylerDGV(dgvAlertes)
        StyleHelper.StylerDGV(dgvServices)
        StyleHelper.StylerDGV(dgvClientsVille)
        StyleHelper.AppliquerIcones(tsMenu)
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