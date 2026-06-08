<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnJournal = New System.Windows.Forms.Button()
        Me.btnLavages = New System.Windows.Forms.Button()
        Me.lblUtilisateur = New System.Windows.Forms.Label()
        Me.components = New System.ComponentModel.Container()
        Me.timerClock = New System.Windows.Forms.Timer(Me.components)
        Me.timerAlerte = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitreApp = New System.Windows.Forms.Label()
        Me.lblSousTitre = New System.Windows.Forms.Label()
        Me.pnlNavBtns = New System.Windows.Forms.Panel()
        Me.btnAgences = New System.Windows.Forms.Button()
        Me.btnClients = New System.Windows.Forms.Button()
        Me.btnEmployes = New System.Windows.Forms.Button()
        Me.btnServices = New System.Windows.Forms.Button()
        Me.btnProduits = New System.Windows.Forms.Button()
        Me.btnFournisseurs = New System.Windows.Forms.Button()
        Me.btnStatistiques = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblBienvenue = New System.Windows.Forms.Label()
        Me.pnlCards = New System.Windows.Forms.Panel()
        Me.cardAgences = New System.Windows.Forms.Panel()
        Me.lblCardAgencesVal = New System.Windows.Forms.Label()
        Me.lblCardAgencesTxt = New System.Windows.Forms.Label()
        Me.cardClients = New System.Windows.Forms.Panel()
        Me.lblCardClientsVal = New System.Windows.Forms.Label()
        Me.lblCardClientsTxt = New System.Windows.Forms.Label()
        Me.cardEmployes = New System.Windows.Forms.Panel()
        Me.lblCardEmployesVal = New System.Windows.Forms.Label()
        Me.lblCardEmployesTxt = New System.Windows.Forms.Label()
        Me.cardAlertes = New System.Windows.Forms.Panel()
        Me.lblCardAlertesVal = New System.Windows.Forms.Label()
        Me.lblCardAlertesTxt = New System.Windows.Forms.Label()
        Me.pnlActivite = New System.Windows.Forms.Panel()
        Me.lblActiviteTitre = New System.Windows.Forms.Label()
        Me.dgvActivite = New System.Windows.Forms.DataGridView()

        Me.pnlSidebar.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlNavBtns.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlCards.SuspendLayout()
        Me.cardAgences.SuspendLayout()
        Me.cardClients.SuspendLayout()
        Me.cardEmployes.SuspendLayout()
        Me.cardAlertes.SuspendLayout()
        Me.pnlActivite.SuspendLayout()
        CType(Me.dgvActivite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ── Timers ──
        Me.timerClock.Enabled = True
        Me.timerClock.Interval = 1000
        Me.timerAlerte.Enabled = True
        Me.timerAlerte.Interval = 30000

        ' ══════════════════════════════════════════════════════
        '  SIDEBAR
        ' ══════════════════════════════════════════════════════
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(18, 22, 30)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Width = 260
        Me.pnlSidebar.Name = "pnlSidebar"

        ' Header sidebar
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(10, 20, 55)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 100
        Me.pnlHeader.Name = "pnlHeader"

        Me.lblTitreApp.Text = "NETTOCAR"
        Me.lblTitreApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitreApp.ForeColor = System.Drawing.Color.White
        Me.lblTitreApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTitreApp.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitreApp.Height = 65
        Me.lblTitreApp.Name = "lblTitreApp"

        Me.lblSousTitre.Text = "Gestion Lavage Auto"
        Me.lblSousTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblSousTitre.ForeColor = System.Drawing.Color.FromArgb(120, 160, 230)
        Me.lblSousTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSousTitre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSousTitre.Name = "lblSousTitre"

        Me.pnlHeader.Controls.Add(Me.lblSousTitre)
        Me.pnlHeader.Controls.Add(Me.lblTitreApp)

        ' Panel boutons nav
        Me.pnlNavBtns.BackColor = System.Drawing.Color.FromArgb(18, 22, 30)
        Me.pnlNavBtns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNavBtns.Name = "pnlNavBtns"


        ' btnAgences
        Me.btnAgences.Text = "   Agences"
        Me.btnAgences.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgences.ForeColor = System.Drawing.Color.FromArgb(200, 210, 230)
        Me.btnAgences.BackColor = System.Drawing.Color.FromArgb(30, 36, 50)
        Me.btnAgences.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgences.FlatAppearance.BorderSize = 0
        Me.btnAgences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgences.Location = New System.Drawing.Point(15, 20)
        Me.btnAgences.Size = New System.Drawing.Size(230, 44)
        Me.btnAgences.Name = "btnAgences"
        Me.btnAgences.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgences.TabIndex = 0

        ' btnClients
        Me.btnClients.Text = "   Clients"
        Me.btnClients.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClients.ForeColor = System.Drawing.Color.FromArgb(200, 210, 230)
        Me.btnClients.BackColor = System.Drawing.Color.FromArgb(30, 36, 50)
        Me.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClients.FlatAppearance.BorderSize = 0
        Me.btnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClients.Location = New System.Drawing.Point(15, 72)
        Me.btnClients.Size = New System.Drawing.Size(230, 44)
        Me.btnClients.Name = "btnClients"
        Me.btnClients.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClients.TabIndex = 1

        ' btnEmployes
        Me.btnEmployes.Text = "   Employes"
        Me.btnEmployes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEmployes.ForeColor = System.Drawing.Color.FromArgb(200, 210, 230)
        Me.btnEmployes.BackColor = System.Drawing.Color.FromArgb(30, 36, 50)
        Me.btnEmployes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployes.FlatAppearance.BorderSize = 0
        Me.btnEmployes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployes.Location = New System.Drawing.Point(15, 124)
        Me.btnEmployes.Size = New System.Drawing.Size(230, 44)
        Me.btnEmployes.Name = "btnEmployes"
        Me.btnEmployes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmployes.TabIndex = 2

        ' btnServices
        Me.btnServices.Text = "   Services"
        Me.btnServices.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnServices.ForeColor = System.Drawing.Color.FromArgb(200, 210, 230)
        Me.btnServices.BackColor = System.Drawing.Color.FromArgb(30, 36, 50)
        Me.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServices.FlatAppearance.BorderSize = 0
        Me.btnServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnServices.Location = New System.Drawing.Point(15, 176)
        Me.btnServices.Size = New System.Drawing.Size(230, 44)
        Me.btnServices.Name = "btnServices"
        Me.btnServices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnServices.TabIndex = 3

        ' btnProduits
        Me.btnProduits.Text = "   Produits"
        Me.btnProduits.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnProduits.ForeColor = System.Drawing.Color.FromArgb(200, 210, 230)
        Me.btnProduits.BackColor = System.Drawing.Color.FromArgb(30, 36, 50)
        Me.btnProduits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduits.FlatAppearance.BorderSize = 0
        Me.btnProduits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduits.Location = New System.Drawing.Point(15, 228)
        Me.btnProduits.Size = New System.Drawing.Size(230, 44)
        Me.btnProduits.Name = "btnProduits"
        Me.btnProduits.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProduits.TabIndex = 4

        ' btnFournisseurs
        Me.btnFournisseurs.Text = "   Fournisseurs"
        Me.btnFournisseurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnFournisseurs.ForeColor = System.Drawing.Color.FromArgb(200, 210, 230)
        Me.btnFournisseurs.BackColor = System.Drawing.Color.FromArgb(30, 36, 50)
        Me.btnFournisseurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFournisseurs.FlatAppearance.BorderSize = 0
        Me.btnFournisseurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFournisseurs.Location = New System.Drawing.Point(15, 280)
        Me.btnFournisseurs.Size = New System.Drawing.Size(230, 44)
        Me.btnFournisseurs.Name = "btnFournisseurs"
        Me.btnFournisseurs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFournisseurs.TabIndex = 5

        ' btnStock
        Me.btnStock.Text = "   Stock"
        Me.btnStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnStock.ForeColor = System.Drawing.Color.FromArgb(200, 210, 230)
        Me.btnStock.BackColor = System.Drawing.Color.FromArgb(30, 36, 50)
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStock.FlatAppearance.BorderSize = 0
        Me.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStock.Location = New System.Drawing.Point(15, 332)
        Me.btnStock.Size = New System.Drawing.Size(230, 44)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStock.TabIndex = 10

        ' btnStatistiques
        Me.btnStatistiques.Text = "   Statistiques"
        Me.btnStatistiques.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnStatistiques.ForeColor = System.Drawing.Color.FromArgb(200, 210, 230)
        Me.btnStatistiques.BackColor = System.Drawing.Color.FromArgb(30, 36, 50)
        Me.btnStatistiques.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatistiques.FlatAppearance.BorderSize = 0
        Me.btnStatistiques.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatistiques.Location = New System.Drawing.Point(15, 384)
        Me.btnStatistiques.Size = New System.Drawing.Size(230, 44)
        Me.btnStatistiques.Name = "btnStatistiques"
        Me.btnStatistiques.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStatistiques.TabIndex = 6

        ' btnLavages
        Me.btnLavages.Text = "   Lavages"
        Me.btnLavages.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLavages.ForeColor = System.Drawing.Color.FromArgb(200, 210, 230)
        Me.btnLavages.BackColor = System.Drawing.Color.FromArgb(30, 36, 50)
        Me.btnLavages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLavages.FlatAppearance.BorderSize = 0
        Me.btnLavages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLavages.Location = New System.Drawing.Point(15, 436)
        Me.btnLavages.Size = New System.Drawing.Size(230, 44)
        Me.btnLavages.Name = "btnLavages"
        Me.btnLavages.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLavages.TabIndex = 8

        ' btnJournal
        Me.btnJournal.Text = "   Journal"
        Me.btnJournal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnJournal.ForeColor = System.Drawing.Color.FromArgb(200, 210, 230)
        Me.btnJournal.BackColor = System.Drawing.Color.FromArgb(30, 36, 50)
        Me.btnJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJournal.FlatAppearance.BorderSize = 0
        Me.btnJournal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJournal.Location = New System.Drawing.Point(15, 488)
        Me.btnJournal.Size = New System.Drawing.Size(230, 44)
        Me.btnJournal.Name = "btnJournal"
        Me.btnJournal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJournal.TabIndex = 9

        ' btnQuitter (rouge)
        Me.btnQuitter.Text = "   Quitter"
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnQuitter.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100)
        Me.btnQuitter.BackColor = System.Drawing.Color.FromArgb(60, 20, 20)
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitter.FlatAppearance.BorderSize = 0
        Me.btnQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitter.Location = New System.Drawing.Point(15, 540)
        Me.btnQuitter.Size = New System.Drawing.Size(230, 44)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitter.TabIndex = 7

        Me.pnlNavBtns.Controls.Add(Me.btnAgences)
        Me.pnlNavBtns.Controls.Add(Me.btnClients)
        Me.pnlNavBtns.Controls.Add(Me.btnEmployes)
        Me.pnlNavBtns.Controls.Add(Me.btnServices)
        Me.pnlNavBtns.Controls.Add(Me.btnProduits)
        Me.pnlNavBtns.Controls.Add(Me.btnFournisseurs)
        Me.pnlNavBtns.Controls.Add(Me.btnStock)
        Me.pnlNavBtns.Controls.Add(Me.btnStatistiques)
        Me.pnlNavBtns.Controls.Add(Me.btnLavages)
        Me.pnlNavBtns.Controls.Add(Me.btnJournal)
        Me.pnlNavBtns.Controls.Add(Me.btnQuitter)
        Me.pnlSidebar.Controls.Add(Me.pnlNavBtns)
        Me.pnlSidebar.Controls.Add(Me.pnlHeader)

        ' ══════════════════════════════════════════════════════
        '  ZONE PRINCIPALE
        ' ══════════════════════════════════════════════════════
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(28, 33, 45)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(25, 0, 25, 20)

        ' TopBar
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(10, 20, 55)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Height = 55
        Me.pnlTopBar.Name = "pnlTopBar"

        Me.lblBienvenue.Text = "  Tableau de bord"
        Me.lblBienvenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblBienvenue.ForeColor = System.Drawing.Color.White
        Me.lblBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBienvenue.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblBienvenue.Width = 320
        Me.lblBienvenue.Name = "lblBienvenue"

        Me.lblDate.Text = ""
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(150, 170, 220)
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblDate.Width = 220
        Me.lblDate.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.lblDate.Name = "lblDate"

        Me.lblUtilisateur.Text = ""
        Me.lblUtilisateur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUtilisateur.ForeColor = System.Drawing.Color.FromArgb(100, 220, 150)
        Me.lblUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblUtilisateur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUtilisateur.Name = "lblUtilisateur"

        Me.pnlTopBar.Controls.Add(Me.lblDate)
        Me.pnlTopBar.Controls.Add(Me.lblUtilisateur)
        Me.pnlTopBar.Controls.Add(Me.lblBienvenue)

        ' ══════════════════════════════════════════════════════
        '  4 CARTES KPI
        ' ══════════════════════════════════════════════════════
        Me.pnlCards.BackColor = System.Drawing.Color.FromArgb(28, 33, 45)
        Me.pnlCards.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCards.Height = 140
        Me.pnlCards.Name = "pnlCards"

        ' Helper pour créer une carte

        ' Carte Agences
        Me.cardAgences.BackColor = System.Drawing.Color.FromArgb(25, 70, 155)
        Me.cardAgences.Location = New System.Drawing.Point(0, 20)
        Me.cardAgences.Size = New System.Drawing.Size(200, 110)
        Me.cardAgences.Name = "cardAgences"
        Me.lblCardAgencesVal.Text = "..."
        Me.lblCardAgencesVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardAgencesVal.ForeColor = System.Drawing.Color.White
        Me.lblCardAgencesVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCardAgencesVal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCardAgencesVal.Name = "lblCardAgencesVal"
        Me.lblCardAgencesTxt.Text = "Agences"
        Me.lblCardAgencesTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardAgencesTxt.ForeColor = System.Drawing.Color.FromArgb(160, 200, 255)
        Me.lblCardAgencesTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCardAgencesTxt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCardAgencesTxt.Height = 28
        Me.lblCardAgencesTxt.Name = "lblCardAgencesTxt"
        Me.cardAgences.Controls.Add(Me.lblCardAgencesVal)
        Me.cardAgences.Controls.Add(Me.lblCardAgencesTxt)

        ' Carte Clients
        Me.cardClients.BackColor = System.Drawing.Color.FromArgb(0, 110, 100)
        Me.cardClients.Location = New System.Drawing.Point(218, 20)
        Me.cardClients.Size = New System.Drawing.Size(200, 110)
        Me.cardClients.Name = "cardClients"
        Me.lblCardClientsVal.Text = "..."
        Me.lblCardClientsVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardClientsVal.ForeColor = System.Drawing.Color.White
        Me.lblCardClientsVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCardClientsVal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCardClientsVal.Name = "lblCardClientsVal"
        Me.lblCardClientsTxt.Text = "Clients"
        Me.lblCardClientsTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardClientsTxt.ForeColor = System.Drawing.Color.FromArgb(160, 240, 220)
        Me.lblCardClientsTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCardClientsTxt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCardClientsTxt.Height = 28
        Me.lblCardClientsTxt.Name = "lblCardClientsTxt"
        Me.cardClients.Controls.Add(Me.lblCardClientsVal)
        Me.cardClients.Controls.Add(Me.lblCardClientsTxt)

        ' Carte Employes
        Me.cardEmployes.BackColor = System.Drawing.Color.FromArgb(110, 25, 130)
        Me.cardEmployes.Location = New System.Drawing.Point(436, 20)
        Me.cardEmployes.Size = New System.Drawing.Size(200, 110)
        Me.cardEmployes.Name = "cardEmployes"
        Me.lblCardEmployesVal.Text = "..."
        Me.lblCardEmployesVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardEmployesVal.ForeColor = System.Drawing.Color.White
        Me.lblCardEmployesVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCardEmployesVal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCardEmployesVal.Name = "lblCardEmployesVal"
        Me.lblCardEmployesTxt.Text = "Employes"
        Me.lblCardEmployesTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardEmployesTxt.ForeColor = System.Drawing.Color.FromArgb(220, 170, 255)
        Me.lblCardEmployesTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCardEmployesTxt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCardEmployesTxt.Height = 28
        Me.lblCardEmployesTxt.Name = "lblCardEmployesTxt"
        Me.cardEmployes.Controls.Add(Me.lblCardEmployesVal)
        Me.cardEmployes.Controls.Add(Me.lblCardEmployesTxt)

        ' Carte Alertes
        Me.cardAlertes.BackColor = System.Drawing.Color.FromArgb(150, 25, 25)
        Me.cardAlertes.Location = New System.Drawing.Point(654, 20)
        Me.cardAlertes.Size = New System.Drawing.Size(200, 110)
        Me.cardAlertes.Name = "cardAlertes"
        Me.lblCardAlertesVal.Text = "..."
        Me.lblCardAlertesVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardAlertesVal.ForeColor = System.Drawing.Color.White
        Me.lblCardAlertesVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCardAlertesVal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCardAlertesVal.Name = "lblCardAlertesVal"
        Me.lblCardAlertesTxt.Text = "Alertes stock"
        Me.lblCardAlertesTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardAlertesTxt.ForeColor = System.Drawing.Color.FromArgb(255, 170, 170)
        Me.lblCardAlertesTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCardAlertesTxt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCardAlertesTxt.Height = 28
        Me.lblCardAlertesTxt.Name = "lblCardAlertesTxt"
        Me.cardAlertes.Controls.Add(Me.lblCardAlertesVal)
        Me.cardAlertes.Controls.Add(Me.lblCardAlertesTxt)

        Me.pnlCards.Controls.Add(Me.cardAgences)
        Me.pnlCards.Controls.Add(Me.cardClients)
        Me.pnlCards.Controls.Add(Me.cardEmployes)
        Me.pnlCards.Controls.Add(Me.cardAlertes)

        ' ══════════════════════════════════════════════════════
        '  ZONE ACTIVITE RECENTE
        ' ══════════════════════════════════════════════════════
        Me.pnlActivite.BackColor = System.Drawing.Color.FromArgb(33, 38, 52)
        Me.pnlActivite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlActivite.Name = "pnlActivite"
        Me.pnlActivite.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)

        Me.lblActiviteTitre.Text = "  Employes recents"
        Me.lblActiviteTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblActiviteTitre.ForeColor = System.Drawing.Color.FromArgb(170, 190, 235)
        Me.lblActiviteTitre.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblActiviteTitre.Height = 38
        Me.lblActiviteTitre.Name = "lblActiviteTitre"

        Me.dgvActivite.AllowUserToAddRows = False
        Me.dgvActivite.AllowUserToDeleteRows = False
        Me.dgvActivite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvActivite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvActivite.ReadOnly = True
        Me.dgvActivite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActivite.MultiSelect = False
        Me.dgvActivite.Name = "dgvActivite"
        Me.dgvActivite.BackgroundColor = System.Drawing.Color.FromArgb(33, 38, 52)
        Me.dgvActivite.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvActivite.RowTemplate.Height = 30
        Me.dgvActivite.EnableHeadersVisualStyles = False
        Me.dgvActivite.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 22, 35)
        Me.dgvActivite.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(140, 165, 215)
        Me.dgvActivite.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvActivite.ColumnHeadersHeight = 32
        Me.dgvActivite.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(33, 38, 52)
        Me.dgvActivite.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(195, 205, 225)
        Me.dgvActivite.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 46, 62)
        Me.dgvActivite.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(25, 70, 155)
        Me.dgvActivite.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvActivite.GridColor = System.Drawing.Color.FromArgb(48, 55, 72)
        Me.dgvActivite.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal

        Me.pnlActivite.Controls.Add(Me.dgvActivite)
        Me.pnlActivite.Controls.Add(Me.lblActiviteTitre)

        Me.pnlMain.Controls.Add(Me.pnlActivite)
        Me.pnlMain.Controls.Add(Me.pnlCards)
        Me.pnlMain.Controls.Add(Me.pnlTopBar)

        ' ── Form ──
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Name = "frmMain"
        Me.Text = "NETTOCAR 1.0 - ACCUEIL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = System.Drawing.Color.FromArgb(28, 33, 45)

        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlNavBtns.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlCards.ResumeLayout(False)
        Me.cardAgences.ResumeLayout(False)
        Me.cardClients.ResumeLayout(False)
        Me.cardEmployes.ResumeLayout(False)
        Me.cardAlertes.ResumeLayout(False)
        Me.pnlActivite.ResumeLayout(False)
        CType(Me.dgvActivite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents timerClock As System.Windows.Forms.Timer
    Friend WithEvents timerAlerte As System.Windows.Forms.Timer
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitreApp As System.Windows.Forms.Label
    Friend WithEvents lblSousTitre As System.Windows.Forms.Label
    Friend WithEvents pnlNavBtns As System.Windows.Forms.Panel
    Friend WithEvents btnAgences As System.Windows.Forms.Button
    Friend WithEvents btnClients As System.Windows.Forms.Button
    Friend WithEvents btnEmployes As System.Windows.Forms.Button
    Friend WithEvents btnServices As System.Windows.Forms.Button
    Friend WithEvents btnProduits As System.Windows.Forms.Button
    Friend WithEvents btnFournisseurs As System.Windows.Forms.Button
    Friend WithEvents btnStatistiques As System.Windows.Forms.Button
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlTopBar As System.Windows.Forms.Panel
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblBienvenue As System.Windows.Forms.Label
    Friend WithEvents pnlCards As System.Windows.Forms.Panel
    Friend WithEvents cardAgences As System.Windows.Forms.Panel
    Friend WithEvents lblCardAgencesVal As System.Windows.Forms.Label
    Friend WithEvents lblCardAgencesTxt As System.Windows.Forms.Label
    Friend WithEvents cardClients As System.Windows.Forms.Panel
    Friend WithEvents lblCardClientsVal As System.Windows.Forms.Label
    Friend WithEvents lblCardClientsTxt As System.Windows.Forms.Label
    Friend WithEvents cardEmployes As System.Windows.Forms.Panel
    Friend WithEvents lblCardEmployesVal As System.Windows.Forms.Label
    Friend WithEvents lblCardEmployesTxt As System.Windows.Forms.Label
    Friend WithEvents cardAlertes As System.Windows.Forms.Panel
    Friend WithEvents lblCardAlertesVal As System.Windows.Forms.Label
    Friend WithEvents lblCardAlertesTxt As System.Windows.Forms.Label
    Friend WithEvents pnlActivite As System.Windows.Forms.Panel
    Friend WithEvents lblActiviteTitre As System.Windows.Forms.Label
    Friend WithEvents dgvActivite As System.Windows.Forms.DataGridView
    Friend WithEvents lblUtilisateur As System.Windows.Forms.Label
    Friend WithEvents btnLavages As System.Windows.Forms.Button
    Friend WithEvents btnJournal As System.Windows.Forms.Button
    Friend WithEvents btnStock As System.Windows.Forms.Button

End Class
