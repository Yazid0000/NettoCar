<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatistiques
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.btnActualiser = New System.Windows.Forms.ToolStripButton()
        Me.sep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnQuitter = New System.Windows.Forms.ToolStripButton()
        Me.pnlTitre = New System.Windows.Forms.Panel()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.tabStats = New System.Windows.Forms.TabControl()
        Me.tabDashboard = New System.Windows.Forms.TabPage()
        Me.tabAgences = New System.Windows.Forms.TabPage()
        Me.tabStock = New System.Windows.Forms.TabPage()
        Me.tabServices = New System.Windows.Forms.TabPage()
        Me.tabClients = New System.Windows.Forms.TabPage()
        Me.pnlDashboard = New System.Windows.Forms.TableLayoutPanel()
        Me.grpAgences = New System.Windows.Forms.GroupBox()
        Me.lblNbAgences = New System.Windows.Forms.Label()
        Me.lblTxtAgences = New System.Windows.Forms.Label()
        Me.grpClients = New System.Windows.Forms.GroupBox()
        Me.lblNbClients = New System.Windows.Forms.Label()
        Me.lblTxtClients = New System.Windows.Forms.Label()
        Me.grpEmployes = New System.Windows.Forms.GroupBox()
        Me.lblNbEmployes = New System.Windows.Forms.Label()
        Me.lblTxtEmployes = New System.Windows.Forms.Label()
        Me.grpServices = New System.Windows.Forms.GroupBox()
        Me.lblNbServices = New System.Windows.Forms.Label()
        Me.lblTxtServices = New System.Windows.Forms.Label()
        Me.grpProduits = New System.Windows.Forms.GroupBox()
        Me.lblNbProduits = New System.Windows.Forms.Label()
        Me.lblTxtProduits = New System.Windows.Forms.Label()
        Me.grpSalaires = New System.Windows.Forms.GroupBox()
        Me.lblTotalSalaires = New System.Windows.Forms.Label()
        Me.lblTxtSalaires = New System.Windows.Forms.Label()
        Me.grpStock = New System.Windows.Forms.GroupBox()
        Me.lblValeurStock = New System.Windows.Forms.Label()
        Me.lblTxtStock = New System.Windows.Forms.Label()
        Me.dgvParAgence = New System.Windows.Forms.DataGridView()
        Me.lblNbAlertes = New System.Windows.Forms.Label()
        Me.dgvAlertes = New System.Windows.Forms.DataGridView()
        Me.dgvServices = New System.Windows.Forms.DataGridView()
        Me.dgvClientsVille = New System.Windows.Forms.DataGridView()

        Me.tsMenu.SuspendLayout()
        Me.pnlTitre.SuspendLayout()
        Me.tabStats.SuspendLayout()
        Me.tabDashboard.SuspendLayout()
        Me.tabAgences.SuspendLayout()
        Me.tabStock.SuspendLayout()
        Me.tabServices.SuspendLayout()
        Me.tabClients.SuspendLayout()
        Me.pnlDashboard.SuspendLayout()
        Me.grpAgences.SuspendLayout() : Me.grpClients.SuspendLayout() : Me.grpEmployes.SuspendLayout()
        Me.grpServices.SuspendLayout() : Me.grpProduits.SuspendLayout() : Me.grpSalaires.SuspendLayout() : Me.grpStock.SuspendLayout()
        CType(Me.dgvParAgence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAlertes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClientsVille, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '=== ToolStrip ===
        Me.tsMenu.BackColor = System.Drawing.Color.FromArgb(30, 30, 30)
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu.Name = "tsMenu" : Me.tsMenu.Size = New System.Drawing.Size(984, 62)
        Me.tsMenu.Renderer = New ToolStripProfessionalRenderer(New NettoCouleur())
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnActualiser, Me.sep1, Me.btnQuitter})
        Dim BF As New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnActualiser.Text = "Actualiser" : Me.btnActualiser.Font = BF : Me.btnActualiser.ForeColor = System.Drawing.Color.White : Me.btnActualiser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnActualiser.Name = "btnActualiser" : Me.btnActualiser.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep1.Name = "sep1"
        Me.btnQuitter.Text = "Menu" : Me.btnQuitter.Font = BF : Me.btnQuitter.ForeColor = System.Drawing.Color.White : Me.btnQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnQuitter.Name = "btnQuitter" : Me.btnQuitter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)

        '=== pnlTitre ===
        Me.pnlTitre.Dock = System.Windows.Forms.DockStyle.Top : Me.pnlTitre.Height = 60 : Me.pnlTitre.BackColor = System.Drawing.Color.White : Me.pnlTitre.Name = "pnlTitre"
        Me.lblTitre.Text = "STATISTIQUES & RAPPORTS" : Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold) : Me.lblTitre.ForeColor = System.Drawing.Color.FromArgb(30, 50, 100) : Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblTitre.Dock = System.Windows.Forms.DockStyle.Fill : Me.lblTitre.Name = "lblTitre"
        Me.pnlTitre.Controls.Add(Me.lblTitre)

        '=== KPI GroupBoxes ===
        Dim SetKpi As System.Action(Of System.Windows.Forms.GroupBox, System.Windows.Forms.Label, System.Windows.Forms.Label, String, String, System.Drawing.Color) = Nothing
        ' Agences
        Me.lblNbAgences.Dock = System.Windows.Forms.DockStyle.Fill : Me.lblNbAgences.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold) : Me.lblNbAgences.ForeColor = System.Drawing.Color.FromArgb(30, 80, 162) : Me.lblNbAgences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblNbAgences.Text = "..." : Me.lblNbAgences.Name = "lblNbAgences"
        Me.lblTxtAgences.Dock = System.Windows.Forms.DockStyle.Bottom : Me.lblTxtAgences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblTxtAgences.Text = "agences" : Me.lblTxtAgences.Name = "lblTxtAgences"
        Me.grpAgences.Dock = System.Windows.Forms.DockStyle.Fill : Me.grpAgences.Margin = New System.Windows.Forms.Padding(8) : Me.grpAgences.Text = "Agences" : Me.grpAgences.Name = "grpAgences"
        Me.grpAgences.Controls.Add(Me.lblNbAgences) : Me.grpAgences.Controls.Add(Me.lblTxtAgences)
        ' Clients
        Me.lblNbClients.Dock = System.Windows.Forms.DockStyle.Fill : Me.lblNbClients.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold) : Me.lblNbClients.ForeColor = System.Drawing.Color.FromArgb(0, 150, 136) : Me.lblNbClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblNbClients.Text = "..." : Me.lblNbClients.Name = "lblNbClients"
        Me.lblTxtClients.Dock = System.Windows.Forms.DockStyle.Bottom : Me.lblTxtClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblTxtClients.Text = "clients" : Me.lblTxtClients.Name = "lblTxtClients"
        Me.grpClients.Dock = System.Windows.Forms.DockStyle.Fill : Me.grpClients.Margin = New System.Windows.Forms.Padding(8) : Me.grpClients.Text = "Clients" : Me.grpClients.Name = "grpClients"
        Me.grpClients.Controls.Add(Me.lblNbClients) : Me.grpClients.Controls.Add(Me.lblTxtClients)
        ' Employes
        Me.lblNbEmployes.Dock = System.Windows.Forms.DockStyle.Fill : Me.lblNbEmployes.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold) : Me.lblNbEmployes.ForeColor = System.Drawing.Color.FromArgb(156, 39, 176) : Me.lblNbEmployes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblNbEmployes.Text = "..." : Me.lblNbEmployes.Name = "lblNbEmployes"
        Me.lblTxtEmployes.Dock = System.Windows.Forms.DockStyle.Bottom : Me.lblTxtEmployes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblTxtEmployes.Text = "employes" : Me.lblTxtEmployes.Name = "lblTxtEmployes"
        Me.grpEmployes.Dock = System.Windows.Forms.DockStyle.Fill : Me.grpEmployes.Margin = New System.Windows.Forms.Padding(8) : Me.grpEmployes.Text = "Employes" : Me.grpEmployes.Name = "grpEmployes"
        Me.grpEmployes.Controls.Add(Me.lblNbEmployes) : Me.grpEmployes.Controls.Add(Me.lblTxtEmployes)
        ' Services
        Me.lblNbServices.Dock = System.Windows.Forms.DockStyle.Fill : Me.lblNbServices.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold) : Me.lblNbServices.ForeColor = System.Drawing.Color.FromArgb(230, 81, 0) : Me.lblNbServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblNbServices.Text = "..." : Me.lblNbServices.Name = "lblNbServices"
        Me.lblTxtServices.Dock = System.Windows.Forms.DockStyle.Bottom : Me.lblTxtServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblTxtServices.Text = "services" : Me.lblTxtServices.Name = "lblTxtServices"
        Me.grpServices.Dock = System.Windows.Forms.DockStyle.Fill : Me.grpServices.Margin = New System.Windows.Forms.Padding(8) : Me.grpServices.Text = "Services" : Me.grpServices.Name = "grpServices"
        Me.grpServices.Controls.Add(Me.lblNbServices) : Me.grpServices.Controls.Add(Me.lblTxtServices)
        ' Produits
        Me.lblNbProduits.Dock = System.Windows.Forms.DockStyle.Fill : Me.lblNbProduits.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold) : Me.lblNbProduits.ForeColor = System.Drawing.Color.Teal : Me.lblNbProduits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblNbProduits.Text = "..." : Me.lblNbProduits.Name = "lblNbProduits"
        Me.lblTxtProduits.Dock = System.Windows.Forms.DockStyle.Bottom : Me.lblTxtProduits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblTxtProduits.Text = "produits" : Me.lblTxtProduits.Name = "lblTxtProduits"
        Me.grpProduits.Dock = System.Windows.Forms.DockStyle.Fill : Me.grpProduits.Margin = New System.Windows.Forms.Padding(8) : Me.grpProduits.Text = "Produits" : Me.grpProduits.Name = "grpProduits"
        Me.grpProduits.Controls.Add(Me.lblNbProduits) : Me.grpProduits.Controls.Add(Me.lblTxtProduits)
        ' Salaires
        Me.lblTotalSalaires.Dock = System.Windows.Forms.DockStyle.Fill : Me.lblTotalSalaires.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold) : Me.lblTotalSalaires.ForeColor = System.Drawing.Color.Crimson : Me.lblTotalSalaires.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblTotalSalaires.Text = "..." : Me.lblTotalSalaires.Name = "lblTotalSalaires"
        Me.lblTxtSalaires.Dock = System.Windows.Forms.DockStyle.Bottom : Me.lblTxtSalaires.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblTxtSalaires.Text = "total salaires (DH)" : Me.lblTxtSalaires.Name = "lblTxtSalaires"
        Me.grpSalaires.Dock = System.Windows.Forms.DockStyle.Fill : Me.grpSalaires.Margin = New System.Windows.Forms.Padding(8) : Me.grpSalaires.Text = "Masse salariale" : Me.grpSalaires.Name = "grpSalaires"
        Me.grpSalaires.Controls.Add(Me.lblTotalSalaires) : Me.grpSalaires.Controls.Add(Me.lblTxtSalaires)
        ' Stock
        Me.lblValeurStock.Dock = System.Windows.Forms.DockStyle.Fill : Me.lblValeurStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold) : Me.lblValeurStock.ForeColor = System.Drawing.Color.DarkGoldenrod : Me.lblValeurStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblValeurStock.Text = "..." : Me.lblValeurStock.Name = "lblValeurStock"
        Me.lblTxtStock.Dock = System.Windows.Forms.DockStyle.Bottom : Me.lblTxtStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblTxtStock.Text = "valeur stock (DH)" : Me.lblTxtStock.Name = "lblTxtStock"
        Me.grpStock.Dock = System.Windows.Forms.DockStyle.Fill : Me.grpStock.Margin = New System.Windows.Forms.Padding(8) : Me.grpStock.Text = "Valeur stock" : Me.grpStock.Name = "grpStock"
        Me.grpStock.Controls.Add(Me.lblValeurStock) : Me.grpStock.Controls.Add(Me.lblTxtStock)

        '=== TableLayoutPanel ===
        Me.pnlDashboard.ColumnCount = 4 : Me.pnlDashboard.RowCount = 2
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill : Me.pnlDashboard.Name = "pnlDashboard" : Me.pnlDashboard.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlDashboard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlDashboard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlDashboard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlDashboard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlDashboard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlDashboard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlDashboard.Controls.Add(Me.grpAgences, 0, 0)
        Me.pnlDashboard.Controls.Add(Me.grpClients, 1, 0)
        Me.pnlDashboard.Controls.Add(Me.grpEmployes, 2, 0)
        Me.pnlDashboard.Controls.Add(Me.grpServices, 3, 0)
        Me.pnlDashboard.Controls.Add(Me.grpProduits, 0, 1)
        Me.pnlDashboard.Controls.Add(Me.grpSalaires, 1, 1)
        Me.pnlDashboard.Controls.Add(Me.grpStock, 2, 1)

        '=== Onglets ===
        Me.tabDashboard.Controls.Add(Me.pnlDashboard) : Me.tabDashboard.Name = "tabDashboard" : Me.tabDashboard.Text = "Tableau de bord" : Me.tabDashboard.Padding = New System.Windows.Forms.Padding(5)

        Me.dgvParAgence.AllowUserToAddRows = False : Me.dgvParAgence.AllowUserToDeleteRows = False : Me.dgvParAgence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill : Me.dgvParAgence.Dock = System.Windows.Forms.DockStyle.Fill : Me.dgvParAgence.ReadOnly = True : Me.dgvParAgence.RowTemplate.Height = 24 : Me.dgvParAgence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect : Me.dgvParAgence.Name = "dgvParAgence"
        Me.tabAgences.Controls.Add(Me.dgvParAgence) : Me.tabAgences.Name = "tabAgences" : Me.tabAgences.Text = "Par agence"

        Me.lblNbAlertes.Dock = System.Windows.Forms.DockStyle.Top : Me.lblNbAlertes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold) : Me.lblNbAlertes.ForeColor = System.Drawing.Color.DarkRed : Me.lblNbAlertes.Height = 30 : Me.lblNbAlertes.Name = "lblNbAlertes" : Me.lblNbAlertes.Text = "Chargement..."
        Me.dgvAlertes.AllowUserToAddRows = False : Me.dgvAlertes.AllowUserToDeleteRows = False : Me.dgvAlertes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill : Me.dgvAlertes.Dock = System.Windows.Forms.DockStyle.Fill : Me.dgvAlertes.ReadOnly = True : Me.dgvAlertes.RowTemplate.Height = 24 : Me.dgvAlertes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect : Me.dgvAlertes.Name = "dgvAlertes"
        Me.tabStock.Controls.Add(Me.dgvAlertes) : Me.tabStock.Controls.Add(Me.lblNbAlertes) : Me.tabStock.Name = "tabStock" : Me.tabStock.Text = "Alertes stock"

        Me.dgvServices.AllowUserToAddRows = False : Me.dgvServices.AllowUserToDeleteRows = False : Me.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill : Me.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill : Me.dgvServices.ReadOnly = True : Me.dgvServices.RowTemplate.Height = 24 : Me.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect : Me.dgvServices.Name = "dgvServices"
        Me.tabServices.Controls.Add(Me.dgvServices) : Me.tabServices.Name = "tabServices" : Me.tabServices.Text = "Services"

        Me.dgvClientsVille.AllowUserToAddRows = False : Me.dgvClientsVille.AllowUserToDeleteRows = False : Me.dgvClientsVille.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill : Me.dgvClientsVille.Dock = System.Windows.Forms.DockStyle.Fill : Me.dgvClientsVille.ReadOnly = True : Me.dgvClientsVille.RowTemplate.Height = 24 : Me.dgvClientsVille.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect : Me.dgvClientsVille.Name = "dgvClientsVille"
        Me.tabClients.Controls.Add(Me.dgvClientsVille) : Me.tabClients.Name = "tabClients" : Me.tabClients.Text = "Clients / Ville"

        Me.tabStats.Controls.Add(Me.tabDashboard) : Me.tabStats.Controls.Add(Me.tabAgences) : Me.tabStats.Controls.Add(Me.tabStock) : Me.tabStats.Controls.Add(Me.tabServices) : Me.tabStats.Controls.Add(Me.tabClients)
        Me.tabStats.Dock = System.Windows.Forms.DockStyle.Fill : Me.tabStats.Name = "tabStats" : Me.tabStats.SelectedIndex = 0 : Me.tabStats.TabIndex = 0

        '=== frmStatistiques ===
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!) : Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font : Me.ClientSize = New System.Drawing.Size(984, 600)
        Me.Controls.Add(Me.tabStats) : Me.Controls.Add(Me.pnlTitre) : Me.Controls.Add(Me.tsMenu)
        Me.Name = "frmStatistiques" : Me.Text = "NETTOCAR 1.0 - STATISTIQUES" : Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 252)

        Me.tsMenu.ResumeLayout(False) : Me.tsMenu.PerformLayout()
        Me.pnlTitre.ResumeLayout(False)
        Me.tabStats.ResumeLayout(False)
        Me.tabDashboard.ResumeLayout(False) : Me.tabAgences.ResumeLayout(False) : Me.tabStock.ResumeLayout(False) : Me.tabServices.ResumeLayout(False) : Me.tabClients.ResumeLayout(False)
        Me.pnlDashboard.ResumeLayout(False)
        Me.grpAgences.ResumeLayout(False) : Me.grpClients.ResumeLayout(False) : Me.grpEmployes.ResumeLayout(False)
        Me.grpServices.ResumeLayout(False) : Me.grpProduits.ResumeLayout(False) : Me.grpSalaires.ResumeLayout(False) : Me.grpStock.ResumeLayout(False)
        CType(Me.dgvParAgence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAlertes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClientsVille, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False) : Me.PerformLayout()
    End Sub

    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnActualiser As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnQuitter As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlTitre As System.Windows.Forms.Panel
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents tabStats As System.Windows.Forms.TabControl
    Friend WithEvents tabDashboard As System.Windows.Forms.TabPage
    Friend WithEvents tabAgences As System.Windows.Forms.TabPage
    Friend WithEvents tabStock As System.Windows.Forms.TabPage
    Friend WithEvents tabServices As System.Windows.Forms.TabPage
    Friend WithEvents tabClients As System.Windows.Forms.TabPage
    Friend WithEvents pnlDashboard As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpAgences As System.Windows.Forms.GroupBox
    Friend WithEvents lblNbAgences As System.Windows.Forms.Label
    Friend WithEvents lblTxtAgences As System.Windows.Forms.Label
    Friend WithEvents grpClients As System.Windows.Forms.GroupBox
    Friend WithEvents lblNbClients As System.Windows.Forms.Label
    Friend WithEvents lblTxtClients As System.Windows.Forms.Label
    Friend WithEvents grpEmployes As System.Windows.Forms.GroupBox
    Friend WithEvents lblNbEmployes As System.Windows.Forms.Label
    Friend WithEvents lblTxtEmployes As System.Windows.Forms.Label
    Friend WithEvents grpServices As System.Windows.Forms.GroupBox
    Friend WithEvents lblNbServices As System.Windows.Forms.Label
    Friend WithEvents lblTxtServices As System.Windows.Forms.Label
    Friend WithEvents grpProduits As System.Windows.Forms.GroupBox
    Friend WithEvents lblNbProduits As System.Windows.Forms.Label
    Friend WithEvents lblTxtProduits As System.Windows.Forms.Label
    Friend WithEvents grpSalaires As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalSalaires As System.Windows.Forms.Label
    Friend WithEvents lblTxtSalaires As System.Windows.Forms.Label
    Friend WithEvents grpStock As System.Windows.Forms.GroupBox
    Friend WithEvents lblValeurStock As System.Windows.Forms.Label
    Friend WithEvents lblTxtStock As System.Windows.Forms.Label
    Friend WithEvents dgvParAgence As System.Windows.Forms.DataGridView
    Friend WithEvents lblNbAlertes As System.Windows.Forms.Label
    Friend WithEvents dgvAlertes As System.Windows.Forms.DataGridView
    Friend WithEvents dgvServices As System.Windows.Forms.DataGridView
    Friend WithEvents dgvClientsVille As System.Windows.Forms.DataGridView

End Class
