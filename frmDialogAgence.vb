' ============================================================
'  frmDialogAgence.vb  –  Dialogue Ajouter/Modifier agence
' ============================================================
Public Class frmDialogAgence

    Private _isModif As Boolean
    Private _id As Integer

    Public Sub New(ByVal isModif As Boolean, ByVal id As Integer)
        InitializeComponent()
        _isModif = isModif
        _id = id
    End Sub

    Private Sub frmDialogAgence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _isModif Then
            Me.Text = "NETTOCAR - MODIFIER UNE AGENCE"
            btnAction.Text = "Modifier"
            Me.Text = "NETTOCAR- GESTION DES AGENCES"
            ' Charger les données existantes
            Dim sql As String = "SELECT * FROM agence WHERE idagence = ?"
            Dim params As New List(Of OleDb.OleDbParameter)
            params.Add(New OleDb.OleDbParameter("@id", _id))
            Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT * FROM agence WHERE idagence = " & _id)
            If dt.Rows.Count > 0 Then
                txtId.Text = dt.Rows(0)("idagence").ToString()
                txtNom.Text = dt.Rows(0)("nomagence").ToString()
                txtAdresse.Text = dt.Rows(0)("adresse").ToString()
                txtTel.Text = dt.Rows(0)("tel").ToString()
                txtResponsable.Text = dt.Rows(0)("responsable").ToString()
            End If
        Else
            Me.Text = "NETTOCAR- GESTION DES AGENCES"
            btnAction.Text = "Ajouter"
        End If
    End Sub

    Private Sub btnAction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAction.Click
        If txtNom.Text.Trim() = "" Then
            MsgBox("Le nom de l'agence est obligatoire.", MsgBoxStyle.Exclamation, "Validation")
            txtNom.Focus()
            Exit Sub
        End If

        Dim sql As String
        Dim params As New List(Of OleDb.OleDbParameter)
        Dim newId As Integer = 0

        If _isModif Then
            sql = "UPDATE agence SET nomagence=?, adresse=?, tel=?, responsable=? WHERE idagence=?"
        Else
            newId = DBConnection.GetNextId("agence", "idagence")
            sql = "INSERT INTO agence (idagence, nomagence, adresse, tel, responsable) VALUES (?, ?, ?, ?, ?)"
        End If

        If Not _isModif Then params.Add(New OleDb.OleDbParameter("@idnew", newId))
        params.Add(New OleDb.OleDbParameter("@nom", txtNom.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@adr", txtAdresse.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@tel", txtTel.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@resp", txtResponsable.Text.Trim()))
        If _isModif Then params.Add(New OleDb.OleDbParameter("@id", _id))

        If DBConnection.ExecuteNonQuery(sql, params) Then
            MsgBox("Opération réussie !", MsgBoxStyle.Information, "Succès")
            Me.Close()
        End If
    End Sub

End Class
