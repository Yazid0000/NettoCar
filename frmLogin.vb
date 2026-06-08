Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "NETTOCAR - Connexion"
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        txtLogin.Focus()
    End Sub

    Private Sub btnConnecter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnecter.Click
        Dim login As String = txtLogin.Text.Trim()
        Dim mdp As String = txtMotDePasse.Text.Trim()

        If login = "" OrElse mdp = "" Then
            MsgBox("Veuillez saisir votre login et mot de passe.", MsgBoxStyle.Exclamation, "Champs vides")
            Exit Sub
        End If

        Dim sql As String = "SELECT u.idutilisateur, u.idemploye, u.role, e.nom, e.prenom " & _
                            "FROM utilisateur u " & _
                            "INNER JOIN employe e ON u.idemploye = e.idemploye " & _
                            "WHERE u.login = '" & login & "' AND u.motdepasse = '" & mdp & "' AND u.actif = True"

        Dim dt As DataTable = DBConnection.ExecuteQuery(sql)

        If dt.Rows.Count = 0 Then
            MsgBox("Login ou mot de passe incorrect.", MsgBoxStyle.Critical, "Accès refusé")
            txtMotDePasse.Clear()
            txtLogin.Focus()
            Exit Sub
        End If

        ' Remplir la session globale
        AppSession.IdEmployeConnecte = CInt(dt.Rows(0)("idemploye"))
        AppSession.NomEmployeConnecte = dt.Rows(0)("prenom").ToString() & " " & dt.Rows(0)("nom").ToString()
        AppSession.RoleConnecte = dt.Rows(0)("role").ToString()

        ' Journaliser la connexion
        DBConnection.JournaliserEvenement("CONNEXION", AppSession.IdEmployeConnecte, 0, _
            "Connexion de " & AppSession.NomEmployeConnecte & " (role: " & AppSession.RoleConnecte & ")")

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click
        Application.Exit()
    End Sub

    Private Sub txtMotDePasse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMotDePasse.KeyDown
        If e.KeyCode = Keys.Enter Then btnConnecter_Click(sender, e)
    End Sub

End Class