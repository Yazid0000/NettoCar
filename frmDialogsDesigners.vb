' ================================================================
'  frmDialogsDesigners.vb
'  Designers des fenêtres de saisie (coordonnées fixes, sans Y)
'  X1=30 (labels), X2=175 (textbox), W=320, LW=140
'  Espacement : 46px entre champs
' ================================================================


' ============================================================
'  frmDialogClient.Designer.vb
' ============================================================
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogClient
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.lblInscription = New System.Windows.Forms.Label()
        Me.dtpInscription = New System.Windows.Forms.DateTimePicker()
        Me.btnAction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        Dim LF As New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold)
        Dim LC As System.Drawing.Color = System.Drawing.Color.FromArgb(80, 80, 80)
        Dim TF As New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ' ID CLIENT (Y=25)
        Me.lblId.Text = "ID CLIENT" : Me.lblId.Font = LF : Me.lblId.ForeColor = LC
        Me.lblId.Location = New System.Drawing.Point(30, 25) : Me.lblId.Size = New System.Drawing.Size(140, 22)
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblId.Name = "lblId"
        Me.txtId.Font = TF : Me.txtId.Location = New System.Drawing.Point(175, 25) : Me.txtId.Size = New System.Drawing.Size(320, 26)
        Me.txtId.ReadOnly = True : Me.txtId.BackColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.txtId.ForeColor = System.Drawing.Color.White : Me.txtId.Name = "txtId"
        ' NOM (Y=71)
        Me.lblNom.Text = "NOM" : Me.lblNom.Font = LF : Me.lblNom.ForeColor = LC
        Me.lblNom.Location = New System.Drawing.Point(30, 71) : Me.lblNom.Size = New System.Drawing.Size(140, 22)
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblNom.Name = "lblNom"
        Me.txtNom.Font = TF : Me.txtNom.Location = New System.Drawing.Point(175, 71) : Me.txtNom.Size = New System.Drawing.Size(320, 26)
        Me.txtNom.Name = "txtNom" : Me.txtNom.TabIndex = 1
        ' TELEPHONE (Y=117)
        Me.lblTelephone.Text = "TELEPHONE" : Me.lblTelephone.Font = LF : Me.lblTelephone.ForeColor = LC
        Me.lblTelephone.Location = New System.Drawing.Point(30, 117) : Me.lblTelephone.Size = New System.Drawing.Size(140, 22)
        Me.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblTelephone.Name = "lblTelephone"
        Me.txtTelephone.Font = TF : Me.txtTelephone.Location = New System.Drawing.Point(175, 117) : Me.txtTelephone.Size = New System.Drawing.Size(320, 26)
        Me.txtTelephone.Name = "txtTelephone" : Me.txtTelephone.TabIndex = 2
        ' EMAIL (Y=163)
        Me.lblEmail.Text = "EMAIL" : Me.lblEmail.Font = LF : Me.lblEmail.ForeColor = LC
        Me.lblEmail.Location = New System.Drawing.Point(30, 163) : Me.lblEmail.Size = New System.Drawing.Size(140, 22)
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblEmail.Name = "lblEmail"
        Me.txtEmail.Font = TF : Me.txtEmail.Location = New System.Drawing.Point(175, 163) : Me.txtEmail.Size = New System.Drawing.Size(320, 26)
        Me.txtEmail.Name = "txtEmail" : Me.txtEmail.TabIndex = 3
        ' ADRESSE (Y=209)
        Me.lblAdresse.Text = "ADRESSE" : Me.lblAdresse.Font = LF : Me.lblAdresse.ForeColor = LC
        Me.lblAdresse.Location = New System.Drawing.Point(30, 209) : Me.lblAdresse.Size = New System.Drawing.Size(140, 22)
        Me.lblAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblAdresse.Name = "lblAdresse"
        Me.txtAdresse.Font = TF : Me.txtAdresse.Location = New System.Drawing.Point(175, 209) : Me.txtAdresse.Size = New System.Drawing.Size(320, 26)
        Me.txtAdresse.Name = "txtAdresse" : Me.txtAdresse.TabIndex = 4
        ' VILLE (Y=255)
        Me.lblVille.Text = "VILLE" : Me.lblVille.Font = LF : Me.lblVille.ForeColor = LC
        Me.lblVille.Location = New System.Drawing.Point(30, 255) : Me.lblVille.Size = New System.Drawing.Size(140, 22)
        Me.lblVille.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblVille.Name = "lblVille"
        Me.txtVille.Font = TF : Me.txtVille.Location = New System.Drawing.Point(175, 255) : Me.txtVille.Size = New System.Drawing.Size(320, 26)
        Me.txtVille.Name = "txtVille" : Me.txtVille.TabIndex = 5
        ' DATE INSCRIPTION (Y=301)
        Me.lblInscription.Text = "DATE INSCRIPTION" : Me.lblInscription.Font = LF : Me.lblInscription.ForeColor = LC
        Me.lblInscription.Location = New System.Drawing.Point(30, 301) : Me.lblInscription.Size = New System.Drawing.Size(140, 22)
        Me.lblInscription.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblInscription.Name = "lblInscription"
        Me.dtpInscription.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpInscription.Location = New System.Drawing.Point(175, 301) : Me.dtpInscription.Size = New System.Drawing.Size(320, 26)
        Me.dtpInscription.Name = "dtpInscription" : Me.dtpInscription.TabIndex = 6
        ' Bouton rouge (Y=367)
        Me.btnAction.Text = "Ajouter"
        Me.btnAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAction.BackColor = System.Drawing.Color.FromArgb(200, 40, 40)
        Me.btnAction.ForeColor = System.Drawing.Color.White
        Me.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAction.FlatAppearance.BorderSize = 0
        Me.btnAction.Size = New System.Drawing.Size(120, 38)
        Me.btnAction.Location = New System.Drawing.Point(375, 367)
        Me.btnAction.Name = "btnAction" : Me.btnAction.TabIndex = 7
        Me.btnAction.UseVisualStyleBackColor = False
        Me.btnAction.Cursor = System.Windows.Forms.Cursors.Hand
        ' Form
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 420)
        Me.Controls.Add(Me.lblId) : Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblNom) : Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblTelephone) : Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.lblEmail) : Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblAdresse) : Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.lblVille) : Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.lblInscription) : Me.Controls.Add(Me.dtpInscription)
        Me.Controls.Add(Me.btnAction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False : Me.MinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.BackColor = System.Drawing.Color.FromArgb(245, 245, 245)
        Me.Name = "frmDialogClient" : Me.Text = "NETTOCAR - GESTION DES CLIENTS"
        Me.ResumeLayout(False) : Me.PerformLayout()
    End Sub
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblAdresse As System.Windows.Forms.Label
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents lblVille As System.Windows.Forms.Label
    Friend WithEvents txtVille As System.Windows.Forms.TextBox
    Friend WithEvents lblInscription As System.Windows.Forms.Label
    Friend WithEvents dtpInscription As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAction As System.Windows.Forms.Button
End Class


' ============================================================
'  frmDialogService.Designer.vb
' ============================================================
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogService
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblNomService = New System.Windows.Forms.Label()
        Me.txtNomService = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblPrix = New System.Windows.Forms.Label()
        Me.txtPrix = New System.Windows.Forms.TextBox()
        Me.lblDuree = New System.Windows.Forms.Label()
        Me.txtDuree = New System.Windows.Forms.TextBox()
        Me.btnAction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        Dim LF As New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold)
        Dim LC As System.Drawing.Color = System.Drawing.Color.FromArgb(80, 80, 80)
        Dim TF As New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ' ID SERVICE (Y=25)
        Me.lblId.Text = "ID SERVICE" : Me.lblId.Font = LF : Me.lblId.ForeColor = LC
        Me.lblId.Location = New System.Drawing.Point(30, 25) : Me.lblId.Size = New System.Drawing.Size(140, 22)
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblId.Name = "lblId"
        Me.txtId.Font = TF : Me.txtId.Location = New System.Drawing.Point(175, 25) : Me.txtId.Size = New System.Drawing.Size(320, 26)
        Me.txtId.ReadOnly = True : Me.txtId.BackColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.txtId.ForeColor = System.Drawing.Color.White : Me.txtId.Name = "txtId"
        ' NOM SERVICE (Y=71)
        Me.lblNomService.Text = "NOM SERVICE" : Me.lblNomService.Font = LF : Me.lblNomService.ForeColor = LC
        Me.lblNomService.Location = New System.Drawing.Point(30, 71) : Me.lblNomService.Size = New System.Drawing.Size(140, 22)
        Me.lblNomService.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblNomService.Name = "lblNomService"
        Me.txtNomService.Font = TF : Me.txtNomService.Location = New System.Drawing.Point(175, 71) : Me.txtNomService.Size = New System.Drawing.Size(320, 26)
        Me.txtNomService.Name = "txtNomService" : Me.txtNomService.TabIndex = 1
        ' DESCRIPTION (Y=117)
        Me.lblDescription.Text = "DESCRIPTION" : Me.lblDescription.Font = LF : Me.lblDescription.ForeColor = LC
        Me.lblDescription.Location = New System.Drawing.Point(30, 117) : Me.lblDescription.Size = New System.Drawing.Size(140, 22)
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblDescription.Name = "lblDescription"
        Me.txtDescription.Font = TF : Me.txtDescription.Location = New System.Drawing.Point(175, 117) : Me.txtDescription.Size = New System.Drawing.Size(320, 26)
        Me.txtDescription.Name = "txtDescription" : Me.txtDescription.TabIndex = 2
        ' PRIX (Y=163)
        Me.lblPrix.Text = "PRIX (DH)" : Me.lblPrix.Font = LF : Me.lblPrix.ForeColor = LC
        Me.lblPrix.Location = New System.Drawing.Point(30, 163) : Me.lblPrix.Size = New System.Drawing.Size(140, 22)
        Me.lblPrix.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblPrix.Name = "lblPrix"
        Me.txtPrix.Font = TF : Me.txtPrix.Location = New System.Drawing.Point(175, 163) : Me.txtPrix.Size = New System.Drawing.Size(320, 26)
        Me.txtPrix.Name = "txtPrix" : Me.txtPrix.TabIndex = 3
        ' DUREE (Y=209)
        Me.lblDuree.Text = "DUREE ESTIMEE (min)" : Me.lblDuree.Font = LF : Me.lblDuree.ForeColor = LC
        Me.lblDuree.Location = New System.Drawing.Point(5, 200) : Me.lblDuree.Size = New System.Drawing.Size(170, 36)
        Me.lblDuree.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblDuree.Name = "lblDuree"
        Me.txtDuree.Font = TF : Me.txtDuree.Location = New System.Drawing.Point(180, 209) : Me.txtDuree.Size = New System.Drawing.Size(315, 26)
        Me.txtDuree.Name = "txtDuree" : Me.txtDuree.TabIndex = 4
        ' Bouton rouge (Y=275)
        Me.btnAction.Text = "Ajouter"
        Me.btnAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAction.BackColor = System.Drawing.Color.FromArgb(200, 40, 40)
        Me.btnAction.ForeColor = System.Drawing.Color.White
        Me.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAction.FlatAppearance.BorderSize = 0
        Me.btnAction.Size = New System.Drawing.Size(120, 38)
        Me.btnAction.Location = New System.Drawing.Point(375, 275)
        Me.btnAction.Name = "btnAction" : Me.btnAction.TabIndex = 5
        Me.btnAction.UseVisualStyleBackColor = False
        Me.btnAction.Cursor = System.Windows.Forms.Cursors.Hand
        ' Form
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 330)
        Me.Controls.Add(Me.lblId) : Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblNomService) : Me.Controls.Add(Me.txtNomService)
        Me.Controls.Add(Me.lblDescription) : Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblPrix) : Me.Controls.Add(Me.txtPrix)
        Me.Controls.Add(Me.lblDuree) : Me.Controls.Add(Me.txtDuree)
        Me.Controls.Add(Me.btnAction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False : Me.MinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.BackColor = System.Drawing.Color.FromArgb(245, 245, 245)
        Me.Name = "frmDialogService" : Me.Text = "NETTOCAR - GESTION DES SERVICES"
        Me.ResumeLayout(False) : Me.PerformLayout()
    End Sub
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblNomService As System.Windows.Forms.Label
    Friend WithEvents txtNomService As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblPrix As System.Windows.Forms.Label
    Friend WithEvents txtPrix As System.Windows.Forms.TextBox
    Friend WithEvents lblDuree As System.Windows.Forms.Label
    Friend WithEvents txtDuree As System.Windows.Forms.TextBox
    Friend WithEvents btnAction As System.Windows.Forms.Button
End Class


' ============================================================
'  frmDialogProduit.Designer.vb
' ============================================================
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogProduit
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblNomProduit = New System.Windows.Forms.Label()
        Me.txtNomProduit = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblPrixAchat = New System.Windows.Forms.Label()
        Me.txtPrixAchat = New System.Windows.Forms.TextBox()
        Me.lblQuantite = New System.Windows.Forms.Label()
        Me.txtQuantite = New System.Windows.Forms.TextBox()
        Me.lblSeuilAlerte = New System.Windows.Forms.Label()
        Me.txtSeuilAlerte = New System.Windows.Forms.TextBox()
        Me.btnAction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        Dim LF As New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold)
        Dim LC As System.Drawing.Color = System.Drawing.Color.FromArgb(80, 80, 80)
        Dim TF As New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ' ID PRODUIT (Y=25)
        Me.lblId.Text = "ID PRODUIT" : Me.lblId.Font = LF : Me.lblId.ForeColor = LC
        Me.lblId.Location = New System.Drawing.Point(30, 25) : Me.lblId.Size = New System.Drawing.Size(140, 22)
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblId.Name = "lblId"
        Me.txtId.Font = TF : Me.txtId.Location = New System.Drawing.Point(175, 25) : Me.txtId.Size = New System.Drawing.Size(320, 26)
        Me.txtId.ReadOnly = True : Me.txtId.BackColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.txtId.ForeColor = System.Drawing.Color.White : Me.txtId.Name = "txtId"
        ' NOM PRODUIT (Y=71)
        Me.lblNomProduit.Text = "NOM PRODUIT" : Me.lblNomProduit.Font = LF : Me.lblNomProduit.ForeColor = LC
        Me.lblNomProduit.Location = New System.Drawing.Point(30, 71) : Me.lblNomProduit.Size = New System.Drawing.Size(140, 22)
        Me.lblNomProduit.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblNomProduit.Name = "lblNomProduit"
        Me.txtNomProduit.Font = TF : Me.txtNomProduit.Location = New System.Drawing.Point(175, 71) : Me.txtNomProduit.Size = New System.Drawing.Size(320, 26)
        Me.txtNomProduit.Name = "txtNomProduit" : Me.txtNomProduit.TabIndex = 1
        ' DESCRIPTION (Y=117)
        Me.lblDescription.Text = "DESCRIPTION" : Me.lblDescription.Font = LF : Me.lblDescription.ForeColor = LC
        Me.lblDescription.Location = New System.Drawing.Point(30, 117) : Me.lblDescription.Size = New System.Drawing.Size(140, 22)
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblDescription.Name = "lblDescription"
        Me.txtDescription.Font = TF : Me.txtDescription.Location = New System.Drawing.Point(175, 117) : Me.txtDescription.Size = New System.Drawing.Size(320, 26)
        Me.txtDescription.Name = "txtDescription" : Me.txtDescription.TabIndex = 2
        ' PRIX ACHAT (Y=163)
        Me.lblPrixAchat.Text = "PRIX ACHAT (DH)" : Me.lblPrixAchat.Font = LF : Me.lblPrixAchat.ForeColor = LC
        Me.lblPrixAchat.Location = New System.Drawing.Point(30, 163) : Me.lblPrixAchat.Size = New System.Drawing.Size(140, 22)
        Me.lblPrixAchat.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblPrixAchat.Name = "lblPrixAchat"
        Me.txtPrixAchat.Font = TF : Me.txtPrixAchat.Location = New System.Drawing.Point(175, 163) : Me.txtPrixAchat.Size = New System.Drawing.Size(320, 26)
        Me.txtPrixAchat.Name = "txtPrixAchat" : Me.txtPrixAchat.TabIndex = 3
        ' QUANTITE (Y=209)
        Me.lblQuantite.Text = "QUANTITE" : Me.lblQuantite.Font = LF : Me.lblQuantite.ForeColor = LC
        Me.lblQuantite.Location = New System.Drawing.Point(30, 209) : Me.lblQuantite.Size = New System.Drawing.Size(140, 22)
        Me.lblQuantite.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblQuantite.Name = "lblQuantite"
        Me.txtQuantite.Font = TF : Me.txtQuantite.Location = New System.Drawing.Point(175, 209) : Me.txtQuantite.Size = New System.Drawing.Size(320, 26)
        Me.txtQuantite.Name = "txtQuantite" : Me.txtQuantite.TabIndex = 4
        ' SEUIL ALERTE (Y=255)
        Me.lblSeuilAlerte.Text = "SEUIL ALERTE" : Me.lblSeuilAlerte.Font = LF : Me.lblSeuilAlerte.ForeColor = LC
        Me.lblSeuilAlerte.Location = New System.Drawing.Point(30, 255) : Me.lblSeuilAlerte.Size = New System.Drawing.Size(140, 22)
        Me.lblSeuilAlerte.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblSeuilAlerte.Name = "lblSeuilAlerte"
        Me.txtSeuilAlerte.Font = TF : Me.txtSeuilAlerte.Location = New System.Drawing.Point(175, 255) : Me.txtSeuilAlerte.Size = New System.Drawing.Size(320, 26)
        Me.txtSeuilAlerte.Name = "txtSeuilAlerte" : Me.txtSeuilAlerte.TabIndex = 5
        ' Bouton rouge (Y=321)
        Me.btnAction.Text = "Ajouter"
        Me.btnAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAction.BackColor = System.Drawing.Color.FromArgb(200, 40, 40)
        Me.btnAction.ForeColor = System.Drawing.Color.White
        Me.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAction.FlatAppearance.BorderSize = 0
        Me.btnAction.Size = New System.Drawing.Size(120, 38)
        Me.btnAction.Location = New System.Drawing.Point(375, 321)
        Me.btnAction.Name = "btnAction" : Me.btnAction.TabIndex = 6
        Me.btnAction.UseVisualStyleBackColor = False
        Me.btnAction.Cursor = System.Windows.Forms.Cursors.Hand
        ' Form
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 375)
        Me.Controls.Add(Me.lblId) : Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblNomProduit) : Me.Controls.Add(Me.txtNomProduit)
        Me.Controls.Add(Me.lblDescription) : Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblPrixAchat) : Me.Controls.Add(Me.txtPrixAchat)
        Me.Controls.Add(Me.lblQuantite) : Me.Controls.Add(Me.txtQuantite)
        Me.Controls.Add(Me.lblSeuilAlerte) : Me.Controls.Add(Me.txtSeuilAlerte)
        Me.Controls.Add(Me.btnAction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False : Me.MinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.BackColor = System.Drawing.Color.FromArgb(245, 245, 245)
        Me.Name = "frmDialogProduit" : Me.Text = "NETTOCAR - GESTION DES PRODUITS"
        Me.ResumeLayout(False) : Me.PerformLayout()
    End Sub
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblNomProduit As System.Windows.Forms.Label
    Friend WithEvents txtNomProduit As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblPrixAchat As System.Windows.Forms.Label
    Friend WithEvents txtPrixAchat As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantite As System.Windows.Forms.Label
    Friend WithEvents txtQuantite As System.Windows.Forms.TextBox
    Friend WithEvents lblSeuilAlerte As System.Windows.Forms.Label
    Friend WithEvents txtSeuilAlerte As System.Windows.Forms.TextBox
    Friend WithEvents btnAction As System.Windows.Forms.Button
End Class


' ============================================================
'  frmDialogFournisseur.Designer.vb
' ============================================================
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogFournisseur
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblRaisonSociale = New System.Windows.Forms.Label()
        Me.txtRaisonSociale = New System.Windows.Forms.TextBox()
        Me.lblInterlocuteur = New System.Windows.Forms.Label()
        Me.txtInterlocuteur = New System.Windows.Forms.TextBox()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.lblPays = New System.Windows.Forms.Label()
        Me.txtPays = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnAction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        Dim LF As New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold)
        Dim LC As System.Drawing.Color = System.Drawing.Color.FromArgb(80, 80, 80)
        Dim TF As New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ' ID FOURNISSEUR (Y=25)
        Me.lblId.Text = "ID FOURNISSEUR" : Me.lblId.Font = LF : Me.lblId.ForeColor = LC
        Me.lblId.Location = New System.Drawing.Point(30, 25) : Me.lblId.Size = New System.Drawing.Size(140, 22)
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblId.Name = "lblId"
        Me.txtId.Font = TF : Me.txtId.Location = New System.Drawing.Point(175, 25) : Me.txtId.Size = New System.Drawing.Size(320, 26)
        Me.txtId.ReadOnly = True : Me.txtId.BackColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.txtId.ForeColor = System.Drawing.Color.White : Me.txtId.Name = "txtId"
        ' RAISON SOCIALE (Y=71)
        Me.lblRaisonSociale.Text = "RAISON SOCIALE" : Me.lblRaisonSociale.Font = LF : Me.lblRaisonSociale.ForeColor = LC
        Me.lblRaisonSociale.Location = New System.Drawing.Point(30, 71) : Me.lblRaisonSociale.Size = New System.Drawing.Size(140, 22)
        Me.lblRaisonSociale.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblRaisonSociale.Name = "lblRaisonSociale"
        Me.txtRaisonSociale.Font = TF : Me.txtRaisonSociale.Location = New System.Drawing.Point(175, 71) : Me.txtRaisonSociale.Size = New System.Drawing.Size(320, 26)
        Me.txtRaisonSociale.Name = "txtRaisonSociale" : Me.txtRaisonSociale.TabIndex = 1
        ' INTERLOCUTEUR (Y=117)
        Me.lblInterlocuteur.Text = "INTERLOCUTEUR" : Me.lblInterlocuteur.Font = LF : Me.lblInterlocuteur.ForeColor = LC
        Me.lblInterlocuteur.Location = New System.Drawing.Point(30, 117) : Me.lblInterlocuteur.Size = New System.Drawing.Size(140, 22)
        Me.lblInterlocuteur.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblInterlocuteur.Name = "lblInterlocuteur"
        Me.txtInterlocuteur.Font = TF : Me.txtInterlocuteur.Location = New System.Drawing.Point(175, 117) : Me.txtInterlocuteur.Size = New System.Drawing.Size(320, 26)
        Me.txtInterlocuteur.Name = "txtInterlocuteur" : Me.txtInterlocuteur.TabIndex = 2
        ' VILLE (Y=163)
        Me.lblVille.Text = "VILLE" : Me.lblVille.Font = LF : Me.lblVille.ForeColor = LC
        Me.lblVille.Location = New System.Drawing.Point(30, 163) : Me.lblVille.Size = New System.Drawing.Size(140, 22)
        Me.lblVille.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblVille.Name = "lblVille"
        Me.txtVille.Font = TF : Me.txtVille.Location = New System.Drawing.Point(175, 163) : Me.txtVille.Size = New System.Drawing.Size(320, 26)
        Me.txtVille.Name = "txtVille" : Me.txtVille.TabIndex = 3
        ' PAYS (Y=209)
        Me.lblPays.Text = "PAYS" : Me.lblPays.Font = LF : Me.lblPays.ForeColor = LC
        Me.lblPays.Location = New System.Drawing.Point(30, 209) : Me.lblPays.Size = New System.Drawing.Size(140, 22)
        Me.lblPays.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblPays.Name = "lblPays"
        Me.txtPays.Font = TF : Me.txtPays.Location = New System.Drawing.Point(175, 209) : Me.txtPays.Size = New System.Drawing.Size(320, 26)
        Me.txtPays.Name = "txtPays" : Me.txtPays.TabIndex = 4
        ' TELEPHONE (Y=255)
        Me.lblTelephone.Text = "TELEPHONE" : Me.lblTelephone.Font = LF : Me.lblTelephone.ForeColor = LC
        Me.lblTelephone.Location = New System.Drawing.Point(30, 255) : Me.lblTelephone.Size = New System.Drawing.Size(140, 22)
        Me.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblTelephone.Name = "lblTelephone"
        Me.txtTelephone.Font = TF : Me.txtTelephone.Location = New System.Drawing.Point(175, 255) : Me.txtTelephone.Size = New System.Drawing.Size(320, 26)
        Me.txtTelephone.Name = "txtTelephone" : Me.txtTelephone.TabIndex = 5
        ' EMAIL (Y=301)
        Me.lblEmail.Text = "EMAIL" : Me.lblEmail.Font = LF : Me.lblEmail.ForeColor = LC
        Me.lblEmail.Location = New System.Drawing.Point(30, 301) : Me.lblEmail.Size = New System.Drawing.Size(140, 22)
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblEmail.Name = "lblEmail"
        Me.txtEmail.Font = TF : Me.txtEmail.Location = New System.Drawing.Point(175, 301) : Me.txtEmail.Size = New System.Drawing.Size(320, 26)
        Me.txtEmail.Name = "txtEmail" : Me.txtEmail.TabIndex = 6
        ' Bouton rouge (Y=367)
        Me.btnAction.Text = "Ajouter"
        Me.btnAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAction.BackColor = System.Drawing.Color.FromArgb(200, 40, 40)
        Me.btnAction.ForeColor = System.Drawing.Color.White
        Me.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAction.FlatAppearance.BorderSize = 0
        Me.btnAction.Size = New System.Drawing.Size(120, 38)
        Me.btnAction.Location = New System.Drawing.Point(375, 367)
        Me.btnAction.Name = "btnAction" : Me.btnAction.TabIndex = 7
        Me.btnAction.UseVisualStyleBackColor = False
        Me.btnAction.Cursor = System.Windows.Forms.Cursors.Hand
        ' Form
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 420)
        Me.Controls.Add(Me.lblId) : Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblRaisonSociale) : Me.Controls.Add(Me.txtRaisonSociale)
        Me.Controls.Add(Me.lblInterlocuteur) : Me.Controls.Add(Me.txtInterlocuteur)
        Me.Controls.Add(Me.lblVille) : Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.lblPays) : Me.Controls.Add(Me.txtPays)
        Me.Controls.Add(Me.lblTelephone) : Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.lblEmail) : Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnAction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False : Me.MinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.BackColor = System.Drawing.Color.FromArgb(245, 245, 245)
        Me.Name = "frmDialogFournisseur" : Me.Text = "NETTOCAR - GESTION DES FOURNISSEURS"
        Me.ResumeLayout(False) : Me.PerformLayout()
    End Sub
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblRaisonSociale As System.Windows.Forms.Label
    Friend WithEvents txtRaisonSociale As System.Windows.Forms.TextBox
    Friend WithEvents lblInterlocuteur As System.Windows.Forms.Label
    Friend WithEvents txtInterlocuteur As System.Windows.Forms.TextBox
    Friend WithEvents lblVille As System.Windows.Forms.Label
    Friend WithEvents txtVille As System.Windows.Forms.TextBox
    Friend WithEvents lblPays As System.Windows.Forms.Label
    Friend WithEvents txtPays As System.Windows.Forms.TextBox
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnAction As System.Windows.Forms.Button
End Class


