<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStock
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
        Me.tabEntree = New System.Windows.Forms.TabPage()
        Me.lblProduitE = New System.Windows.Forms.Label()
        Me.cboProduitE = New System.Windows.Forms.ComboBox()
        Me.lblFournisseur = New System.Windows.Forms.Label()
        Me.cboFournisseur = New System.Windows.Forms.ComboBox()
        Me.lblQuantiteE = New System.Windows.Forms.Label()
        Me.txtQuantiteE = New System.Windows.Forms.TextBox()
        Me.lblMotifE = New System.Windows.Forms.Label()
        Me.txtMotifE = New System.Windows.Forms.TextBox()
        Me.lblStockActuelE = New System.Windows.Forms.Label()
        Me.txtStockActuelE = New System.Windows.Forms.TextBox()
        Me.btnEntree = New System.Windows.Forms.Button()
        Me.tabSortie = New System.Windows.Forms.TabPage()
        Me.lblProduitS = New System.Windows.Forms.Label()
        Me.cboProduitS = New System.Windows.Forms.ComboBox()
        Me.lblQuantiteS = New System.Windows.Forms.Label()
        Me.txtQuantiteS = New System.Windows.Forms.TextBox()
        Me.lblMotifS = New System.Windows.Forms.Label()
        Me.txtMotifS = New System.Windows.Forms.TextBox()
        Me.lblStockActuelS = New System.Windows.Forms.Label()
        Me.txtStockActuelS = New System.Windows.Forms.TextBox()
        Me.btnSortie = New System.Windows.Forms.Button()
        Me.tabHistorique = New System.Windows.Forms.TabPage()
        Me.dgvHistorique = New System.Windows.Forms.DataGridView()
        Me.btnActualiser = New System.Windows.Forms.Button()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.tabEntree.SuspendLayout()
        Me.tabSortie.SuspendLayout()
        Me.tabHistorique.SuspendLayout()
        CType(Me.dgvHistorique, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()

        ' pnlTop
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(10, 20, 55)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Height = 55
        Me.pnlTop.Name = "pnlTop"

        ' lblTitre
        Me.lblTitre.Text = "  Gestion des Mouvements de Stock"
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
        Me.tabControl.TabPages.Add(Me.tabEntree)
        Me.tabControl.TabPages.Add(Me.tabSortie)
        Me.tabControl.TabPages.Add(Me.tabHistorique)

        ' ── TAB ENTREE ──
        Me.tabEntree.Text = "  Entrée Stock  "
        Me.tabEntree.BackColor = System.Drawing.Color.FromArgb(28, 33, 45)
        Me.tabEntree.Name = "tabEntree"

        ' lblProduitE
        Me.lblProduitE.Text = "Produit :"
        Me.lblProduitE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblProduitE.ForeColor = System.Drawing.Color.White
        Me.lblProduitE.Location = New System.Drawing.Point(40, 40)
        Me.lblProduitE.Size = New System.Drawing.Size(120, 24)
        Me.lblProduitE.Name = "lblProduitE"

        ' cboProduitE
        Me.cboProduitE.Location = New System.Drawing.Point(170, 38)
        Me.cboProduitE.Size = New System.Drawing.Size(280, 24)
        Me.cboProduitE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduitE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboProduitE.Name = "cboProduitE"

        ' lblFournisseur
        Me.lblFournisseur.Text = "Fournisseur :"
        Me.lblFournisseur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFournisseur.ForeColor = System.Drawing.Color.White
        Me.lblFournisseur.Location = New System.Drawing.Point(40, 85)
        Me.lblFournisseur.Size = New System.Drawing.Size(120, 24)
        Me.lblFournisseur.Name = "lblFournisseur"

        ' cboFournisseur
        Me.cboFournisseur.Location = New System.Drawing.Point(170, 83)
        Me.cboFournisseur.Size = New System.Drawing.Size(280, 24)
        Me.cboFournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFournisseur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboFournisseur.Name = "cboFournisseur"

        ' lblQuantiteE
        Me.lblQuantiteE.Text = "Quantité reçue :"
        Me.lblQuantiteE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuantiteE.ForeColor = System.Drawing.Color.White
        Me.lblQuantiteE.Location = New System.Drawing.Point(40, 130)
        Me.lblQuantiteE.Size = New System.Drawing.Size(120, 24)
        Me.lblQuantiteE.Name = "lblQuantiteE"

        ' txtQuantiteE
        Me.txtQuantiteE.Location = New System.Drawing.Point(170, 128)
        Me.txtQuantiteE.Size = New System.Drawing.Size(100, 24)
        Me.txtQuantiteE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtQuantiteE.Name = "txtQuantiteE"

        ' lblStockActuelE
        Me.lblStockActuelE.Text = "Stock actuel :"
        Me.lblStockActuelE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStockActuelE.ForeColor = System.Drawing.Color.FromArgb(100, 220, 150)
        Me.lblStockActuelE.Location = New System.Drawing.Point(290, 130)
        Me.lblStockActuelE.Size = New System.Drawing.Size(100, 24)
        Me.lblStockActuelE.Name = "lblStockActuelE"

        ' txtStockActuelE
        Me.txtStockActuelE.Location = New System.Drawing.Point(395, 128)
        Me.txtStockActuelE.Size = New System.Drawing.Size(80, 24)
        Me.txtStockActuelE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtStockActuelE.ReadOnly = True
        Me.txtStockActuelE.BackColor = System.Drawing.Color.FromArgb(40, 46, 62)
        Me.txtStockActuelE.ForeColor = System.Drawing.Color.FromArgb(100, 220, 150)
        Me.txtStockActuelE.Name = "txtStockActuelE"

        ' lblMotifE
        Me.lblMotifE.Text = "Motif :"
        Me.lblMotifE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMotifE.ForeColor = System.Drawing.Color.White
        Me.lblMotifE.Location = New System.Drawing.Point(40, 175)
        Me.lblMotifE.Size = New System.Drawing.Size(120, 24)
        Me.lblMotifE.Name = "lblMotifE"

        ' txtMotifE
        Me.txtMotifE.Location = New System.Drawing.Point(170, 173)
        Me.txtMotifE.Size = New System.Drawing.Size(280, 24)
        Me.txtMotifE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtMotifE.Name = "txtMotifE"

        ' btnEntree
        Me.btnEntree.Text = "Valider l'entrée"
        Me.btnEntree.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEntree.BackColor = System.Drawing.Color.FromArgb(0, 110, 100)
        Me.btnEntree.ForeColor = System.Drawing.Color.White
        Me.btnEntree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntree.Location = New System.Drawing.Point(170, 225)
        Me.btnEntree.Size = New System.Drawing.Size(160, 38)
        Me.btnEntree.Name = "btnEntree"

        Me.tabEntree.Controls.Add(Me.lblProduitE)
        Me.tabEntree.Controls.Add(Me.cboProduitE)
        Me.tabEntree.Controls.Add(Me.lblFournisseur)
        Me.tabEntree.Controls.Add(Me.cboFournisseur)
        Me.tabEntree.Controls.Add(Me.lblQuantiteE)
        Me.tabEntree.Controls.Add(Me.txtQuantiteE)
        Me.tabEntree.Controls.Add(Me.lblStockActuelE)
        Me.tabEntree.Controls.Add(Me.txtStockActuelE)
        Me.tabEntree.Controls.Add(Me.lblMotifE)
        Me.tabEntree.Controls.Add(Me.txtMotifE)
        Me.tabEntree.Controls.Add(Me.btnEntree)

        ' ── TAB SORTIE ──
        Me.tabSortie.Text = "  Sortie Stock  "
        Me.tabSortie.BackColor = System.Drawing.Color.FromArgb(28, 33, 45)
        Me.tabSortie.Name = "tabSortie"

        ' lblProduitS
        Me.lblProduitS.Text = "Produit :"
        Me.lblProduitS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblProduitS.ForeColor = System.Drawing.Color.White
        Me.lblProduitS.Location = New System.Drawing.Point(40, 40)
        Me.lblProduitS.Size = New System.Drawing.Size(120, 24)
        Me.lblProduitS.Name = "lblProduitS"

        ' cboProduitS
        Me.cboProduitS.Location = New System.Drawing.Point(170, 38)
        Me.cboProduitS.Size = New System.Drawing.Size(280, 24)
        Me.cboProduitS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduitS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboProduitS.Name = "cboProduitS"

        ' lblQuantiteS
        Me.lblQuantiteS.Text = "Quantité sortie :"
        Me.lblQuantiteS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuantiteS.ForeColor = System.Drawing.Color.White
        Me.lblQuantiteS.Location = New System.Drawing.Point(40, 85)
        Me.lblQuantiteS.Size = New System.Drawing.Size(120, 24)
        Me.lblQuantiteS.Name = "lblQuantiteS"

        ' txtQuantiteS
        Me.txtQuantiteS.Location = New System.Drawing.Point(170, 83)
        Me.txtQuantiteS.Size = New System.Drawing.Size(100, 24)
        Me.txtQuantiteS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtQuantiteS.Name = "txtQuantiteS"

        ' lblStockActuelS
        Me.lblStockActuelS.Text = "Stock actuel :"
        Me.lblStockActuelS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStockActuelS.ForeColor = System.Drawing.Color.FromArgb(255, 150, 100)
        Me.lblStockActuelS.Location = New System.Drawing.Point(290, 85)
        Me.lblStockActuelS.Size = New System.Drawing.Size(100, 24)
        Me.lblStockActuelS.Name = "lblStockActuelS"

        ' txtStockActuelS
        Me.txtStockActuelS.Location = New System.Drawing.Point(395, 83)
        Me.txtStockActuelS.Size = New System.Drawing.Size(80, 24)
        Me.txtStockActuelS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtStockActuelS.ReadOnly = True
        Me.txtStockActuelS.BackColor = System.Drawing.Color.FromArgb(40, 46, 62)
        Me.txtStockActuelS.ForeColor = System.Drawing.Color.FromArgb(255, 150, 100)
        Me.txtStockActuelS.Name = "txtStockActuelS"

        ' lblMotifS
        Me.lblMotifS.Text = "Motif :"
        Me.lblMotifS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMotifS.ForeColor = System.Drawing.Color.White
        Me.lblMotifS.Location = New System.Drawing.Point(40, 130)
        Me.lblMotifS.Size = New System.Drawing.Size(120, 24)
        Me.lblMotifS.Name = "lblMotifS"

        ' txtMotifS
        Me.txtMotifS.Location = New System.Drawing.Point(170, 128)
        Me.txtMotifS.Size = New System.Drawing.Size(280, 24)
        Me.txtMotifS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtMotifS.Name = "txtMotifS"

        ' btnSortie
        Me.btnSortie.Text = "Valider la sortie"
        Me.btnSortie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSortie.BackColor = System.Drawing.Color.FromArgb(150, 25, 25)
        Me.btnSortie.ForeColor = System.Drawing.Color.White
        Me.btnSortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSortie.Location = New System.Drawing.Point(170, 180)
        Me.btnSortie.Size = New System.Drawing.Size(160, 38)
        Me.btnSortie.Name = "btnSortie"

        Me.tabSortie.Controls.Add(Me.lblProduitS)
        Me.tabSortie.Controls.Add(Me.cboProduitS)
        Me.tabSortie.Controls.Add(Me.lblQuantiteS)
        Me.tabSortie.Controls.Add(Me.txtQuantiteS)
        Me.tabSortie.Controls.Add(Me.lblStockActuelS)
        Me.tabSortie.Controls.Add(Me.txtStockActuelS)
        Me.tabSortie.Controls.Add(Me.lblMotifS)
        Me.tabSortie.Controls.Add(Me.txtMotifS)
        Me.tabSortie.Controls.Add(Me.btnSortie)

        ' ── TAB HISTORIQUE ──
        Me.tabHistorique.Text = "  Historique  "
        Me.tabHistorique.BackColor = System.Drawing.Color.FromArgb(28, 33, 45)
        Me.tabHistorique.Name = "tabHistorique"

        Me.dgvHistorique.AllowUserToAddRows = False
        Me.dgvHistorique.AllowUserToDeleteRows = False
        Me.dgvHistorique.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistorique.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHistorique.ReadOnly = True
        Me.dgvHistorique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorique.Name = "dgvHistorique"
        Me.dgvHistorique.BackgroundColor = System.Drawing.Color.FromArgb(33, 38, 52)
        Me.dgvHistorique.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHistorique.RowTemplate.Height = 30
        Me.dgvHistorique.EnableHeadersVisualStyles = False
        Me.dgvHistorique.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 22, 35)
        Me.dgvHistorique.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(140, 165, 215)
        Me.dgvHistorique.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvHistorique.ColumnHeadersHeight = 32
        Me.dgvHistorique.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(33, 38, 52)
        Me.dgvHistorique.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(195, 205, 225)
        Me.dgvHistorique.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 46, 62)
        Me.dgvHistorique.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(25, 70, 155)
        Me.dgvHistorique.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvHistorique.GridColor = System.Drawing.Color.FromArgb(48, 55, 72)

        Me.btnActualiser.Text = "Actualiser"
        Me.btnActualiser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnActualiser.BackColor = System.Drawing.Color.FromArgb(25, 70, 155)
        Me.btnActualiser.ForeColor = System.Drawing.Color.White
        Me.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualiser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnActualiser.Height = 35
        Me.btnActualiser.Name = "btnActualiser"

        Me.tabHistorique.Controls.Add(Me.dgvHistorique)
        Me.tabHistorique.Controls.Add(Me.btnActualiser)

        ' pnlBottom
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(18, 22, 30)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Height = 50
        Me.pnlBottom.Name = "pnlBottom"

        ' btnFermer
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
        Me.ClientSize = New System.Drawing.Size(750, 550)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBottom)
        Me.Name = "frmStock"
        Me.Text = "Mouvements de Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = System.Drawing.Color.FromArgb(28, 33, 45)

        Me.pnlTop.ResumeLayout(False)
        Me.tabControl.ResumeLayout(False)
        Me.tabEntree.ResumeLayout(False)
        Me.tabSortie.ResumeLayout(False)
        Me.tabHistorique.ResumeLayout(False)
        CType(Me.dgvHistorique, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabEntree As System.Windows.Forms.TabPage
    Friend WithEvents lblProduitE As System.Windows.Forms.Label
    Friend WithEvents cboProduitE As System.Windows.Forms.ComboBox
    Friend WithEvents lblFournisseur As System.Windows.Forms.Label
    Friend WithEvents cboFournisseur As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuantiteE As System.Windows.Forms.Label
    Friend WithEvents txtQuantiteE As System.Windows.Forms.TextBox
    Friend WithEvents lblStockActuelE As System.Windows.Forms.Label
    Friend WithEvents txtStockActuelE As System.Windows.Forms.TextBox
    Friend WithEvents lblMotifE As System.Windows.Forms.Label
    Friend WithEvents txtMotifE As System.Windows.Forms.TextBox
    Friend WithEvents btnEntree As System.Windows.Forms.Button
    Friend WithEvents tabSortie As System.Windows.Forms.TabPage
    Friend WithEvents lblProduitS As System.Windows.Forms.Label
    Friend WithEvents cboProduitS As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuantiteS As System.Windows.Forms.Label
    Friend WithEvents txtQuantiteS As System.Windows.Forms.TextBox
    Friend WithEvents lblStockActuelS As System.Windows.Forms.Label
    Friend WithEvents txtStockActuelS As System.Windows.Forms.TextBox
    Friend WithEvents lblMotifS As System.Windows.Forms.Label
    Friend WithEvents txtMotifS As System.Windows.Forms.TextBox
    Friend WithEvents btnSortie As System.Windows.Forms.Button
    Friend WithEvents tabHistorique As System.Windows.Forms.TabPage
    Friend WithEvents dgvHistorique As System.Windows.Forms.DataGridView
    Friend WithEvents btnActualiser As System.Windows.Forms.Button
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnFermer As System.Windows.Forms.Button

End Class