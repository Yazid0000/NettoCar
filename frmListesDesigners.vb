' ================================================================
'  Designers des formulaires liste — style NettoCar
'  Chaque formulaire : ToolStrip bleu + Titre centré + DGV
' ================================================================

' ── Sous-classe partagée NettoCouleur (renderer ToolStrip bleu) ──
' (déjà définie dans frmAgences.Designer.vb, ne pas redéclarer)


' ============================================================
'  frmClients.Designer.vb
' ============================================================
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClients
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
        Me.btnAjouter = New System.Windows.Forms.ToolStripButton()
        Me.sep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnModifier = New System.Windows.Forms.ToolStripButton()
        Me.sep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSupprimer = New System.Windows.Forms.ToolStripButton()
        Me.sep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnActualiser = New System.Windows.Forms.ToolStripButton()
        Me.sep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnQuitter = New System.Windows.Forms.ToolStripButton()
        Me.sepImp = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimer = New System.Windows.Forms.ToolStripButton()
        Me.sepSearch = New System.Windows.Forms.ToolStripSeparator()
        Me.lblSearch = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.pnlTitre = New System.Windows.Forms.Panel()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblCompteur = New System.Windows.Forms.Label()
        Me.dgvClients = New System.Windows.Forms.DataGridView()
        Me.tsMenu.SuspendLayout()
        Me.pnlTitre.SuspendLayout()
        CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.tsMenu.BackColor = System.Drawing.Color.FromArgb(30, 80, 162)
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMenu.Name = "tsMenu" : Me.tsMenu.Size = New System.Drawing.Size(984, 48)
        Me.tsMenu.Renderer = New ToolStripProfessionalRenderer(New NettoCouleur())
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAjouter, Me.sep1, Me.btnModifier, Me.sep2, Me.btnSupprimer, Me.sep3, Me.btnActualiser, Me.sep4, Me.btnQuitter, Me.sepImp, Me.btnImprimer, Me.sepSearch, Me.lblSearch, Me.txtSearch})
        Dim BF As New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAjouter.Text = "Ajouter" : Me.btnAjouter.Font = BF : Me.btnAjouter.ForeColor = System.Drawing.Color.White : Me.btnAjouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnAjouter.Name = "btnAjouter" : Me.btnAjouter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep1.Name = "sep1"
        Me.btnModifier.Text = "Modifier" : Me.btnModifier.Font = BF : Me.btnModifier.ForeColor = System.Drawing.Color.White : Me.btnModifier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnModifier.Name = "btnModifier" : Me.btnModifier.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep2.Name = "sep2"
        Me.btnSupprimer.Text = "Supprimer" : Me.btnSupprimer.Font = BF : Me.btnSupprimer.ForeColor = System.Drawing.Color.White : Me.btnSupprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnSupprimer.Name = "btnSupprimer" : Me.btnSupprimer.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep3.Name = "sep3"
        Me.btnActualiser.Text = "Actualiser" : Me.btnActualiser.Font = BF : Me.btnActualiser.ForeColor = System.Drawing.Color.White : Me.btnActualiser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnActualiser.Name = "btnActualiser" : Me.btnActualiser.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep4.Name = "sep4"
        Me.btnQuitter.Text = "Menu" : Me.btnQuitter.Font = BF : Me.btnQuitter.ForeColor = System.Drawing.Color.White : Me.btnQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnQuitter.Name = "btnQuitter" : Me.btnQuitter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.pnlTitre.Dock = System.Windows.Forms.DockStyle.Top : Me.pnlTitre.Height = 80 : Me.pnlTitre.BackColor = System.Drawing.Color.White : Me.pnlTitre.Name = "pnlTitre"
        Me.lblTitre.Text = "GESTION DES CLIENTS" : Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold) : Me.lblTitre.ForeColor = System.Drawing.Color.FromArgb(30, 50, 100) : Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblTitre.Dock = System.Windows.Forms.DockStyle.Top : Me.lblTitre.Height = 50 : Me.lblTitre.Name = "lblTitre"
        Me.lblCompteur.Text = "Nombre de clients : 0" : Me.lblCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold) : Me.lblCompteur.ForeColor = System.Drawing.Color.FromArgb(30, 80, 162) : Me.lblCompteur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblCompteur.Dock = System.Windows.Forms.DockStyle.Fill : Me.lblCompteur.Name = "lblCompteur"
        Me.pnlTitre.Controls.Add(Me.lblCompteur) : Me.pnlTitre.Controls.Add(Me.lblTitre)
        Me.dgvClients.AllowUserToAddRows = False : Me.dgvClients.AllowUserToDeleteRows = False : Me.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill : Me.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill : Me.dgvClients.ReadOnly = True : Me.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect : Me.dgvClients.MultiSelect = False : Me.dgvClients.Name = "dgvClients" : Me.dgvClients.TabIndex = 0
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!) : Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font : Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.dgvClients) : Me.Controls.Add(Me.pnlTitre) : Me.Controls.Add(Me.tsMenu)
        Me.Name = "frmClients" : Me.Text = "NETTOCAR 1.0 - GESTION DES CLIENTS" : Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 252)
        Me.tsMenu.ResumeLayout(False) : Me.tsMenu.PerformLayout() : Me.pnlTitre.ResumeLayout(False) : CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).EndInit() : Me.ResumeLayout(False) : Me.PerformLayout()
    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAjouter As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnModifier As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSupprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnActualiser As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnQuitter As System.Windows.Forms.ToolStripButton
    Friend WithEvents sepImp As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents sepSearch As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblSearch As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents pnlTitre As System.Windows.Forms.Panel
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents lblCompteur As System.Windows.Forms.Label
    Friend WithEvents dgvClients As System.Windows.Forms.DataGridView
