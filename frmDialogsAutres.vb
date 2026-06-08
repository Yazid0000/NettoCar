' ============================================================
'  frmDialogClient.vb
' ============================================================
Public Class frmDialogClient

    Private _isModif As Boolean
    Private _id As Integer

    Public Sub New(ByVal isModif As Boolean, ByVal id As Integer)
        InitializeComponent()
        _isModif = isModif
        _id = id
    End Sub

    Private Sub frmDialogClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _isModif Then
            btnAction.Text = "Modifier"
            Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT * FROM client WHERE idclient = " & _id)
            If dt.Rows.Count > 0 Then
                txtId.Text = dt.Rows(0)("idclient").ToString()
                txtNom.Text = dt.Rows(0)("nom").ToString()
                txtTelephone.Text = dt.Rows(0)("telephone").ToString()
                txtEmail.Text = dt.Rows(0)("email").ToString()
                txtAdresse.Text = dt.Rows(0)("adresse").ToString()
                txtVille.Text = dt.Rows(0)("ville").ToString()
                If dt.Rows(0)("dateinscription") IsNot DBNull.Value Then
                    dtpInscription.Value = CDate(dt.Rows(0)("dateinscription"))
                End If
            End If
        Else
            btnAction.Text = "Ajouter"
            dtpInscription.Value = Date.Today
        End If
    End Sub

    Private Sub btnAction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAction.Click
        If txtNom.Text.Trim() = "" Then
            MsgBox("Le nom est obligatoire.", MsgBoxStyle.Exclamation, "Validation")
            txtNom.Focus() : Exit Sub
        End If
        Dim params As New List(Of OleDb.OleDbParameter)
        params.Add(New OleDb.OleDbParameter("@nom", txtNom.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@tel", txtTelephone.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@email", txtEmail.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@adr", txtAdresse.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@ville", txtVille.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@date", dtpInscription.Value.Date))
        Dim sql As String
        If _isModif Then
            sql = "UPDATE client SET nom=?, telephone=?, email=?, adresse=?, ville=?, dateinscription=? WHERE idclient=?"
            params.Add(New OleDb.OleDbParameter("@id", _id))
        Else
            Dim newIdClient As Integer = DBConnection.GetNextId("client", "idclient")
            sql = "INSERT INTO client (idclient, nom, telephone, email, adresse, ville, dateinscription) VALUES (?,?,?,?,?,?,?)"
            params.Insert(0, New OleDb.OleDbParameter("@idnew", newIdClient))
        End If
        If DBConnection.ExecuteNonQuery(sql, params) Then
            MsgBox("Opération réussie !", MsgBoxStyle.Information, "Succès")
            Me.Close()
        End If
    End Sub

End Class


' ============================================================
'  frmDialogService.vb
' ============================================================
Public Class frmDialogService

    Private _isModif As Boolean
    Private _id As String

    Public Sub New(ByVal isModif As Boolean, ByVal id As String)
        InitializeComponent()
        _isModif = isModif
        _id = id
    End Sub

    Private Sub frmDialogService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _isModif Then
            btnAction.Text = "Modifier"
            Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT * FROM service WHERE idservice = '" & _id & "'")
            If dt.Rows.Count > 0 Then
                txtId.Text = dt.Rows(0)("idservice").ToString()
                txtNomService.Text = dt.Rows(0)("nomservice").ToString()
                txtDescription.Text = dt.Rows(0)("description").ToString()
                txtPrix.Text = dt.Rows(0)("prix").ToString()
                txtDuree.Text = dt.Rows(0)("dureeestimee").ToString()
            End If
        Else
            btnAction.Text = "Ajouter"
        End If
    End Sub

    Private Sub btnAction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAction.Click
        If txtNomService.Text.Trim() = "" Then
            MsgBox("Le nom du service est obligatoire.", MsgBoxStyle.Exclamation, "Validation")
            txtNomService.Focus() : Exit Sub
        End If
        Dim params As New List(Of OleDb.OleDbParameter)
        Dim prix As Decimal = 0 : Dim duree As Integer = 0
        Decimal.TryParse(txtPrix.Text.Replace(",", "."), prix)
        Integer.TryParse(txtDuree.Text, duree)
        params.Add(New OleDb.OleDbParameter("@nom", txtNomService.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@desc", txtDescription.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@prix", prix))
        params.Add(New OleDb.OleDbParameter("@dur", duree))
        Dim sql As String
        If _isModif Then
            sql = "UPDATE service SET nomservice=?, description=?, prix=?, dureeestimee=? WHERE idservice=?"
            params.Add(New OleDb.OleDbParameter("@id", _id))
        Else
            Dim lastId As Object = DBConnection.ExecuteScalar("SELECT MAX(idservice) FROM service")
            Dim newNum As Integer = 1
            If lastId IsNot Nothing AndAlso lastId IsNot DBNull.Value Then
                Dim lastStr As String = lastId.ToString().Replace("S", "")
                Integer.TryParse(lastStr, newNum)
                newNum += 1
            End If
            Dim newIdService As String = "S" & newNum.ToString("00")
            params.Insert(0, New OleDb.OleDbParameter("@idnew", newIdService))
            sql = "INSERT INTO service (idservice, nomservice, description, prix, dureeestimee) VALUES (?,?,?,?,?)"
        End If
        If DBConnection.ExecuteNonQuery(sql, params) Then
            MsgBox("Opération réussie !", MsgBoxStyle.Information, "Succès")
            Me.Close()
        End If
    End Sub

End Class


' ============================================================
'  frmDialogProduit.vb
' ============================================================
Public Class frmDialogProduit

    Private _isModif As Boolean
    Private _id As Integer

    Public Sub New(ByVal isModif As Boolean, ByVal id As Integer)
        InitializeComponent()
        _isModif = isModif
        _id = id
    End Sub

    Private Sub frmDialogProduit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _isModif Then
            btnAction.Text = "Modifier"
            Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT * FROM produit WHERE idproduit = " & _id)
            If dt.Rows.Count > 0 Then
                txtId.Text = dt.Rows(0)("idproduit").ToString()
                txtNomProduit.Text = dt.Rows(0)("nomproduit").ToString()
                txtDescription.Text = dt.Rows(0)("description").ToString()
                txtPrixAchat.Text = dt.Rows(0)("prixachat").ToString()
                txtQuantite.Text = dt.Rows(0)("quantite").ToString()
                txtSeuilAlerte.Text = dt.Rows(0)("seuilalerte").ToString()
            End If
        Else
            btnAction.Text = "Ajouter"
        End If
    End Sub

    Private Sub btnAction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAction.Click
        If txtNomProduit.Text.Trim() = "" Then
            MsgBox("Le nom du produit est obligatoire.", MsgBoxStyle.Exclamation, "Validation")
            txtNomProduit.Focus() : Exit Sub
        End If
        Dim params As New List(Of OleDb.OleDbParameter)
        Dim prix As Decimal = 0 : Dim qte As Integer = 0 : Dim seuil As Integer = 0
        Decimal.TryParse(txtPrixAchat.Text.Replace(",", "."), prix)
        Integer.TryParse(txtQuantite.Text, qte)
        Integer.TryParse(txtSeuilAlerte.Text, seuil)
        params.Add(New OleDb.OleDbParameter("@nom", txtNomProduit.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@desc", txtDescription.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@prix", prix))
        params.Add(New OleDb.OleDbParameter("@qte", qte))
        params.Add(New OleDb.OleDbParameter("@seuil", seuil))
        Dim sql As String
        If _isModif Then
            sql = "UPDATE produit SET nomproduit=?, description=?, prixachat=?, quantite=?, seuilalerte=? WHERE idproduit=?"
            params.Add(New OleDb.OleDbParameter("@id", _id))
        Else
            Dim newIdProduit As Integer = DBConnection.GetNextId("produit", "idproduit")
            sql = "INSERT INTO produit (idproduit, nomproduit, description, prixachat, quantite, seuilalerte) VALUES (?,?,?,?,?,?)"
            params.Insert(0, New OleDb.OleDbParameter("@idnew", newIdProduit))
        End If
        If DBConnection.ExecuteNonQuery(sql, params) Then
            MsgBox("Opération réussie !", MsgBoxStyle.Information, "Succès")
            Me.Close()
        End If
    End Sub

End Class


' ============================================================
'  frmDialogFournisseur.vb
' ============================================================
Public Class frmDialogFournisseur

    Private _isModif As Boolean
    Private _id As Integer

    Public Sub New(ByVal isModif As Boolean, ByVal id As Integer)
        InitializeComponent()
        _isModif = isModif
        _id = id
    End Sub

    Private Sub frmDialogFournisseur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _isModif Then
            btnAction.Text = "Modifier"
            Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT * FROM fournisseur WHERE id_fournisseur = " & _id)
            If dt.Rows.Count > 0 Then
                txtId.Text = dt.Rows(0)("id_fournisseur").ToString()
                txtRaisonSociale.Text = dt.Rows(0)("raison_sociale").ToString()
                txtInterlocuteur.Text = dt.Rows(0)("interlocuteur").ToString()
                txtVille.Text = dt.Rows(0)("ville").ToString()
                txtPays.Text = dt.Rows(0)("pays").ToString()
                txtTelephone.Text = dt.Rows(0)("telephone").ToString()
                txtEmail.Text = dt.Rows(0)("email").ToString()
            End If
        Else
            btnAction.Text = "Ajouter"
        End If
    End Sub

    Private Sub btnAction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAction.Click
        If txtRaisonSociale.Text.Trim() = "" Then
            MsgBox("La raison sociale est obligatoire.", MsgBoxStyle.Exclamation, "Validation")
            txtRaisonSociale.Focus() : Exit Sub
        End If
        Dim params As New List(Of OleDb.OleDbParameter)
        params.Add(New OleDb.OleDbParameter("@rs", txtRaisonSociale.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@il", txtInterlocuteur.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@ville", txtVille.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@pays", txtPays.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@tel", txtTelephone.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@email", txtEmail.Text.Trim()))
        Dim sql As String
        If _isModif Then
            sql = "UPDATE fournisseur SET raison_sociale=?, interlocuteur=?, ville=?, pays=?, telephone=?, email=? WHERE id_fournisseur=?"
            params.Add(New OleDb.OleDbParameter("@id", _id))
        Else
            sql = "INSERT INTO fournisseur (raison_sociale, interlocuteur, ville, pays, telephone, email) VALUES (?,?,?,?,?,?)"
        End If
        If DBConnection.ExecuteNonQuery(sql, params) Then
            MsgBox("Opération réussie !", MsgBoxStyle.Information, "Succès")
            Me.Close()
        End If
    End Sub

End Class


' ============================================================
'  frmDialogEmploye.vb
' ============================================================
Public Class frmDialogEmploye

    Private _isModif As Boolean
    Private _id As Integer
    Private _cheminPhoto As String = ""

    Public Sub New(ByVal isModif As Boolean, ByVal id As Integer)
        InitializeComponent()
        _isModif = isModif
        _id = id
    End Sub

    Private Sub frmDialogEmploye_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Charger combo agences
        Dim dtA As DataTable = DBConnection.ExecuteQuery("SELECT idagence, nomagence FROM agence ORDER BY nomagence")
        cmbAgence.DataSource = dtA
        cmbAgence.DisplayMember = "nomagence"
        cmbAgence.ValueMember = "idagence"
        cmbAgence.SelectedIndex = -1

        If _isModif Then
            btnAction.Text = "Modifier"
            Dim dt As DataTable = DBConnection.ExecuteQuery("SELECT * FROM employe WHERE idemploye = " & _id)
            If dt.Rows.Count > 0 Then
                txtId.Text = dt.Rows(0)("idemploye").ToString()
                txtNom.Text = dt.Rows(0)("nom").ToString()
                txtPrenom.Text = dt.Rows(0)("prenom").ToString()
                txtPoste.Text = dt.Rows(0)("poste").ToString()
                txtSalaire.Text = dt.Rows(0)("salaire").ToString()
                If dt.Rows(0)("dateembauche") IsNot DBNull.Value Then
                    dtpEmbauche.Value = CDate(dt.Rows(0)("dateembauche"))
                End If
                If dt.Rows(0)("idagence") IsNot DBNull.Value Then
                    cmbAgence.SelectedValue = dt.Rows(0)("idagence")
                End If
                If dt.Rows(0)("photo") IsNot DBNull.Value AndAlso dt.Rows(0)("photo").ToString() <> "" Then
                    _cheminPhoto = dt.Rows(0)("photo").ToString()
                    AfficherPhoto(_cheminPhoto)
                End If
            End If
        Else
            btnAction.Text = "Ajouter"
            dtpEmbauche.Value = Date.Today
        End If
    End Sub

    Private Sub AfficherPhoto(ByVal chemin As String)
        If chemin <> "" AndAlso System.IO.File.Exists(chemin) Then
            Try
                picPhoto.Image = System.Drawing.Image.FromFile(chemin)
                picPhoto.BackColor = System.Drawing.Color.White
            Catch
                picPhoto.Image = Nothing
                picPhoto.BackColor = System.Drawing.Color.LightGray
            End Try
        Else
            picPhoto.Image = Nothing
            picPhoto.BackColor = System.Drawing.Color.LightGray
        End If
    End Sub

    Private Sub btnChoisirPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoisirPhoto.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Choisir une photo"
            ofd.Filter = "Images (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                _cheminPhoto = ofd.FileName
                AfficherPhoto(_cheminPhoto)
            End If
        End Using
    End Sub

    Private Sub btnAction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAction.Click
        If txtNom.Text.Trim() = "" OrElse txtPoste.Text.Trim() = "" Then
            MsgBox("Nom et poste sont obligatoires.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If
        Dim params As New List(Of OleDb.OleDbParameter)
        Dim salaire As Decimal = 0
        Decimal.TryParse(txtSalaire.Text.Replace(",", "."), salaire)
        Dim idAgence As Object = If(cmbAgence.SelectedValue IsNot Nothing, cmbAgence.SelectedValue, DBNull.Value)
        Dim photoVal As Object = If(_cheminPhoto <> "", _cheminPhoto, DBNull.Value)

        params.Add(New OleDb.OleDbParameter("@nom", txtNom.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@prenom", txtPrenom.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@poste", txtPoste.Text.Trim()))
        params.Add(New OleDb.OleDbParameter("@sal", salaire))
        params.Add(New OleDb.OleDbParameter("@date", dtpEmbauche.Value.Date))
        params.Add(New OleDb.OleDbParameter("@ag", idAgence))
        params.Add(New OleDb.OleDbParameter("@photo", photoVal))

        Dim sql As String
        If _isModif Then
            sql = "UPDATE employe SET nom=?, prenom=?, poste=?, salaire=?, dateembauche=?, idagence=?, photo=? WHERE idemploye=?"
            params.Add(New OleDb.OleDbParameter("@id", _id))
        Else
            Dim newIdEmploye As Integer = DBConnection.GetNextId("employe", "idemploye")
            sql = "INSERT INTO employe (idemploye, nom, prenom, poste, salaire, dateembauche, idagence, photo) VALUES (?,?,?,?,?,?,?,?)"
            params.Insert(0, New OleDb.OleDbParameter("@idnew", newIdEmploye))
        End If
        If DBConnection.ExecuteNonQuery(sql, params) Then
            MsgBox("Opération réussie !", MsgBoxStyle.Information, "Succès")
            Me.Close()
        End If
    End Sub

End Class
