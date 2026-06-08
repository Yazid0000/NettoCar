<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJournal
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
        Me.pnlFiltres = New System.Windows.Forms.Panel()
        Me.lblDu = New System.Windows.Forms.Label()
        Me.dtpDu = New System.Windows.Forms.DateTimePicker()
        Me.lblAu = New System.Windows.Forms.Label()
        Me.dtpAu = New System.Windows.Forms.DateTimePicker()
        Me.lblType = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.btnFiltrer = New System.Windows.Forms.Button()
        Me.btnTout = New System.Windows.Forms.Button()
        Me.lblCompteur = New System.Windows.Forms.Label()
        Me.dgvJournal = New System.Windows.Forms.DataGridView()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnImprimer = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        Me.pnlFiltres.SuspendLayout()
        CType(Me.dgvJournal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()

        ' pnlTop
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(10, 20, 55)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Height = 60
        Me.pnlTop.Name = "pnlTop"

        ' lblTitre
        Me.lblTitre.Text = "  Journal de Prévention des Pertes"
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitre.ForeColor = System.Drawing.Color.White
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitre.Name = "lblTitre"
        Me.pnlTop.Controls.Add(Me.lblTitre)

        ' pnlFiltres
        Me.pnlFiltres.BackColor = System.Drawing.Color.FromArgb(28, 33, 45)
        Me.pnlFiltres.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltres.Height = 60
        Me.pnlFiltres.Name = "pnlFiltres"
        Me.pnlFiltres.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)

        ' lblDu
        Me.lblDu.Text = "Du :"
        Me.lblDu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDu.ForeColor = System.Drawing.Color.White
        Me.lblDu.Location = New System.Drawing.Point(10, 18)
        Me.lblDu.Size = New System.Drawing.Size(30, 24)
        Me.lblDu.Name = "lblDu"

        ' dtpDu
        Me.dtpDu.Location = New System.Drawing.Point(45, 16)
        Me.dtpDu.Size = New System.Drawing.Size(130, 24)
        Me.dtpDu.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDu.Name = "dtpDu"

        ' lblAu
        Me.lblAu.Text = "Au :"
        Me.lblAu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAu.ForeColor = System.Drawing.Color.White
        Me.lblAu.Location = New System.Drawing.Point(185, 18)
        Me.lblAu.Size = New System.Drawing.Size(30, 24)
        Me.lblAu.Name = "lblAu"

        ' dtpAu
        Me.dtpAu.Location = New System.Drawing.Point(218, 16)
        Me.dtpAu.Size = New System.Drawing.Size(130, 24)
        Me.dtpAu.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpAu.Name = "dtpAu"

        ' lblType
        Me.lblType.Text = "Type :"
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblType.ForeColor = System.Drawing.Color.White
        Me.lblType.Location = New System.Drawing.Point(360, 18)
        Me.lblType.Size = New System.Drawing.Size(45, 24)
        Me.lblType.Name = "lblType"

        ' cboType
        Me.cboType.Location = New System.Drawing.Point(408, 16)
        Me.cboType.Size = New System.Drawing.Size(160, 24)
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboType.Name = "cboType"

        ' btnFiltrer
        Me.btnFiltrer.Text = "Filtrer"
        Me.btnFiltrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnFiltrer.BackColor = System.Drawing.Color.FromArgb(25, 70, 155)
        Me.btnFiltrer.ForeColor = System.Drawing.Color.White
        Me.btnFiltrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrer.Location = New System.Drawing.Point(580, 14)
        Me.btnFiltrer.Size = New System.Drawing.Size(80, 28)
        Me.btnFiltrer.Name = "btnFiltrer"

        ' btnTout
        Me.btnTout.Text = "Tout afficher"
        Me.btnTout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnTout.BackColor = System.Drawing.Color.FromArgb(50, 55, 70)
        Me.btnTout.ForeColor = System.Drawing.Color.White
        Me.btnTout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTout.Location = New System.Drawing.Point(668, 14)
        Me.btnTout.Size = New System.Drawing.Size(100, 28)
        Me.btnTout.Name = "btnTout"

        ' lblCompteur
        Me.lblCompteur.Text = ""
        Me.lblCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblCompteur.ForeColor = System.Drawing.Color.FromArgb(150, 170, 220)
        Me.lblCompteur.Location = New System.Drawing.Point(780, 18)
        Me.lblCompteur.Size = New System.Drawing.Size(200, 24)
        Me.lblCompteur.Name = "lblCompteur"

        Me.pnlFiltres.Controls.Add(Me.lblDu)
        Me.pnlFiltres.Controls.Add(Me.dtpDu)
        Me.pnlFiltres.Controls.Add(Me.lblAu)
        Me.pnlFiltres.Controls.Add(Me.dtpAu)
        Me.pnlFiltres.Controls.Add(Me.lblType)
        Me.pnlFiltres.Controls.Add(Me.cboType)
        Me.pnlFiltres.Controls.Add(Me.btnFiltrer)
        Me.pnlFiltres.Controls.Add(Me.btnTout)
        Me.pnlFiltres.Controls.Add(Me.lblCompteur)

        ' dgvJournal
        Me.dgvJournal.AllowUserToAddRows = False
        Me.dgvJournal.AllowUserToDeleteRows = False
        Me.dgvJournal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.dgvJournal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvJournal.ReadOnly = True
        Me.dgvJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvJournal.MultiSelect = False
        Me.dgvJournal.Name = "dgvJournal"
        Me.dgvJournal.BackgroundColor = System.Drawing.Color.FromArgb(33, 38, 52)
        Me.dgvJournal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvJournal.RowTemplate.Height = 30
        Me.dgvJournal.EnableHeadersVisualStyles = False
        Me.dgvJournal.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 22, 35)
        Me.dgvJournal.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(140, 165, 215)
        Me.dgvJournal.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvJournal.ColumnHeadersHeight = 32
        Me.dgvJournal.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(33, 38, 52)
        Me.dgvJournal.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(195, 205, 225)
        Me.dgvJournal.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 46, 62)
        Me.dgvJournal.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(25, 70, 155)
        Me.dgvJournal.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvJournal.GridColor = System.Drawing.Color.FromArgb(48, 55, 72)

        ' pnlBottom
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(18, 22, 30)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Height = 50
        Me.pnlBottom.Name = "pnlBottom"

        ' btnImprimer
        Me.btnImprimer.Text = "Imprimer"
        Me.btnImprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnImprimer.BackColor = System.Drawing.Color.FromArgb(0, 110, 100)
        Me.btnImprimer.ForeColor = System.Drawing.Color.White
        Me.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimer.Location = New System.Drawing.Point(15, 10)
        Me.btnImprimer.Size = New System.Drawing.Size(100, 30)
        Me.btnImprimer.Name = "btnImprimer"

        ' btnQuitter
        Me.btnQuitter.Text = "Fermer"
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnQuitter.BackColor = System.Drawing.Color.FromArgb(60, 20, 20)
        Me.btnQuitter.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100)
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitter.Location = New System.Drawing.Point(125, 10)
        Me.btnQuitter.Size = New System.Drawing.Size(100, 30)
        Me.btnQuitter.Name = "btnQuitter"

        Me.pnlBottom.Controls.Add(Me.btnImprimer)
        Me.pnlBottom.Controls.Add(Me.btnQuitter)

        ' Form
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.dgvJournal)
        Me.Controls.Add(Me.pnlFiltres)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBottom)
        Me.Name = "frmJournal"
        Me.Text = "Journal de Prévention des Pertes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = System.Drawing.Color.FromArgb(28, 33, 45)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        Me.pnlTop.ResumeLayout(False)
        Me.pnlFiltres.ResumeLayout(False)
        CType(Me.dgvJournal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents pnlFiltres As System.Windows.Forms.Panel
    Friend WithEvents lblDu As System.Windows.Forms.Label
    Friend WithEvents dtpDu As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAu As System.Windows.Forms.Label
    Friend WithEvents dtpAu As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents btnFiltrer As System.Windows.Forms.Button
    Friend WithEvents btnTout As System.Windows.Forms.Button
    Friend WithEvents lblCompteur As System.Windows.Forms.Label
    Friend WithEvents dgvJournal As System.Windows.Forms.DataGridView
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnImprimer As System.Windows.Forms.Button
    Friend WithEvents btnQuitter As System.Windows.Forms.Button

End Class