End Class


' ============================================================
'  frmEmployes.Designer.vb
' ============================================================
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployes
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
        Me.btnAjouter = New System.Windows.Forms.ToolStripButton()
        Me.sep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnModifier = New System.Windows.Forms.ToolStripButton()
        Me.sep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSupprimer = New System.Windows.Forms.ToolStripButton()
        Me.sep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnActualiser = New System.Windows.Forms.ToolStripButton()
        Me.sep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnQuitter = New System.Windows.Forms.ToolStripButton()
        Me.sepImp = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimer = New System.Windows.Forms.ToolStripButton()
        Me.sepSearch = New System.Windows.Forms.ToolStripSeparator()
        Me.lblSearch = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.pnlTitre = New System.Windows.Forms.Panel()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblCompteur = New System.Windows.Forms.Label()
        Me.dgvEmployes = New System.Windows.Forms.DataGridView()
        Me.tsMenu.SuspendLayout() : Me.pnlTitre.SuspendLayout()
        CType(Me.dgvEmployes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.tsMenu.BackColor = System.Drawing.Color.FromArgb(30, 80, 162) : Me.tsMenu.Dock = System.Windows.Forms.DockStyle.Top : Me.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden : Me.tsMenu.ImageScalingSize = New System.Drawing.Size(32, 32) : Me.tsMenu.Name = "tsMenu" : Me.tsMenu.Size = New System.Drawing.Size(984, 48) : Me.tsMenu.Renderer = New ToolStripProfessionalRenderer(New NettoCouleur())
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAjouter, Me.sep1, Me.btnModifier, Me.sep2, Me.btnSupprimer, Me.sep3, Me.btnActualiser, Me.sep4, Me.btnQuitter, Me.sepImp, Me.btnImprimer, Me.sepSearch, Me.lblSearch, Me.txtSearch})
        Dim BF As New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAjouter.Text = "Ajouter" : Me.btnAjouter.Font = BF : Me.btnAjouter.ForeColor = System.Drawing.Color.White : Me.btnAjouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnAjouter.Name = "btnAjouter" : Me.btnAjouter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep1.Name = "sep1"
        Me.btnModifier.Text = "Modifier" : Me.btnModifier.Font = BF : Me.btnModifier.ForeColor = System.Drawing.Color.White : Me.btnModifier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnModifier.Name = "btnModifier" : Me.btnModifier.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep2.Name = "sep2"
        Me.btnSupprimer.Text = "Supprimer" : Me.btnSupprimer.Font = BF : Me.btnSupprimer.ForeColor = System.Drawing.Color.White : Me.btnSupprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnSupprimer.Name = "btnSupprimer" : Me.btnSupprimer.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep3.Name = "sep3"
        Me.btnActualiser.Text = "Actualiser" : Me.btnActualiser.Font = BF : Me.btnActualiser.ForeColor = System.Drawing.Color.White : Me.btnActualiser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnActualiser.Name = "btnActualiser" : Me.btnActualiser.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep4.Name = "sep4"
        Me.btnQuitter.Text = "Menu" : Me.btnQuitter.Font = BF : Me.btnQuitter.ForeColor = System.Drawing.Color.White : Me.btnQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnQuitter.Name = "btnQuitter" : Me.btnQuitter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.pnlTitre.Dock = System.Windows.Forms.DockStyle.Top : Me.pnlTitre.Height = 80 : Me.pnlTitre.BackColor = System.Drawing.Color.White : Me.pnlTitre.Name = "pnlTitre"
        Me.lblTitre.Text = "GESTION DES EMPLOYES" : Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold) : Me.lblTitre.ForeColor = System.Drawing.Color.FromArgb(30, 50, 100) : Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblTitre.Dock = System.Windows.Forms.DockStyle.Top : Me.lblTitre.Height = 50 : Me.lblTitre.Name = "lblTitre"
        Me.lblCompteur.Text = "Nombre d'employes : 0" : Me.lblCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold) : Me.lblCompteur.ForeColor = System.Drawing.Color.FromArgb(30, 80, 162) : Me.lblCompteur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblCompteur.Dock = System.Windows.Forms.DockStyle.Fill : Me.lblCompteur.Name = "lblCompteur"
        Me.pnlTitre.Controls.Add(Me.lblCompteur) : Me.pnlTitre.Controls.Add(Me.lblTitre)
        Me.dgvEmployes.AllowUserToAddRows = False : Me.dgvEmployes.AllowUserToDeleteRows = False : Me.dgvEmployes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill : Me.dgvEmployes.Dock = System.Windows.Forms.DockStyle.Fill : Me.dgvEmployes.ReadOnly = True : Me.dgvEmployes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect : Me.dgvEmployes.MultiSelect = False : Me.dgvEmployes.Name = "dgvEmployes" : Me.dgvEmployes.TabIndex = 0
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!) : Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font : Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.dgvEmployes) : Me.Controls.Add(Me.pnlTitre) : Me.Controls.Add(Me.tsMenu)
        Me.Name = "frmEmployes" : Me.Text = "NETTOCAR 1.0 - GESTION DES EMPLOYES" : Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 252)
        Me.tsMenu.ResumeLayout(False) : Me.tsMenu.PerformLayout() : Me.pnlTitre.ResumeLayout(False) : CType(Me.dgvEmployes, System.ComponentModel.ISupportInitialize).EndInit() : Me.ResumeLayout(False) : Me.PerformLayout()
    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAjouter As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnModifier As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSupprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnActualiser As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnQuitter As System.Windows.Forms.ToolStripButton
    Friend WithEvents sepImp As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents sepSearch As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblSearch As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents pnlTitre As System.Windows.Forms.Panel
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents lblCompteur As System.Windows.Forms.Label
    Friend WithEvents dgvEmployes As System.Windows.Forms.DataGridView
