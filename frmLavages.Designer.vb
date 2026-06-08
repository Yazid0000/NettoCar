<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLavages
    Inherits System.Windows.Forms.Form

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

    Private Sub InitializeComponent()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabNouveau = New System.Windows.Forms.TabPage()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.cboClient = New System.Windows.Forms.ComboBox()
        Me.lblService = New System.Windows.Forms.Label()
        Me.cboService = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblHeure = New System.Windows.Forms.Label()
        Me.txtHeureDeb = New System.Windows.Forms.TextBox()
        Me.lblMontant = New System.Windows.Forms.Label()
        Me.txtMontant = New System.Windows.Forms.TextBox()
        Me.lblObservations = New System.Windows.Forms.Label()
        Me.txtObservations = New System.Windows.Forms.TextBox()
        Me.btnCommencer = New System.Windows.Forms.Button()
        Me.tabEnCours = New System.Windows.Forms.TabPage()
        Me.dgvLavages = New System.Windows.Forms.DataGridView()
        Me.btnCloture = New System.Windows.Forms.Button()
        Me.btnActualiser = New System.Windows.Forms.Button()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.tabNouveau.SuspendLayout()
        Me.tabEnCours.SuspendLayout()
        CType(Me.dgvLavages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()

        ' pnlTop
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(10, 20, 55)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Height = 55
        Me.pnlTop.Name = "pnlTop"

        ' lblTitre
        Me.lblTitre.Text = "  Gestion des Lavages"
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitre.ForeColor = System.Drawing.Color.White
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitre.Name = "lblTitre"
        Me.pnlTop.Controls.Add(Me.lblTitre)

        ' tabControl
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.TabPages.Add(Me.tabNouveau)
        Me.tabControl.TabPages.Add(Me.tabEnCours)

        ' ── TAB NOUVEAU ──
        Me.tabNouveau.Text = "  Nouveau Lavage  "
        Me.tabNouveau.BackColor = System.Drawing.Color.FromArgb(28, 33, 45)
        Me.tabNouveau.Name = "tabNouveau"

        Me.lblClient.Text = "Client :"
        Me.lblClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblClient.ForeColor = System.Drawing.Color.White
        Me.lblClient.Location = New System.Drawing.Point(40, 40)
        Me.lblClient.Size = New System.Drawing.Size(120, 24)
        Me.lblClient.Name = "lblClient"

        Me.cboClient.Location = New System.Drawing.Point(170, 38)
        Me.cboClient.Size = New System.Drawing.Size(280, 24)
        Me.cboClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboClient.Name = "cboClient"

        Me.lblService.Text = "Service :"
        Me.lblService.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblService.ForeColor = System.Drawing.Color.White
        Me.lblService.Location = New System.Drawing.Point(40, 85)
        Me.lblService.Size = New System.Drawing.Size(120, 24)
        Me.lblService.Name = "lblService"

        Me.cboService.Location = New System.Drawing.Point(170, 83)
        Me.cboService.Size = New System.Drawing.Size(280, 24)
        Me.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboService.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboService.Name = "cboService"

        Me.lblDate.Text = "Date :"
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(40, 130)
        Me.lblDate.Size = New System.Drawing.Size(120, 24)
        Me.lblDate.Name = "lblDate"

        Me.dtpDate.Location = New System.Drawing.Point(170, 128)
        Me.dtpDate.Size = New System.Drawing.Size(280, 24)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDate.Name = "dtpDate"

        Me.lblHeure.Text = "Heure début :"
        Me.lblHeure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeure.ForeColor = System.Drawing.Color.White
        Me.lblHeure.Location = New System.Drawing.Point(40, 175)
        Me.lblHeure.Size = New System.Drawing.Size(120, 24)
        Me.lblHeure.Name = "lblHeure"

        Me.txtHeureDeb.Location = New System.Drawing.Point(170, 173)
        Me.txtHeureDeb.Size = New System.Drawing.Size(100, 24)
        Me.txtHeureDeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtHeureDeb.Name = "txtHeureDeb"

        Me.lblMontant.Text = "Montant (DH) :"
        Me.lblMontant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMontant.ForeColor = System.Drawing.Color.White
        Me.lblMontant.Location = New System.Drawing.Point(40, 220)
        Me.lblMontant.Size = New System.Drawing.Size(120, 24)
        Me.lblMontant.Name = "lblMontant"

        Me.txtMontant.Location = New System.Drawing.Point(170, 218)
        Me.txtMontant.Size = New System.Drawing.Size(100, 24)
        Me.txtMontant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtMontant.ReadOnly = True
        Me.txtMontant.BackColor = System.Drawing.Color.FromArgb(40, 46, 62)
        Me.txtMontant.ForeColor = System.Drawing.Color.White
        Me.txtMontant.Name = "txtMontant"

        Me.lblObservations.Text = "Observations :"
        Me.lblObservations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblObservations.ForeColor = System.Drawing.Color.White
        Me.lblObservations.Location = New System.Drawing.Point(40, 265)
        Me.lblObservations.Size = New System.Drawing.Size(120, 24)
        Me.lblObservations.Name = "lblObservations"

        Me.txtObservations.Location = New System.Drawing.Point(170, 263)
        Me.txtObservations.Size = New System.Drawing.Size(280, 60)
        Me.txtObservations.Multiline = True
        Me.txtObservations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtObservations.Name = "txtObservations"

        Me.btnCommencer.Text = "Démarrer le lavage"
        Me.btnCommencer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCommencer.BackColor = System.Drawing.Color.FromArgb(25, 70, 155)
        Me.btnCommencer.ForeColor = System.Drawing.Color.White
        Me.btnCommencer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommencer.Location = New System.Drawing.Point(170, 350)
        Me.btnCommencer.Size = New System.Drawing.Size(180, 38)
        Me.btnCommencer.Name = "btnCommencer"

        Me.tabNouveau.Controls.Add(Me.lblClient)
        Me.tabNouveau.Controls.Add(Me.cboClient)
        Me.tabNouveau.Controls.Add(Me.lblService)
        Me.tabNouveau.Controls.Add(Me.cboService)
        Me.tabNouveau.Controls.Add(Me.lblDate)
        Me.tabNouveau.Controls.Add(Me.dtpDate)
        Me.tabNouveau.Controls.Add(Me.lblHeure)
        Me.tabNouveau.Controls.Add(Me.txtHeureDeb)
        Me.tabNouveau.Controls.Add(Me.lblMontant)
        Me.tabNouveau.Controls.Add(Me.txtMontant)
        Me.tabNouveau.Controls.Add(Me.lblObservations)
        Me.tabNouveau.Controls.Add(Me.txtObservations)
        Me.tabNouveau.Controls.Add(Me.btnCommencer)

        ' ── TAB EN COURS ──
        Me.tabEnCours.Text = "  Lavages en cours  "
        Me.tabEnCours.BackColor = System.Drawing.Color.FromArgb(28, 33, 45)
        Me.tabEnCours.Name = "tabEnCours"

        Me.dgvLavages.AllowUserToAddRows = False
        Me.dgvLavages.AllowUserToDeleteRows = False
        Me.dgvLavages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLavages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLavages.ReadOnly = True
        Me.dgvLavages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLavages.MultiSelect = False
        Me.dgvLavages.Name = "dgvLavages"
        Me.dgvLavages.BackgroundColor = System.Drawing.Color.FromArgb(33, 38, 52)
        Me.dgvLavages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLavages.RowTemplate.Height = 30
        Me.dgvLavages.EnableHeadersVisualStyles = False
        Me.dgvLavages.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 22, 35)
        Me.dgvLavages.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(140, 165, 215)
        Me.dgvLavages.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvLavages.ColumnHeadersHeight = 32
        Me.dgvLavages.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(33, 38, 52)
        Me.dgvLavages.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(195, 205, 225)
        Me.dgvLavages.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 46, 62)
        Me.dgvLavages.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(25, 70, 155)
        Me.dgvLavages.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvLavages.GridColor = System.Drawing.Color.FromArgb(48, 55, 72)

        Me.btnCloture.Text = "Clôturer ce lavage"
        Me.btnCloture.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCloture.BackColor = System.Drawing.Color.FromArgb(0, 110, 100)
        Me.btnCloture.ForeColor = System.Drawing.Color.White
        Me.btnCloture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloture.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCloture.Height = 38
        Me.btnCloture.Name = "btnCloture"

        Me.btnActualiser.Text = "Actualiser"
        Me.btnActualiser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnActualiser.BackColor = System.Drawing.Color.FromArgb(25, 70, 155)
        Me.btnActualiser.ForeColor = System.Drawing.Color.White
        Me.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualiser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnActualiser.Height = 35
        Me.btnActualiser.Name = "btnActualiser"

        Me.tabEnCours.Controls.Add(Me.dgvLavages)
        Me.tabEnCours.Controls.Add(Me.btnCloture)
        Me.tabEnCours.Controls.Add(Me.btnActualiser)

        ' pnlBottom
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(18, 22, 30)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Height = 50
        Me.pnlBottom.Name = "pnlBottom"

        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnFermer.BackColor = System.Drawing.Color.FromArgb(60, 20, 20)
        Me.btnFermer.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100)
        Me.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFermer.Location = New System.Drawing.Point(15, 10)
        Me.btnFermer.Size = New System.Drawing.Size(100, 30)
        Me.btnFermer.Name = "btnFermer"
        Me.pnlBottom.Controls.Add(Me.btnFermer)

        ' Form
        Me.ClientSize = New System.Drawing.Size(750, 580)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBottom)
        Me.Name = "frmLavages"
        Me.Text = "Gestion des Lavages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = System.Drawing.Color.FromArgb(28, 33, 45)

        Me.pnlTop.ResumeLayout(False)
        Me.tabControl.ResumeLayout(False)
        Me.tabNouveau.ResumeLayout(False)
        Me.tabEnCours.ResumeLayout(False)
        CType(Me.dgvLavages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabNouveau As System.Windows.Forms.TabPage
    Friend WithEvents lblClient As System.Windows.Forms.Label
    Friend WithEvents cboClient As System.Windows.Forms.ComboBox
    Friend WithEvents lblService As System.Windows.Forms.Label
    Friend WithEvents cboService As System.Windows.Forms.ComboBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHeure As System.Windows.Forms.Label
    Friend WithEvents txtHeureDeb As System.Windows.Forms.TextBox
    Friend WithEvents lblMontant As System.Windows.Forms.Label
    Friend WithEvents txtMontant As System.Windows.Forms.TextBox
    Friend WithEvents lblObservations As System.Windows.Forms.Label
    Friend WithEvents txtObservations As System.Windows.Forms.TextBox
    Friend WithEvents btnCommencer As System.Windows.Forms.Button
    Friend WithEvents tabEnCours As System.Windows.Forms.TabPage
    Friend WithEvents dgvLavages As System.Windows.Forms.DataGridView
    Friend WithEvents btnCloture As System.Windows.Forms.Button
    Friend WithEvents btnActualiser As System.Windows.Forms.Button
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnFermer As System.Windows.Forms.Button

End Class