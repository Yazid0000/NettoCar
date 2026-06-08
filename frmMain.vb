Public Class frmMain

    Private ReadOnly CLR_BTN_NORMAL As System.Drawing.Color = System.Drawing.Color.FromArgb(30, 36, 50)
    Private ReadOnly CLR_BTN_HOVER As System.Drawing.Color = System.Drawing.Color.FromArgb(45, 90, 180)
    Private ReadOnly CLR_BTN_ACTIVE As System.Drawing.Color = System.Drawing.Color.FromArgb(25, 70, 155)
    Private btnActif As System.Windows.Forms.Button = Nothing

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR 1.0 - ACCUEIL"
        Me.DoubleBuffered = True
        timerClock.Start()
        ChargerKPI()
        ChargerActiviteRecente()
        lblUtilisateur.Text = "Connecté : " & AppSession.NomEmployeConnecte
    End Sub

    ' ── Dégradé header sidebar ────────────────────────────────
    Private Sub pnlHeader_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlHeader.Paint
        Dim rect As System.Drawing.Rectangle = pnlHeader.ClientRectangle
        Using brush As New System.Drawing.Drawing2D.LinearGradientBrush(
                rect,
                System.Drawing.Color.FromArgb(20, 50, 120),
                System.Drawing.Color.FromArgb(5, 10, 30),
                System.Drawing.Drawing2D.LinearGradientMode.Vertical)
            e.Graphics.FillRectangle(brush, rect)
        End Using
    End Sub

    ' ── Dégradé TopBar ────────────────────────────────────────
    Private Sub pnlTopBar_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlTopBar.Paint
        Dim rect As System.Drawing.Rectangle = pnlTopBar.ClientRectangle
        Using brush As New System.Drawing.Drawing2D.LinearGradientBrush(
                rect,
                System.Drawing.Color.FromArgb(15, 40, 100),
                System.Drawing.Color.FromArgb(5, 10, 30),
                System.Drawing.Drawing2D.LinearGradientMode.Horizontal)
            e.Graphics.FillRectangle(brush, rect)
        End Using
    End Sub

    ' ── Horloge ───────────────────────────────────────────────
    Private Sub timerClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerClock.Tick
        lblDate.Text = Date.Now.ToString("dddd dd/MM/yyyy   HH:mm:ss") & "  "
    End Sub

    Private Sub timerAlerte_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerAlerte.Tick
        VerifierAlerteStock()
    End Sub

    ' ── KPI dynamiques ────────────────────────────────────────
    Private Sub ChargerKPI()
        Dim nbAgences As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM agence")
        Dim nbClients As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM client")
        Dim nbEmployes As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM employe")
        Dim nbAlertes As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM produit WHERE quantite <= seuilalerte")

        lblCardAgencesVal.Text = If(nbAgences IsNot Nothing, nbAgences.ToString(), "0")
        lblCardClientsVal.Text = If(nbClients IsNot Nothing, nbClients.ToString(), "0")
        lblCardEmployesVal.Text = If(nbEmployes IsNot Nothing, nbEmployes.ToString(), "0")

        Dim count As Integer = 0
        If nbAlertes IsNot Nothing Then Integer.TryParse(nbAlertes.ToString(), count)
        lblCardAlertesVal.Text = count.ToString()

        If count > 0 Then
            cardAlertes.BackColor = System.Drawing.Color.FromArgb(200, 30, 30)
            lblCardAlertesTxt.Text = "Alertes stock"
            lblCardAlertesTxt.ForeColor = System.Drawing.Color.FromArgb(255, 170, 170)
        Else
            cardAlertes.BackColor = System.Drawing.Color.FromArgb(35, 130, 60)
            lblCardAlertesTxt.Text = "Stock OK"
            lblCardAlertesTxt.ForeColor = System.Drawing.Color.FromArgb(160, 255, 180)
        End If
    End Sub

    Private Sub ChargerActiviteRecente()
        Dim sql As String = "SELECT TOP 8 e.nom, e.prenom, e.poste, a.nomagence, e.dateembauche " & _
                            "FROM employe e LEFT JOIN agence a ON e.idagence = a.idagence " & _
                            "ORDER BY e.idemploye DESC"
        Dim dt As DataTable = DBConnection.ExecuteQuery(sql)
        dgvActivite.DataSource = dt
        If dgvActivite.Columns.Count >= 5 Then
            dgvActivite.Columns(0).HeaderText = "Nom"
            dgvActivite.Columns(1).HeaderText = "Prenom"
            dgvActivite.Columns(2).HeaderText = "Poste"
            dgvActivite.Columns(3).HeaderText = "Agence"
            dgvActivite.Columns(4).HeaderText = "Date embauche"
        End If
        dgvActivite.ReadOnly = True
    End Sub

    Private Sub VerifierAlerteStock()
        Dim nb As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM produit WHERE quantite <= seuilalerte")
        Dim count As Integer = 0
        If nb IsNot Nothing Then Integer.TryParse(nb.ToString(), count)
        lblCardAlertesVal.Text = count.ToString()
        If count > 0 Then
            cardAlertes.BackColor = System.Drawing.Color.FromArgb(200, 30, 30)
            btnProduits.BackColor = System.Drawing.Color.FromArgb(100, 20, 20)
        Else
            cardAlertes.BackColor = System.Drawing.Color.FromArgb(35, 130, 60)
            If btnActif IsNot btnProduits Then
                btnProduits.BackColor = CLR_BTN_NORMAL
            End If
        End If
    End Sub

    ' ══════════════════════════════════════════════════════════
    '  HOVER + COINS ARRONDIS sidebar
    ' ══════════════════════════════════════════════════════════
    Private Sub BtnNav_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles btnAgences.MouseEnter, btnClients.MouseEnter, btnEmployes.MouseEnter, _
                    btnServices.MouseEnter, btnProduits.MouseEnter, btnFournisseurs.MouseEnter, _
                    btnStatistiques.MouseEnter, btnLavages.MouseEnter, btnJournal.MouseEnter, btnStock.MouseEnter, btnQuitter.MouseEnter
        Dim btn As System.Windows.Forms.Button = CType(sender, System.Windows.Forms.Button)
        If btn IsNot btnActif Then
            btn.BackColor = CLR_BTN_HOVER
            btn.ForeColor = System.Drawing.Color.White
            btn.Invalidate()
        End If
    End Sub

    Private Sub BtnNav_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles btnAgences.MouseLeave, btnClients.MouseLeave, btnEmployes.MouseLeave, _
                    btnServices.MouseLeave, btnProduits.MouseLeave, btnFournisseurs.MouseLeave, _
                    btnStatistiques.MouseLeave, btnLavages.MouseLeave, btnJournal.MouseLeave, btnStock.MouseLeave, btnQuitter.MouseLeave
        Dim btn As System.Windows.Forms.Button = CType(sender, System.Windows.Forms.Button)
        If btn IsNot btnActif Then
            If btn Is btnQuitter Then
                btn.BackColor = System.Drawing.Color.FromArgb(60, 20, 20)
                btn.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100)
            Else
                btn.BackColor = CLR_BTN_NORMAL
                btn.ForeColor = System.Drawing.Color.FromArgb(200, 210, 230)
            End If
            btn.Invalidate()
        End If
    End Sub

    Private Sub MarquerActif(ByVal btn As System.Windows.Forms.Button)
        If btnActif IsNot Nothing Then
            If btnActif Is btnQuitter Then
                btnActif.BackColor = System.Drawing.Color.FromArgb(60, 20, 20)
                btnActif.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100)
            Else
                btnActif.BackColor = CLR_BTN_NORMAL
                btnActif.ForeColor = System.Drawing.Color.FromArgb(200, 210, 230)
            End If
            btnActif.Invalidate()
        End If
        btnActif = btn
        btn.BackColor = CLR_BTN_ACTIVE
        btn.ForeColor = System.Drawing.Color.White
        btn.Invalidate()
    End Sub

    ' ── Coins arrondis boutons sidebar ────────────────────────
    Private Sub BtnNav_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) _
            Handles btnAgences.Paint, btnClients.Paint, btnEmployes.Paint, _
                    btnServices.Paint, btnProduits.Paint, btnFournisseurs.Paint, _
                    btnStatistiques.Paint, btnLavages.Paint, btnJournal.Paint, btnStock.Paint, btnQuitter.Paint
        Dim btn As System.Windows.Forms.Button = CType(sender, System.Windows.Forms.Button)
        Dim g As System.Drawing.Graphics = e.Graphics
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Dim rect As New System.Drawing.Rectangle(0, 0, btn.Width - 1, btn.Height - 1)
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim r As Integer = 8
        path.AddArc(rect.X, rect.Y, r, r, 180, 90)
        path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90)
        path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90)
        path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90)
        path.CloseFigure()
        Using brush As New System.Drawing.SolidBrush(btn.BackColor)
            g.FillPath(brush, path)
        End Using
        Dim sf As New System.Drawing.StringFormat()
        sf.Alignment = System.Drawing.StringAlignment.Near
        sf.LineAlignment = System.Drawing.StringAlignment.Center
        Dim textRect As New System.Drawing.Rectangle(14, 0, btn.Width - 14, btn.Height)
        g.DrawString(btn.Text, btn.Font, New System.Drawing.SolidBrush(btn.ForeColor), textRect, sf)
    End Sub

    ' ── Coins arrondis cartes KPI ─────────────────────────────
    Private Sub ArrondiCard(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim pnl As System.Windows.Forms.Panel = CType(sender, System.Windows.Forms.Panel)
        Dim g As System.Drawing.Graphics = e.Graphics
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Dim rect As New System.Drawing.Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1)
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim r As Integer = 12
        path.AddArc(rect.X, rect.Y, r, r, 180, 90)
        path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90)
        path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90)
        path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90)
        path.CloseFigure()
        pnl.Region = New System.Drawing.Region(path)
    End Sub

    Private Sub cardAgences_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles cardAgences.Paint
        ArrondiCard(sender, e)
    End Sub
    Private Sub cardClients_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles cardClients.Paint
        ArrondiCard(sender, e)
    End Sub
    Private Sub cardEmployes_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles cardEmployes.Paint
        ArrondiCard(sender, e)
    End Sub
    Private Sub cardAlertes_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles cardAlertes.Paint
        ArrondiCard(sender, e)
    End Sub

    ' ══════════════════════════════════════════════════════════
    '  NAVIGATION
    ' ══════════════════════════════════════════════════════════
    Private Sub btnAgences_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgences.Click
        MarquerActif(btnAgences) : OuvrirFenetre(New frmAgences())
    End Sub
    Private Sub btnClients_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClients.Click
        MarquerActif(btnClients) : OuvrirFenetre(New frmClients())
    End Sub
    Private Sub btnEmployes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployes.Click
        MarquerActif(btnEmployes) : OuvrirFenetre(New frmEmployes())
    End Sub
    Private Sub btnServices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServices.Click
        MarquerActif(btnServices) : OuvrirFenetre(New frmServices())
    End Sub
    Private Sub btnProduits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduits.Click
        MarquerActif(btnProduits) : OuvrirFenetre(New frmProduits())
    End Sub
    Private Sub btnFournisseurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFournisseurs.Click
        MarquerActif(btnFournisseurs) : OuvrirFenetre(New frmFournisseurs())
    End Sub
    Private Sub btnStatistiques_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatistiques.Click
        MarquerActif(btnStatistiques) : OuvrirFenetre(New frmStatistiques())
    End Sub
    Private Sub btnLavages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLavages.Click
        MarquerActif(btnLavages)
        OuvrirFenetre(New frmLavages())
    End Sub
    Private Sub btnJournal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJournal.Click
        MarquerActif(btnJournal)
        OuvrirFenetre(New frmJournal())
    End Sub
    Private Sub btnStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStock.Click
        MarquerActif(btnStock)
        OuvrirFenetre(New frmStock())
    End Sub
    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        Dim rep As MsgBoxResult = MsgBox("Voulez-vous quitter l'application ?", _
                                         MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Quitter")
        If rep = MsgBoxResult.Yes Then Application.Exit()
    End Sub

    Private Sub OuvrirFenetre(ByVal frm As Form)
        Me.Hide()
        frm.WindowState = FormWindowState.Maximized
        AddHandler frm.FormClosed, AddressOf Enfant_FormClosed
        frm.Show()
    End Sub

    Private Sub Enfant_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        If btnActif IsNot Nothing Then
            btnActif.BackColor = CLR_BTN_NORMAL
            btnActif.ForeColor = System.Drawing.Color.FromArgb(200, 210, 230)
            btnActif.Invalidate()
            btnActif = Nothing
        End If
        Me.Show()
        Me.WindowState = FormWindowState.Maximized
        Me.BringToFront()
        ChargerKPI()
        ChargerActiviteRecente()
    End Sub

End Class