End Class


' ============================================================
'  frmServices.Designer.vb
' ============================================================
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServices
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
        Me.btnAjouter = New System.Windows.Forms.ToolStripButton()
        Me.sep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnModifier = New System.Windows.Forms.ToolStripButton()
        Me.sep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSupprimer = New System.Windows.Forms.ToolStripButton()
        Me.sep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnActualiser = New System.Windows.Forms.ToolStripButton()
        Me.sep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnQuitter = New System.Windows.Forms.ToolStripButton()
        Me.sepImp = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimer = New System.Windows.Forms.ToolStripButton()
        Me.sepSearch = New System.Windows.Forms.ToolStripSeparator()
        Me.lblSearch = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.pnlTitre = New System.Windows.Forms.Panel()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblCompteur = New System.Windows.Forms.Label()
        Me.dgvServices = New System.Windows.Forms.DataGridView()
        Me.tsMenu.SuspendLayout() : Me.pnlTitre.SuspendLayout()
        CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.tsMenu.BackColor = System.Drawing.Color.FromArgb(30, 80, 162) : Me.tsMenu.Dock = System.Windows.Forms.DockStyle.Top : Me.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden : Me.tsMenu.ImageScalingSize = New System.Drawing.Size(32, 32) : Me.tsMenu.Name = "tsMenu" : Me.tsMenu.Size = New System.Drawing.Size(984, 48) : Me.tsMenu.Renderer = New ToolStripProfessionalRenderer(New NettoCouleur())
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAjouter, Me.sep1, Me.btnModifier, Me.sep2, Me.btnSupprimer, Me.sep3, Me.btnActualiser, Me.sep4, Me.btnQuitter, Me.sepImp, Me.btnImprimer, Me.sepSearch, Me.lblSearch, Me.txtSearch})
        Dim BF As New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAjouter.Text = "Ajouter" : Me.btnAjouter.Font = BF : Me.btnAjouter.ForeColor = System.Drawing.Color.White : Me.btnAjouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnAjouter.Name = "btnAjouter" : Me.btnAjouter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep1.Name = "sep1" : Me.btnModifier.Text = "Modifier" : Me.btnModifier.Font = BF : Me.btnModifier.ForeColor = System.Drawing.Color.White : Me.btnModifier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnModifier.Name = "btnModifier" : Me.btnModifier.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep2.Name = "sep2" : Me.btnSupprimer.Text = "Supprimer" : Me.btnSupprimer.Font = BF : Me.btnSupprimer.ForeColor = System.Drawing.Color.White : Me.btnSupprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnSupprimer.Name = "btnSupprimer" : Me.btnSupprimer.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep3.Name = "sep3" : Me.btnActualiser.Text = "Actualiser" : Me.btnActualiser.Font = BF : Me.btnActualiser.ForeColor = System.Drawing.Color.White : Me.btnActualiser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnActualiser.Name = "btnActualiser" : Me.btnActualiser.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep4.Name = "sep4" : Me.btnQuitter.Text = "Menu" : Me.btnQuitter.Font = BF : Me.btnQuitter.ForeColor = System.Drawing.Color.White : Me.btnQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnQuitter.Name = "btnQuitter" : Me.btnQuitter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.pnlTitre.Dock = System.Windows.Forms.DockStyle.Top : Me.pnlTitre.Height = 80 : Me.pnlTitre.BackColor = System.Drawing.Color.White : Me.pnlTitre.Name = "pnlTitre"
        Me.lblTitre.Text = "GESTION DES SERVICES" : Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold) : Me.lblTitre.ForeColor = System.Drawing.Color.FromArgb(30, 50, 100) : Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblTitre.Dock = System.Windows.Forms.DockStyle.Top : Me.lblTitre.Height = 50 : Me.lblTitre.Name = "lblTitre"
        Me.lblCompteur.Text = "Nombre de services : 0" : Me.lblCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold) : Me.lblCompteur.ForeColor = System.Drawing.Color.FromArgb(30, 80, 162) : Me.lblCompteur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblCompteur.Dock = System.Windows.Forms.DockStyle.Fill : Me.lblCompteur.Name = "lblCompteur"
        Me.pnlTitre.Controls.Add(Me.lblCompteur) : Me.pnlTitre.Controls.Add(Me.lblTitre)
        Me.dgvServices.AllowUserToAddRows = False : Me.dgvServices.AllowUserToDeleteRows = False : Me.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill : Me.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill : Me.dgvServices.ReadOnly = True : Me.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect : Me.dgvServices.MultiSelect = False : Me.dgvServices.Name = "dgvServices" : Me.dgvServices.TabIndex = 0
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!) : Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font : Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.dgvServices) : Me.Controls.Add(Me.pnlTitre) : Me.Controls.Add(Me.tsMenu)
        Me.Name = "frmServices" : Me.Text = "NETTOCAR 1.0 - GESTION DES SERVICES" : Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 252)
        Me.tsMenu.ResumeLayout(False) : Me.tsMenu.PerformLayout() : Me.pnlTitre.ResumeLayout(False) : CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).EndInit() : Me.ResumeLayout(False) : Me.PerformLayout()
    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAjouter As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnModifier As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSupprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnActualiser As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnQuitter As System.Windows.Forms.ToolStripButton
    Friend WithEvents sepImp As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents sepSearch As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblSearch As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents pnlTitre As System.Windows.Forms.Panel
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents lblCompteur As System.Windows.Forms.Label
    Friend WithEvents dgvServices As System.Windows.Forms.DataGridView
