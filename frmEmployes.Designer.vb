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
        Me.sep5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimer = New System.Windows.Forms.ToolStripButton()
        Me.sep6 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblSearch = New System.Windows.Forms.ToolStripButton()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.pnlTitre = New System.Windows.Forms.Panel()
        Me.lblCompteur = New System.Windows.Forms.Label()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.dgvEmployes = New System.Windows.Forms.DataGridView()
        Me.tsMenu.SuspendLayout()
        Me.pnlTitre.SuspendLayout()
        CType(Me.dgvEmployes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAjouter, Me.sep1, Me.btnModifier, Me.sep2, Me.btnSupprimer, Me.sep3, Me.btnActualiser, Me.sep4, Me.btnQuitter, Me.sep5, Me.btnImprimer, Me.sep6, Me.lblSearch, Me.txtSearch})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(984, 27)
        Me.tsMenu.TabIndex = 2
        '
        'btnAjouter
        '
        Me.btnAjouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnAjouter.Size = New System.Drawing.Size(93, 24)
        Me.btnAjouter.Text = "Ajouter"
        '
        'sep1
        '
        Me.sep1.Name = "sep1"
        Me.sep1.Size = New System.Drawing.Size(6, 27)
        '
        'btnModifier
        '
        Me.btnModifier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnModifier.ForeColor = System.Drawing.Color.White
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnModifier.Size = New System.Drawing.Size(101, 24)
        Me.btnModifier.Text = "Modifier"
        '
        'sep2
        '
        Me.sep2.Name = "sep2"
        Me.sep2.Size = New System.Drawing.Size(6, 27)
        '
        'btnSupprimer
        '
        Me.btnSupprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSupprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSupprimer.ForeColor = System.Drawing.Color.White
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnSupprimer.Size = New System.Drawing.Size(119, 24)
        Me.btnSupprimer.Text = "Supprimer"
        '
        'sep3
        '
        Me.sep3.Name = "sep3"
        Me.sep3.Size = New System.Drawing.Size(6, 27)
        '
        'btnActualiser
        '
        Me.btnActualiser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnActualiser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnActualiser.ForeColor = System.Drawing.Color.White
        Me.btnActualiser.Name = "btnActualiser"
        Me.btnActualiser.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnActualiser.Size = New System.Drawing.Size(118, 24)
        Me.btnActualiser.Text = "Actualiser"
        '
        'sep4
        '
        Me.sep4.Name = "sep4"
        Me.sep4.Size = New System.Drawing.Size(6, 27)
        '
        'btnQuitter
        '
        Me.btnQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnQuitter.ForeColor = System.Drawing.Color.White
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnQuitter.Size = New System.Drawing.Size(78, 24)
        Me.btnQuitter.Text = "Menu"
        '
        'sep5
        '
        Me.sep5.Name = "sep5"
        Me.sep5.Size = New System.Drawing.Size(6, 27)
        '
        'btnImprimer
        '
        Me.btnImprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnImprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnImprimer.ForeColor = System.Drawing.Color.White
        Me.btnImprimer.Name = "btnImprimer"
        Me.btnImprimer.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnImprimer.Size = New System.Drawing.Size(107, 24)
        Me.btnImprimer.Text = "Imprimer"
        '
        'sep6
        '
        Me.sep6.Name = "sep6"
        Me.sep6.Size = New System.Drawing.Size(6, 27)
        '
        'lblSearch
        '
        Me.lblSearch.Enabled = False
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearch.ForeColor = System.Drawing.Color.White
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(110, 24)
        Me.lblSearch.Text = "Rechercher"
        Me.lblSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 27)
        Me.txtSearch.ToolTipText = "Tapez pour rechercher..."
        '
        'pnlTitre
        '
        Me.pnlTitre.BackColor = System.Drawing.Color.White
        Me.pnlTitre.Controls.Add(Me.lblCompteur)
        Me.pnlTitre.Controls.Add(Me.lblTitre)
        Me.pnlTitre.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitre.Location = New System.Drawing.Point(0, 27)
        Me.pnlTitre.Name = "pnlTitre"
        Me.pnlTitre.Size = New System.Drawing.Size(984, 80)
        Me.pnlTitre.TabIndex = 1
        '
        'lblCompteur
        '
        Me.lblCompteur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCompteur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblCompteur.Location = New System.Drawing.Point(0, 50)
        Me.lblCompteur.Name = "lblCompteur"
        Me.lblCompteur.Size = New System.Drawing.Size(984, 30)
        Me.lblCompteur.TabIndex = 0
        Me.lblCompteur.Text = "Nombre d'employes : 0"
        Me.lblCompteur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitre
        '
        Me.lblTitre.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblTitre.Location = New System.Drawing.Point(0, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(984, 50)
        Me.lblTitre.TabIndex = 1
        Me.lblTitre.Text = "GESTION DES EMPLOYES"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvEmployes
        '
        Me.dgvEmployes.AllowUserToAddRows = False
        Me.dgvEmployes.AllowUserToDeleteRows = False
        Me.dgvEmployes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmployes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmployes.Location = New System.Drawing.Point(0, 107)
        Me.dgvEmployes.MultiSelect = False
        Me.dgvEmployes.Name = "dgvEmployes"
        Me.dgvEmployes.ReadOnly = True
        Me.dgvEmployes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployes.Size = New System.Drawing.Size(984, 454)
        Me.dgvEmployes.TabIndex = 0
        '
        'frmEmployes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.dgvEmployes)
        Me.Controls.Add(Me.pnlTitre)
        Me.Controls.Add(Me.tsMenu)
        Me.Name = "frmEmployes"
        Me.Text = "NETTOCAR 1.0 - GESTION DES EMPLOYES"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.pnlTitre.ResumeLayout(False)
        CType(Me.dgvEmployes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents sep5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents pnlTitre As System.Windows.Forms.Panel
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents lblCompteur As System.Windows.Forms.Label
    Friend WithEvents dgvEmployes As System.Windows.Forms.DataGridView

End Class
