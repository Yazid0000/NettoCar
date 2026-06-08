Imports System.Data.OleDb
Imports System.Data

Public Class DBConnection
    Private Shared connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\syspaie.mdb"

    Public Shared Function GetConnection() As OleDbConnection
        Return New OleDbConnection(connString)
    End Function

    Public Shared Function ExecuteQuery(ByVal sql As String) As DataTable
        Dim dt As New DataTable()
        Using conn As OleDbConnection = GetConnection()
            Try
                Dim da As New OleDbDataAdapter(sql, conn)
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("Erreur de lecture : " & ex.Message, MsgBoxStyle.Critical, "Erreur")
            End Try
        End Using
        Return dt
    End Function

    Public Shared Function ExecuteNonQuery(ByVal sql As String, ByVal params As List(Of OleDbParameter)) As Boolean
        Using conn As OleDbConnection = GetConnection()
            Try
                Dim cmd As New OleDbCommand(sql, conn)
                conn.Open()
                If params IsNot Nothing Then
                    For Each p As OleDbParameter In params
                        cmd.Parameters.Add(p)
                    Next
                End If
                cmd.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                MsgBox("Erreur d'écriture : " & ex.Message, MsgBoxStyle.Critical, "Erreur")
                Return False
            End Try
        End Using
    End Function

    Public Shared Function ExecuteScalar(ByVal sql As String) As Object
        Using conn As OleDbConnection = GetConnection()
            Try
                Dim cmd As New OleDbCommand(sql, conn)
                conn.Open()
                Return cmd.ExecuteScalar()
            Catch ex As Exception
                MsgBox("Erreur scalaire : " & ex.Message, MsgBoxStyle.Critical, "Erreur")
                Return Nothing
            End Try
        End Using
    End Function

    ' Génère le prochain ID pour les tables dont l'id n'est pas NuméroAuto
    Public Shared Function GetNextId(ByVal table As String, ByVal champId As String) As Integer
        Dim sql As String = "SELECT MAX(" & champId & ") FROM " & table
        Dim result As Object = ExecuteScalar(sql)
        If result Is Nothing OrElse result Is DBNull.Value Then
            Return 1
        End If
        Dim maxId As Integer = 0
        Integer.TryParse(result.ToString(), maxId)
        Return maxId + 1
    End Function

    Public Shared Sub JournaliserEvenement(ByVal typeEvt As String, _
                                        ByVal idEmploye As Integer, _
                                        ByVal idLavage As Integer, _
                                        ByVal description As String)
        Try
            Using conn As OleDbConnection = GetConnection()
                conn.Open()
                Dim sql As String
                Dim cmd As New OleDbCommand("", conn)

                Dim p1 As New OleDbParameter("@date", OleDb.OleDbType.Date)
                p1.Value = Date.Now
                Dim p2 As New OleDbParameter("@type", OleDb.OleDbType.VarChar)
                p2.Value = typeEvt
                Dim p3 As New OleDbParameter("@desc", OleDb.OleDbType.VarChar)
                p3.Value = description

                If idEmploye > 0 AndAlso idLavage > 0 Then
                    sql = "INSERT INTO journal_evenements (dateevt, typeevt, description, idemploye, idlavage) VALUES (?,?,?,?,?)"
                    Dim p4 As New OleDbParameter("@emp", OleDb.OleDbType.Integer)
                    p4.Value = idEmploye
                    Dim p5 As New OleDbParameter("@lav", OleDb.OleDbType.Integer)
                    p5.Value = idLavage
                    cmd.Parameters.Add(p1) : cmd.Parameters.Add(p2) : cmd.Parameters.Add(p3)
                    cmd.Parameters.Add(p4) : cmd.Parameters.Add(p5)
                ElseIf idEmploye > 0 Then
                    sql = "INSERT INTO journal_evenements (dateevt, typeevt, description, idemploye) VALUES (?,?,?,?)"
                    Dim p4 As New OleDbParameter("@emp", OleDb.OleDbType.Integer)
                    p4.Value = idEmploye
                    cmd.Parameters.Add(p1) : cmd.Parameters.Add(p2) : cmd.Parameters.Add(p3)
                    cmd.Parameters.Add(p4)
                ElseIf idLavage > 0 Then
                    sql = "INSERT INTO journal_evenements (dateevt, typeevt, description, idlavage) VALUES (?,?,?,?)"
                    Dim p4 As New OleDbParameter("@lav", OleDb.OleDbType.Integer)
                    p4.Value = idLavage
                    cmd.Parameters.Add(p1) : cmd.Parameters.Add(p2) : cmd.Parameters.Add(p3)
                    cmd.Parameters.Add(p4)
                Else
                    sql = "INSERT INTO journal_evenements (dateevt, typeevt, description) VALUES (?,?,?)"
                    cmd.Parameters.Add(p1) : cmd.Parameters.Add(p2) : cmd.Parameters.Add(p3)
                End If

                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Erreur journal : " & ex.Message, MsgBoxStyle.Critical, "Erreur")
        End Try
    End Sub

End Class
Public Module AppSession
    Public IdEmployeConnecte As Integer = 0
    Public NomEmployeConnecte As String = ""
    Public RoleConnecte As String = ""
End Module

Public Module Demarrage
    Public Sub Main()
        Dim login As New frmLogin()
        If login.ShowDialog() = DialogResult.OK Then
            Application.Run(New frmMain())
        Else
            Application.Exit()
        End If
    End Sub
End Module