End Class


' ============================================================
'  frmProduits.Designer.vb
' ============================================================
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduits
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
        Me.btnAjouter = New System.Windows.Forms.ToolStripButton()
        Me.sep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnModifier = New System.Windows.Forms.ToolStripButton()
        Me.sep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSupprimer = New System.Windows.Forms.ToolStripButton()
        Me.sep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnActualiser = New System.Windows.Forms.ToolStripButton()
        Me.sep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnQuitter = New System.Windows.Forms.ToolStripButton()
        Me.sepImp = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimer = New System.Windows.Forms.ToolStripButton()
        Me.sepSearch = New System.Windows.Forms.ToolStripSeparator()
        Me.lblSearch = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.pnlTitre = New System.Windows.Forms.Panel()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblCompteur = New System.Windows.Forms.Label()
        Me.dgvProduits = New System.Windows.Forms.DataGridView()
        Me.tsMenu.SuspendLayout() : Me.pnlTitre.SuspendLayout()
        CType(Me.dgvProduits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.tsMenu.BackColor = System.Drawing.Color.FromArgb(30, 80, 162) : Me.tsMenu.Dock = System.Windows.Forms.DockStyle.Top : Me.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden : Me.tsMenu.ImageScalingSize = New System.Drawing.Size(32, 32) : Me.tsMenu.Name = "tsMenu" : Me.tsMenu.Size = New System.Drawing.Size(984, 48) : Me.tsMenu.Renderer = New ToolStripProfessionalRenderer(New NettoCouleur())
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAjouter, Me.sep1, Me.btnModifier, Me.sep2, Me.btnSupprimer, Me.sep3, Me.btnActualiser, Me.sep4, Me.btnQuitter, Me.sepImp, Me.btnImprimer, Me.sepSearch, Me.lblSearch, Me.txtSearch})
        Dim BF As New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAjouter.Text = "Ajouter" : Me.btnAjouter.Font = BF : Me.btnAjouter.ForeColor = System.Drawing.Color.White : Me.btnAjouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnAjouter.Name = "btnAjouter" : Me.btnAjouter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep1.Name = "sep1" : Me.btnModifier.Text = "Modifier" : Me.btnModifier.Font = BF : Me.btnModifier.ForeColor = System.Drawing.Color.White : Me.btnModifier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnModifier.Name = "btnModifier" : Me.btnModifier.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep2.Name = "sep2" : Me.btnSupprimer.Text = "Supprimer" : Me.btnSupprimer.Font = BF : Me.btnSupprimer.ForeColor = System.Drawing.Color.White : Me.btnSupprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnSupprimer.Name = "btnSupprimer" : Me.btnSupprimer.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep3.Name = "sep3" : Me.btnActualiser.Text = "Actualiser" : Me.btnActualiser.Font = BF : Me.btnActualiser.ForeColor = System.Drawing.Color.White : Me.btnActualiser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnActualiser.Name = "btnActualiser" : Me.btnActualiser.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep4.Name = "sep4" : Me.btnQuitter.Text = "Menu" : Me.btnQuitter.Font = BF : Me.btnQuitter.ForeColor = System.Drawing.Color.White : Me.btnQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnQuitter.Name = "btnQuitter" : Me.btnQuitter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.pnlTitre.Dock = System.Windows.Forms.DockStyle.Top : Me.pnlTitre.Height = 80 : Me.pnlTitre.BackColor = System.Drawing.Color.White : Me.pnlTitre.Name = "pnlTitre"
        Me.lblTitre.Text = "GESTION DES PRODUITS" : Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold) : Me.lblTitre.ForeColor = System.Drawing.Color.FromArgb(30, 50, 100) : Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblTitre.Dock = System.Windows.Forms.DockStyle.Top : Me.lblTitre.Height = 50 : Me.lblTitre.Name = "lblTitre"
        Me.lblCompteur.Text = "Nombre de produits : 0" : Me.lblCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold) : Me.lblCompteur.ForeColor = System.Drawing.Color.FromArgb(30, 80, 162) : Me.lblCompteur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblCompteur.Dock = System.Windows.Forms.DockStyle.Fill : Me.lblCompteur.Name = "lblCompteur"
        Me.pnlTitre.Controls.Add(Me.lblCompteur) : Me.pnlTitre.Controls.Add(Me.lblTitre)
        Me.dgvProduits.AllowUserToAddRows = False : Me.dgvProduits.AllowUserToDeleteRows = False : Me.dgvProduits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill : Me.dgvProduits.Dock = System.Windows.Forms.DockStyle.Fill : Me.dgvProduits.ReadOnly = True : Me.dgvProduits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect : Me.dgvProduits.MultiSelect = False : Me.dgvProduits.Name = "dgvProduits" : Me.dgvProduits.TabIndex = 0
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!) : Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font : Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.dgvProduits) : Me.Controls.Add(Me.pnlTitre) : Me.Controls.Add(Me.tsMenu)
        Me.Name = "frmProduits" : Me.Text = "NETTOCAR 1.0 - GESTION DES PRODUITS" : Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 252)
        Me.tsMenu.ResumeLayout(False) : Me.tsMenu.PerformLayout() : Me.pnlTitre.ResumeLayout(False) : CType(Me.dgvProduits, System.ComponentModel.ISupportInitialize).EndInit() : Me.ResumeLayout(False) : Me.PerformLayout()
    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAjouter As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnModifier As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSupprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnActualiser As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnQuitter As System.Windows.Forms.ToolStripButton
    Friend WithEvents sepImp As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents sepSearch As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblSearch As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents pnlTitre As System.Windows.Forms.Panel
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents lblCompteur As System.Windows.Forms.Label
    Friend WithEvents dgvProduits As System.Windows.Forms.DataGridView