' ============================================================
'  frmDialogEmploye.Designer.vb
' ============================================================
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogEmploye
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lblPoste = New System.Windows.Forms.Label()
        Me.txtPoste = New System.Windows.Forms.TextBox()
        Me.lblSalaire = New System.Windows.Forms.Label()
        Me.txtSalaire = New System.Windows.Forms.TextBox()
        Me.lblEmbauche = New System.Windows.Forms.Label()
        Me.dtpEmbauche = New System.Windows.Forms.DateTimePicker()
        Me.lblAgence = New System.Windows.Forms.Label()
        Me.cmbAgence = New System.Windows.Forms.ComboBox()
        Me.lblPhoto = New System.Windows.Forms.Label()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.btnChoisirPhoto = New System.Windows.Forms.Button()
        Me.btnAction = New System.Windows.Forms.Button()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Dim LF As New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold)
        Dim LC As System.Drawing.Color = System.Drawing.Color.FromArgb(80, 80, 80)
        Dim TF As New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ' Colonne gauche : X1=30, X2=160, W=260
        ' ID (Y=25)
        Me.lblId.Text = "ID" : Me.lblId.Font = LF : Me.lblId.ForeColor = LC
        Me.lblId.Location = New System.Drawing.Point(30, 25) : Me.lblId.Size = New System.Drawing.Size(125, 22)
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblId.Name = "lblId"
        Me.txtId.Font = TF : Me.txtId.Location = New System.Drawing.Point(160, 25) : Me.txtId.Size = New System.Drawing.Size(260, 26)
        Me.txtId.ReadOnly = True : Me.txtId.BackColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.txtId.ForeColor = System.Drawing.Color.White : Me.txtId.Name = "txtId"
        ' NOM (Y=71)
        Me.lblNom.Text = "NOM" : Me.lblNom.Font = LF : Me.lblNom.ForeColor = LC
        Me.lblNom.Location = New System.Drawing.Point(30, 71) : Me.lblNom.Size = New System.Drawing.Size(125, 22)
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblNom.Name = "lblNom"
        Me.txtNom.Font = TF : Me.txtNom.Location = New System.Drawing.Point(160, 71) : Me.txtNom.Size = New System.Drawing.Size(260, 26)
        Me.txtNom.Name = "txtNom" : Me.txtNom.TabIndex = 1
        ' PRENOM (Y=117)
        Me.lblPrenom.Text = "PRENOM" : Me.lblPrenom.Font = LF : Me.lblPrenom.ForeColor = LC
        Me.lblPrenom.Location = New System.Drawing.Point(30, 117) : Me.lblPrenom.Size = New System.Drawing.Size(125, 22)
        Me.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblPrenom.Name = "lblPrenom"
        Me.txtPrenom.Font = TF : Me.txtPrenom.Location = New System.Drawing.Point(160, 117) : Me.txtPrenom.Size = New System.Drawing.Size(260, 26)
        Me.txtPrenom.Name = "txtPrenom" : Me.txtPrenom.TabIndex = 2
        ' POSTE (Y=163)
        Me.lblPoste.Text = "POSTE" : Me.lblPoste.Font = LF : Me.lblPoste.ForeColor = LC
        Me.lblPoste.Location = New System.Drawing.Point(30, 163) : Me.lblPoste.Size = New System.Drawing.Size(125, 22)
        Me.lblPoste.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblPoste.Name = "lblPoste"
        Me.txtPoste.Font = TF : Me.txtPoste.Location = New System.Drawing.Point(160, 163) : Me.txtPoste.Size = New System.Drawing.Size(260, 26)
        Me.txtPoste.Name = "txtPoste" : Me.txtPoste.TabIndex = 3
        ' SALAIRE (Y=209)
        Me.lblSalaire.Text = "SALAIRE (DH)" : Me.lblSalaire.Font = LF : Me.lblSalaire.ForeColor = LC
        Me.lblSalaire.Location = New System.Drawing.Point(30, 209) : Me.lblSalaire.Size = New System.Drawing.Size(125, 22)
        Me.lblSalaire.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblSalaire.Name = "lblSalaire"
        Me.txtSalaire.Font = TF : Me.txtSalaire.Location = New System.Drawing.Point(160, 209) : Me.txtSalaire.Size = New System.Drawing.Size(260, 26)
        Me.txtSalaire.Name = "txtSalaire" : Me.txtSalaire.TabIndex = 4
        ' DATE EMBAUCHE (Y=255)
        Me.lblEmbauche.Text = "DATE EMBAUCHE" : Me.lblEmbauche.Font = LF : Me.lblEmbauche.ForeColor = LC
        Me.lblEmbauche.Location = New System.Drawing.Point(30, 255) : Me.lblEmbauche.Size = New System.Drawing.Size(125, 22)
        Me.lblEmbauche.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblEmbauche.Name = "lblEmbauche"
        Me.dtpEmbauche.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpEmbauche.Location = New System.Drawing.Point(160, 255) : Me.dtpEmbauche.Size = New System.Drawing.Size(260, 26)
        Me.dtpEmbauche.Name = "dtpEmbauche" : Me.dtpEmbauche.TabIndex = 5
        ' AGENCE (Y=301)
        Me.lblAgence.Text = "AGENCE" : Me.lblAgence.Font = LF : Me.lblAgence.ForeColor = LC
        Me.lblAgence.Location = New System.Drawing.Point(30, 301) : Me.lblAgence.Size = New System.Drawing.Size(125, 22)
        Me.lblAgence.TextAlign = System.Drawing.ContentAlignment.MiddleRight : Me.lblAgence.Name = "lblAgence"
        Me.cmbAgence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAgence.Font = TF : Me.cmbAgence.Location = New System.Drawing.Point(160, 301) : Me.cmbAgence.Size = New System.Drawing.Size(260, 26)
        Me.cmbAgence.Name = "cmbAgence" : Me.cmbAgence.TabIndex = 6
        ' Colonne droite : photo (X=450)
        Me.lblPhoto.Text = "PHOTO" : Me.lblPhoto.Font = LF : Me.lblPhoto.ForeColor = LC
        Me.lblPhoto.Location = New System.Drawing.Point(450, 25) : Me.lblPhoto.Size = New System.Drawing.Size(160, 22)
        Me.lblPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : Me.lblPhoto.Name = "lblPhoto"
        Me.picPhoto.Location = New System.Drawing.Point(450, 50) : Me.picPhoto.Size = New System.Drawing.Size(160, 160)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.BackColor = System.Drawing.Color.LightGray : Me.picPhoto.Name = "picPhoto"
        Me.btnChoisirPhoto.Text = "Choisir photo..."
        Me.btnChoisirPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnChoisirPhoto.BackColor = System.Drawing.Color.FromArgb(30, 80, 162)
        Me.btnChoisirPhoto.ForeColor = System.Drawing.Color.White
        Me.btnChoisirPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoisirPhoto.FlatAppearance.BorderSize = 0
        Me.btnChoisirPhoto.Location = New System.Drawing.Point(450, 220) : Me.btnChoisirPhoto.Size = New System.Drawing.Size(160, 30)
        Me.btnChoisirPhoto.Name = "btnChoisirPhoto" : Me.btnChoisirPhoto.UseVisualStyleBackColor = False : Me.btnChoisirPhoto.TabIndex = 7
        ' Bouton rouge (Y=367)
        Me.btnAction.Text = "Ajouter"
        Me.btnAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAction.BackColor = System.Drawing.Color.FromArgb(200, 40, 40)
        Me.btnAction.ForeColor = System.Drawing.Color.White
        Me.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAction.FlatAppearance.BorderSize = 0
        Me.btnAction.Size = New System.Drawing.Size(120, 38)
        Me.btnAction.Location = New System.Drawing.Point(300, 367)
        Me.btnAction.Name = "btnAction" : Me.btnAction.UseVisualStyleBackColor = False
        Me.btnAction.Cursor = System.Windows.Forms.Cursors.Hand : Me.btnAction.TabIndex = 8
        ' Form
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 420)
        Me.Controls.Add(Me.lblId) : Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblNom) : Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblPrenom) : Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.lblPoste) : Me.Controls.Add(Me.txtPoste)
        Me.Controls.Add(Me.lblSalaire) : Me.Controls.Add(Me.txtSalaire)
        Me.Controls.Add(Me.lblEmbauche) : Me.Controls.Add(Me.dtpEmbauche)
        Me.Controls.Add(Me.lblAgence) : Me.Controls.Add(Me.cmbAgence)
        Me.Controls.Add(Me.lblPhoto) : Me.Controls.Add(Me.picPhoto)
        Me.Controls.Add(Me.btnChoisirPhoto) : Me.Controls.Add(Me.btnAction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False : Me.MinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.BackColor = System.Drawing.Color.FromArgb(245, 245, 245)
        Me.Name = "frmDialogEmploye" : Me.Text = "NETTOCAR - GESTION DES EMPLOYES"
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False) : Me.PerformLayout()
    End Sub
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblPrenom As System.Windows.Forms.Label
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents lblPoste As System.Windows.Forms.Label
    Friend WithEvents txtPoste As System.Windows.Forms.TextBox
    Friend WithEvents lblSalaire As System.Windows.Forms.Label
    Friend WithEvents txtSalaire As System.Windows.Forms.TextBox
    Friend WithEvents lblEmbauche As System.Windows.Forms.Label
    Friend WithEvents dtpEmbauche As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAgence As System.Windows.Forms.Label
    Friend WithEvents cmbAgence As System.Windows.Forms.ComboBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnChoisirPhoto As System.Windows.Forms.Button
    Friend WithEvents btnAction As System.Windows.Forms.Button
End Class
