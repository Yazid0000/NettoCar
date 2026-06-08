<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogLavage
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
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()

        ' lblTitre
        Me.lblTitre.Text = "Nouveau Lavage"
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitre.ForeColor = System.Drawing.Color.FromArgb(25, 70, 155)
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTitre.Location = New System.Drawing.Point(0, 15)
        Me.lblTitre.Size = New System.Drawing.Size(420, 40)
        Me.lblTitre.Name = "lblTitre"

        ' lblClient
        Me.lblClient.Text = "Client :"
        Me.lblClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblClient.Location = New System.Drawing.Point(30, 75)
        Me.lblClient.Size = New System.Drawing.Size(100, 24)
        Me.lblClient.Name = "lblClient"

        ' cboClient
        Me.cboClient.Location = New System.Drawing.Point(140, 73)
        Me.cboClient.Size = New System.Drawing.Size(250, 24)
        Me.cboClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboClient.Name = "cboClient"

        ' lblService
        Me.lblService.Text = "Service :"
        Me.lblService.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblService.Location = New System.Drawing.Point(30, 115)
        Me.lblService.Size = New System.Drawing.Size(100, 24)
        Me.lblService.Name = "lblService"

        ' cboService
        Me.cboService.Location = New System.Drawing.Point(140, 113)
        Me.cboService.Size = New System.Drawing.Size(250, 24)
        Me.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboService.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboService.Name = "cboService"

        ' lblDate
        Me.lblDate.Text = "Date :"
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.Location = New System.Drawing.Point(30, 155)
        Me.lblDate.Size = New System.Drawing.Size(100, 24)
        Me.lblDate.Name = "lblDate"

        ' dtpDate
        Me.dtpDate.Location = New System.Drawing.Point(140, 153)
        Me.dtpDate.Size = New System.Drawing.Size(250, 24)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDate.Name = "dtpDate"

        ' lblHeure
        Me.lblHeure.Text = "Heure début :"
        Me.lblHeure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeure.Location = New System.Drawing.Point(30, 195)
        Me.lblHeure.Size = New System.Drawing.Size(100, 24)
        Me.lblHeure.Name = "lblHeure"

        ' txtHeureDeb
        Me.txtHeureDeb.Location = New System.Drawing.Point(140, 193)
        Me.txtHeureDeb.Size = New System.Drawing.Size(100, 24)
        Me.txtHeureDeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtHeureDeb.Name = "txtHeureDeb"

        ' lblMontant
        Me.lblMontant.Text = "Montant (DH) :"
        Me.lblMontant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMontant.Location = New System.Drawing.Point(30, 235)
        Me.lblMontant.Size = New System.Drawing.Size(100, 24)
        Me.lblMontant.Name = "lblMontant"

        ' txtMontant
        Me.txtMontant.Location = New System.Drawing.Point(140, 233)
        Me.txtMontant.Size = New System.Drawing.Size(100, 24)
        Me.txtMontant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtMontant.ReadOnly = True
        Me.txtMontant.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtMontant.Name = "txtMontant"

        ' lblObservations
        Me.lblObservations.Text = "Observations :"
        Me.lblObservations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblObservations.Location = New System.Drawing.Point(30, 275)
        Me.lblObservations.Size = New System.Drawing.Size(100, 24)
        Me.lblObservations.Name = "lblObservations"

        ' txtObservations
        Me.txtObservations.Location = New System.Drawing.Point(140, 273)
        Me.txtObservations.Size = New System.Drawing.Size(250, 60)
        Me.txtObservations.Multiline = True
        Me.txtObservations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtObservations.Name = "txtObservations"

        ' btnCommencer
        Me.btnCommencer.Text = "Démarrer le lavage"
        Me.btnCommencer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCommencer.BackColor = System.Drawing.Color.FromArgb(25, 70, 155)
        Me.btnCommencer.ForeColor = System.Drawing.Color.White
        Me.btnCommencer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommencer.Location = New System.Drawing.Point(80, 360)
        Me.btnCommencer.Size = New System.Drawing.Size(160, 38)
        Me.btnCommencer.Name = "btnCommencer"

        ' btnAnnuler
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(60, 20, 20)
        Me.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100)
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.Location = New System.Drawing.Point(255, 360)
        Me.btnAnnuler.Size = New System.Drawing.Size(100, 38)
        Me.btnAnnuler.Name = "btnAnnuler"

        ' Form
        Me.ClientSize = New System.Drawing.Size(420, 420)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.cboClient)
        Me.Controls.Add(Me.lblService)
        Me.Controls.Add(Me.cboService)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblHeure)
        Me.Controls.Add(Me.txtHeureDeb)
        Me.Controls.Add(Me.lblMontant)
        Me.Controls.Add(Me.txtMontant)
        Me.Controls.Add(Me.lblObservations)
        Me.Controls.Add(Me.txtObservations)
        Me.Controls.Add(Me.btnCommencer)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Name = "frmDialogLavage"
        Me.Text = "Nouveau Lavage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.BackColor = System.Drawing.Color.White
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitre As System.Windows.Forms.Label
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
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button

End Class