End Class


' ============================================================
'  frmFournisseurs.Designer.vb
' ============================================================
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFournisseurs
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
        Me.btnAjouter = New System.Windows.Forms.ToolStripButton()
        Me.sep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnModifier = New System.Windows.Forms.ToolStripButton()
        Me.sep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSupprimer = New System.Windows.Forms.ToolStripButton()
        Me.sep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnActualiser = New System.Windows.Forms.ToolStripButton()
        Me.sep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnQuitter = New System.Windows.Forms.ToolStripButton()
        Me.sepImp = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimer = New System.Windows.Forms.ToolStripButton()
        Me.sepSearch = New System.Windows.Forms.ToolStripSeparator()
        Me.lblSearch = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.pnlTitre = New System.Windows.Forms.Panel()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblCompteur = New System.Windows.Forms.Label()
        Me.dgvFournisseurs = New System.Windows.Forms.DataGridView()
        Me.tsMenu.SuspendLayout() : Me.pnlTitre.SuspendLayout()
        CType(Me.dgvFournisseurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.tsMenu.BackColor = System.Drawing.Color.FromArgb(30, 80, 162) : Me.tsMenu.Dock = System.Windows.Forms.DockStyle.Top : Me.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden : Me.tsMenu.ImageScalingSize = New System.Drawing.Size(32, 32) : Me.tsMenu.Name = "tsMenu" : Me.tsMenu.Size = New System.Drawing.Size(984, 48) : Me.tsMenu.Renderer = New ToolStripProfessionalRenderer(New NettoCouleur())
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAjouter, Me.sep1, Me.btnModifier, Me.sep2, Me.btnSupprimer, Me.sep3, Me.btnActualiser, Me.sep4, Me.btnQuitter, Me.sepImp, Me.btnImprimer, Me.sepSearch, Me.lblSearch, Me.txtSearch})
        Dim BF As New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAjouter.Text = "Ajouter" : Me.btnAjouter.Font = BF : Me.btnAjouter.ForeColor = System.Drawing.Color.White : Me.btnAjouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnAjouter.Name = "btnAjouter" : Me.btnAjouter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep1.Name = "sep1" : Me.btnModifier.Text = "Modifier" : Me.btnModifier.Font = BF : Me.btnModifier.ForeColor = System.Drawing.Color.White : Me.btnModifier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnModifier.Name = "btnModifier" : Me.btnModifier.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep2.Name = "sep2" : Me.btnSupprimer.Text = "Supprimer" : Me.btnSupprimer.Font = BF : Me.btnSupprimer.ForeColor = System.Drawing.Color.White : Me.btnSupprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnSupprimer.Name = "btnSupprimer" : Me.btnSupprimer.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep3.Name = "sep3" : Me.btnActualiser.Text = "Actualiser" : Me.btnActualiser.Font = BF : Me.btnActualiser.ForeColor = System.Drawing.Color.White : Me.btnActualiser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnActualiser.Name = "btnActualiser" : Me.btnActualiser.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.sep4.Name = "sep4" : Me.btnQuitter.Text = "Menu" : Me.btnQuitter.Font = BF : Me.btnQuitter.ForeColor = System.Drawing.Color.White : Me.btnQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text : Me.btnQuitter.Name = "btnQuitter" : Me.btnQuitter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.pnlTitre.Dock = System.Windows.Forms.DockStyle.Top : Me.pnlTitre.Height = 80 : Me.pnlTitre.BackColor = System.Drawing.Color.White : Me.pnlTitre.Name = "pnlTitre"
        Me.lblTitre.Text = "GESTION DES FOURNISSEURS" : Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold) : Me.lblTitre.ForeColor = System.Drawing.Color.FromArgb(30, 50, 100) : Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblTitre.Dock = System.Windows.Forms.DockStyle.Top : Me.lblTitre.Height = 50 : Me.lblTitre.Name = "lblTitre"
        Me.lblCompteur.Text = "Nombre de fournisseurs : 0" : Me.lblCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold) : Me.lblCompteur.ForeColor = System.Drawing.Color.FromArgb(30, 80, 162) : Me.lblCompteur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblCompteur.Dock = System.Windows.Forms.DockStyle.Fill : Me.lblCompteur.Name = "lblCompteur"
        Me.pnlTitre.Controls.Add(Me.lblCompteur) : Me.pnlTitre.Controls.Add(Me.lblTitre)
        Me.dgvFournisseurs.AllowUserToAddRows = False : Me.dgvFournisseurs.AllowUserToDeleteRows = False : Me.dgvFournisseurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill : Me.dgvFournisseurs.Dock = System.Windows.Forms.DockStyle.Fill : Me.dgvFournisseurs.ReadOnly = True : Me.dgvFournisseurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect : Me.dgvFournisseurs.MultiSelect = False : Me.dgvFournisseurs.Name = "dgvFournisseurs" : Me.dgvFournisseurs.TabIndex = 0
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!) : Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font : Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.dgvFournisseurs) : Me.Controls.Add(Me.pnlTitre) : Me.Controls.Add(Me.tsMenu)
        Me.Name = "frmFournisseurs" : Me.Text = "NETTOCAR 1.0 - GESTION DES FOURNISSEURS" : Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 252)
        Me.tsMenu.ResumeLayout(False) : Me.tsMenu.PerformLayout() : Me.pnlTitre.ResumeLayout(False) : CType(Me.dgvFournisseurs, System.ComponentModel.ISupportInitialize).EndInit() : Me.ResumeLayout(False) : Me.PerformLayout()
    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAjouter As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnModifier As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSupprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnActualiser As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnQuitter As System.Windows.Forms.ToolStripButton
    Friend WithEvents sepImp As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents sepSearch As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblSearch As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents pnlTitre As System.Windows.Forms.Panel
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents lblCompteur As System.Windows.Forms.Label
    Friend WithEvents dgvFournisseurs As System.Windows.Forms.DataGridView
End Class
