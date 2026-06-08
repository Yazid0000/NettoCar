<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.lblMotDePasse = New System.Windows.Forms.Label()
        Me.txtMotDePasse = New System.Windows.Forms.TextBox()
        Me.btnConnecter = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()

        ' lblTitre
        Me.lblTitre.Text = "NETTOCAR - Connexion"
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitre.ForeColor = System.Drawing.Color.FromArgb(25, 70, 155)
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTitre.Location = New System.Drawing.Point(0, 20)
        Me.lblTitre.Size = New System.Drawing.Size(380, 40)
        Me.lblTitre.Name = "lblTitre"

        ' lblLogin
        Me.lblLogin.Text = "Login :"
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogin.Location = New System.Drawing.Point(40, 90)
        Me.lblLogin.Size = New System.Drawing.Size(80, 24)
        Me.lblLogin.Name = "lblLogin"

        ' txtLogin
        Me.txtLogin.Location = New System.Drawing.Point(130, 88)
        Me.txtLogin.Size = New System.Drawing.Size(210, 24)
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLogin.Name = "txtLogin"

        ' lblMotDePasse
        Me.lblMotDePasse.Text = "Mot de passe :"
        Me.lblMotDePasse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMotDePasse.Location = New System.Drawing.Point(40, 135)
        Me.lblMotDePasse.Size = New System.Drawing.Size(100, 24)
        Me.lblMotDePasse.Name = "lblMotDePasse"

        ' txtMotDePasse
        Me.txtMotDePasse.Location = New System.Drawing.Point(150, 133)
        Me.txtMotDePasse.Size = New System.Drawing.Size(190, 24)
        Me.txtMotDePasse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtMotDePasse.PasswordChar = "*"
        Me.txtMotDePasse.Name = "txtMotDePasse"

        ' btnConnecter
        Me.btnConnecter.Text = "Se connecter"
        Me.btnConnecter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnConnecter.BackColor = System.Drawing.Color.FromArgb(25, 70, 155)
        Me.btnConnecter.ForeColor = System.Drawing.Color.White
        Me.btnConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnecter.Location = New System.Drawing.Point(80, 195)
        Me.btnConnecter.Size = New System.Drawing.Size(140, 38)
        Me.btnConnecter.Name = "btnConnecter"

        ' btnAnnuler
        Me.btnAnnuler.Text = "Quitter"
        Me.btnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(60, 20, 20)
        Me.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100)
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.Location = New System.Drawing.Point(235, 195)
        Me.btnAnnuler.Size = New System.Drawing.Size(100, 38)
        Me.btnAnnuler.Name = "btnAnnuler"

        ' Form
        Me.ClientSize = New System.Drawing.Size(380, 270)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.lblMotDePasse)
        Me.Controls.Add(Me.txtMotDePasse)
        Me.Controls.Add(Me.btnConnecter)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Name = "frmLogin"
        Me.Text = "Connexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.BackColor = System.Drawing.Color.White
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents lblMotDePasse As System.Windows.Forms.Label
    Friend WithEvents txtMotDePasse As System.Windows.Forms.TextBox
    Friend WithEvents btnConnecter As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button

End Class