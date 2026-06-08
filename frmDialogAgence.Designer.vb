<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogAgence
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.lblResponsable = New System.Windows.Forms.Label()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.btnAction = New System.Windows.Forms.Button()
        Me.SuspendLayout()

        Dim LF As New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold)
        Dim LC As System.Drawing.Color = System.Drawing.Color.FromArgb(80, 80, 80)
        Dim TF As New System.Drawing.Font("Microsoft Sans Serif", 10.0!)

        ' ── ID AGENCE (Y=25) ──
        Me.lblId.Text = "ID AGENCE"
        Me.lblId.Font = LF
        Me.lblId.ForeColor = LC
        Me.lblId.Location = New System.Drawing.Point(30, 25)
        Me.lblId.Size = New System.Drawing.Size(130, 22)
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblId.Name = "lblId"
        Me.txtId.Font = TF
        Me.txtId.Location = New System.Drawing.Point(170, 25)
        Me.txtId.Size = New System.Drawing.Size(320, 26)
        Me.txtId.ReadOnly = True
        Me.txtId.BackColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.txtId.ForeColor = System.Drawing.Color.White
        Me.txtId.Name = "txtId"

        ' ── NOM AGENCE (Y=71) ──
        Me.lblNom.Text = "NOM AGENCE"
        Me.lblNom.Font = LF
        Me.lblNom.ForeColor = LC
        Me.lblNom.Location = New System.Drawing.Point(30, 71)
        Me.lblNom.Size = New System.Drawing.Size(130, 22)
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNom.Name = "lblNom"
        Me.txtNom.Font = TF
        Me.txtNom.Location = New System.Drawing.Point(170, 71)
        Me.txtNom.Size = New System.Drawing.Size(320, 26)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.TabIndex = 1

        ' ── ADRESSE (Y=117) ──
        Me.lblAdresse.Text = "ADRESSE"
        Me.lblAdresse.Font = LF
        Me.lblAdresse.ForeColor = LC
        Me.lblAdresse.Location = New System.Drawing.Point(30, 117)
        Me.lblAdresse.Size = New System.Drawing.Size(130, 22)
        Me.lblAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAdresse.Name = "lblAdresse"
        Me.txtAdresse.Font = TF
        Me.txtAdresse.Location = New System.Drawing.Point(170, 117)
        Me.txtAdresse.Size = New System.Drawing.Size(320, 26)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.TabIndex = 2

        ' ── TELEPHONE (Y=163) ──
        Me.lblTel.Text = "TELEPHONE"
        Me.lblTel.Font = LF
        Me.lblTel.ForeColor = LC
        Me.lblTel.Location = New System.Drawing.Point(30, 163)
        Me.lblTel.Size = New System.Drawing.Size(130, 22)
        Me.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTel.Name = "lblTel"
        Me.txtTel.Font = TF
        Me.txtTel.Location = New System.Drawing.Point(170, 163)
        Me.txtTel.Size = New System.Drawing.Size(320, 26)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.TabIndex = 3

        ' ── RESPONSABLE (Y=209) ──
        Me.lblResponsable.Text = "RESPONSABLE"
        Me.lblResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblResponsable.ForeColor = LC
        Me.lblResponsable.Location = New System.Drawing.Point(30, 209)
        Me.lblResponsable.Size = New System.Drawing.Size(140, 36)
        Me.lblResponsable.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblResponsable.Name = "lblResponsable"
        Me.txtResponsable.Font = TF
        Me.txtResponsable.Location = New System.Drawing.Point(170, 209)
        Me.txtResponsable.Size = New System.Drawing.Size(320, 26)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.TabIndex = 4

        ' ── Bouton rouge (Y=275) ──
        Me.btnAction.Text = "Ajouter"
        Me.btnAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAction.BackColor = System.Drawing.Color.FromArgb(200, 40, 40)
        Me.btnAction.ForeColor = System.Drawing.Color.White
        Me.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAction.FlatAppearance.BorderSize = 0
        Me.btnAction.Size = New System.Drawing.Size(120, 38)
        Me.btnAction.Location = New System.Drawing.Point(370, 275)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.TabIndex = 5
        Me.btnAction.UseVisualStyleBackColor = False
        Me.btnAction.Cursor = System.Windows.Forms.Cursors.Hand

        ' ── Formulaire ──
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 330)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.lblResponsable)
        Me.Controls.Add(Me.txtResponsable)
        Me.Controls.Add(Me.btnAction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.BackColor = System.Drawing.Color.FromArgb(245, 245, 245)
        Me.Name = "frmDialogAgence"
        Me.Text = "NETTOCAR - GESTION DES AGENCES"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblAdresse As System.Windows.Forms.Label
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents lblResponsable As System.Windows.Forms.Label
    Friend WithEvents txtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents btnAction As System.Windows.Forms.Button

End Class
