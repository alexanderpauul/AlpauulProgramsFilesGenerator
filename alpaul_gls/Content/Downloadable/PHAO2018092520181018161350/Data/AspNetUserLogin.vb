Imports System
Imports System.Data.SqlClient

Public Class AspNetUserLogins
    Public Shared Function Add(value As Models.AspNetUserLogins) As Integer
        Using cmd As New SqlCommand("dbo.AspNetUserLogins_Add", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@LoginProvider", value.LoginProvider))
         cmd.Parameters.Add(New SqlParameter("@ProviderKey", value.ProviderKey))
         cmd.Parameters.Add(New SqlParameter("@UserId", value.UserId))
         cmd.Parameters.Add(New SqlParameter("@UserId", value.UserId))



            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                Return CInt(cmd.ExecuteScalar())
            Catch ex As Exception
                Return 0
                Throw New Exception("Error: 0x0000PA")
            Finally
                If Connection.Cnn.State = ConnectionState.Open Then
                    Connection.Cnn.Close()
                End If
            End Try
        End Using
    End Function

    Public Shared Function Edit(value As Models.AspNetUserLogins) As Integer
        Using cmd As New SqlCommand("dbo.AspNetUserLogins_Edit", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@LoginProvider", value.LoginProvider))
         cmd.Parameters.Add(New SqlParameter("@ProviderKey", value.ProviderKey))
         cmd.Parameters.Add(New SqlParameter("@UserId", value.UserId))
         cmd.Parameters.Add(New SqlParameter("@UserId", value.UserId))



            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                Return cmd.ExecuteNonQuery
            Catch ex As Exception
                Return 0
                Throw New Exception("Error: 0x0000NC")
            Finally
                If Connection.Cnn.State = ConnectionState.Open Then
                    Connection.Cnn.Close()
                End If
            End Try
        End Using
    End Function

    Public Shared Function Delete(value As String) As Integer
        Using cmd As New SqlCommand("dbo.AspNetUserLogins_Delete", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                Return cmd.ExecuteNonQuery
            Catch ex As Exception
                Return 0
                Throw New Exception("Error: 0x0000NR")
            Finally
                If Connection.Cnn.State = ConnectionState.Open Then
                    Connection.Cnn.Close()
                End If
            End Try
        End Using
    End Function

    Public Shared Function GetById(value As String) As Models.AspNetUserLogins
        Using cmd As New SqlCommand("dbo.AspNetUserLogins_GetById", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.AspNetUserLogins = New Models.AspNetUserLogins

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.LoginProvider = CType(drResultado("LoginProvider"), Integer)
                registro.ProviderKey = CType(drResultado("ProviderKey"), Integer)
                registro.UserId = CType(drResultado("UserId"), Integer)
                registro.UserId = CType(drResultado("UserId"), Integer)


                End If

                Return registro
            Catch ex As Exception
                Return registro
                Throw New Exception("Error: 0x00000N", ex)
            Finally
                If Connection.Cnn.State = ConnectionState.Open Then
                    Connection.Cnn.Close()
                End If
            End Try
        End Using
    End Function

    Public Shared Function GetByGUID(value As String) As Models.AspNetUserLogins
        Using cmd As New SqlCommand("dbo.AspNetUserLogins_GetByGUID", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.AspNetUserLogins = New Models.AspNetUserLogins

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.LoginProvider = CType(drResultado("LoginProvider"), Integer)
                registro.ProviderKey = CType(drResultado("ProviderKey"), Integer)
                registro.UserId = CType(drResultado("UserId"), Integer)
                registro.UserId = CType(drResultado("UserId"), Integer)


                End If

                Return registro
            Catch ex As Exception
                Return registro
                Throw New Exception("Error: 0x00000N", ex)
            Finally
                If Connection.Cnn.State = ConnectionState.Open Then
                    Connection.Cnn.Close()
                End If
            End Try
        End Using
    End Function

    Public Shared Function GetAll() As List(Of Models.AspNetUserLogins)
        Using cmd As New SqlCommand("dbo.AspNetUserLogins_GetAll", Connection.Cnn)

            cmd.CommandType = CommandType.StoredProcedure
            Dim drResultado As IDataReader = Nothing
            Dim registros As List(Of Models.AspNetUserLogins) = New List(Of Models.AspNetUserLogins)

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                While drResultado.Read
                    Dim registro = New Models.AspNetUserLogins
                                    registro.LoginProvider = CType(drResultado("LoginProvider"), Integer)
                registro.ProviderKey = CType(drResultado("ProviderKey"), Integer)
                registro.UserId = CType(drResultado("UserId"), Integer)
                registro.UserId = CType(drResultado("UserId"), Integer)


                    registros.Add(registro)
                End While

                Return registros
            Catch ex As Exception
                Return registros
                Throw New Exception("Error: 0x00000N", ex)
            Finally
                If Connection.Cnn.State = ConnectionState.Open Then
                    Connection.Cnn.Close()
                End If
            End Try
        End Using
    End Function
End Class