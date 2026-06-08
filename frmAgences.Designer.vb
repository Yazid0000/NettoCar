<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgences
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
        Me.lblSearch = New System.Windows.Forms.ToolStripButton()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.pnlTitre = New System.Windows.Forms.Panel()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblCompteur = New System.Windows.Forms.Label()
        Me.dgvAgences = New System.Windows.Forms.DataGridView()
        Me.tsMenu.SuspendLayout()
        Me.pnlTitre.SuspendLayout()
        CType(Me.dgvAgences, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '=== ToolStrip ===
        Me.tsMenu.BackColor = System.Drawing.Color.FromArgb(30, 30, 30)
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(984, 62)
        Me.tsMenu.Renderer = New ToolStripProfessionalRenderer(New NettoCouleur())
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {
            Me.btnAjouter, Me.sep1, Me.btnModifier, Me.sep2,
            Me.btnSupprimer, Me.sep3, Me.btnActualiser, Me.sep4, Me.btnQuitter, Me.sepImp, Me.btnImprimer, Me.sepSearch, Me.lblSearch, Me.txtSearch})

        ' Ajouter
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)

        Me.sep1.Name = "sep1"

        ' Modifier
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnModifier.ForeColor = System.Drawing.Color.White
        Me.btnModifier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)

        Me.sep2.Name = "sep2"

        ' Supprimer
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSupprimer.ForeColor = System.Drawing.Color.White
        Me.btnSupprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)

        Me.sep3.Name = "sep3"

        ' Actualiser
        Me.btnActualiser.Text = "Actualiser"
        Me.btnActualiser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnActualiser.ForeColor = System.Drawing.Color.White
        Me.btnActualiser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnActualiser.Name = "btnActualiser"
        Me.btnActualiser.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)

        Me.sep4.Name = "sep4"

        ' Quitter
        Me.btnQuitter.Text = "Menu"
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnQuitter.ForeColor = System.Drawing.Color.White
        Me.btnQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)


        Me.sepImp.Name = "sepImp"

        Me.btnImprimer.Text = "Imprimer"
        Me.btnImprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnImprimer.ForeColor = System.Drawing.Color.White
        Me.btnImprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnImprimer.Name = "btnImprimer"
        Me.btnImprimer.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)

        '── Contrôles recherche ──
        Me.sepSearch.Name = "sepSearch"

        Me.lblSearch.Text = "Rechercher :"
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearch.ForeColor = System.Drawing.Color.White
        Me.lblSearch.Name = "lblSearch"

        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 27)
        Me.txtSearch.ToolTipText = "Tapez pour rechercher..."
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        '=== pnlTitre ===
        Me.pnlTitre.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitre.Height = 80
        Me.pnlTitre.BackColor = System.Drawing.Color.White
        Me.pnlTitre.Name = "pnlTitre"
        Me.pnlTitre.Controls.Add(Me.lblCompteur)
        Me.pnlTitre.Controls.Add(Me.lblTitre)

        Me.lblTitre.Text = "GESTION DES AGENCES"
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitre.ForeColor = System.Drawing.Color.FromArgb(30, 50, 100)
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTitre.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitre.Height = 50
        Me.lblTitre.Name = "lblTitre"

        Me.lblCompteur.Text = "Nombre d'agences : 0"
        Me.lblCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCompteur.ForeColor = System.Drawing.Color.FromArgb(30, 80, 162)
        Me.lblCompteur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCompteur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCompteur.Name = "lblCompteur"

        '=== dgvAgences ===
        Me.dgvAgences.AllowUserToAddRows = False
        Me.dgvAgences.AllowUserToDeleteRows = False
        Me.dgvAgences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAgences.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAgences.ReadOnly = True
        Me.dgvAgences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAgences.MultiSelect = False
        Me.dgvAgences.Name = "dgvAgences"
        Me.dgvAgences.TabIndex = 0

        '=== frmAgences ===
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.dgvAgences)
        Me.Controls.Add(Me.pnlTitre)
        Me.Controls.Add(Me.tsMenu)
        Me.Name = "frmAgences"
        Me.Text = "NETTOCAR 1.0 - GESTION DES AGENCES"
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 252)

        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.pnlTitre.ResumeLayout(False)
        CType(Me.dgvAgences, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents sepImp As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents sepSearch As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents pnlTitre As System.Windows.Forms.Panel
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents lblCompteur As System.Windows.Forms.Label
    Friend WithEvents dgvAgences As System.Windows.Forms.DataGridView

End Class

