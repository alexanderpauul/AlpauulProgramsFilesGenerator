Imports System
Imports System.Data.SqlClient

Public Class Estados
    Public Shared Function Add(value As Models.Estados) As Integer
        Using cmd As New SqlCommand("dbo.Estados_Add", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@EstadoId", value.EstadoId))
         cmd.Parameters.Add(New SqlParameter("@TEstadoId", value.TEstadoId))
         cmd.Parameters.Add(New SqlParameter("@DscEstado", value.DscEstado))
         cmd.Parameters.Add(New SqlParameter("@Habilitado", value.Habilitado))
         cmd.Parameters.Add(New SqlParameter("@UserId", value.UserId))
         cmd.Parameters.Add(New SqlParameter("@Registro", value.Registro))
         cmd.Parameters.Add(New SqlParameter("@Modificacion", value.Modificacion))
         cmd.Parameters.Add(New SqlParameter("@Identificador", value.Identificador))



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

    Public Shared Function Edit(value As Models.Estados) As Integer
        Using cmd As New SqlCommand("dbo.Estados_Edit", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@EstadoId", value.EstadoId))
         cmd.Parameters.Add(New SqlParameter("@TEstadoId", value.TEstadoId))
         cmd.Parameters.Add(New SqlParameter("@DscEstado", value.DscEstado))
         cmd.Parameters.Add(New SqlParameter("@Habilitado", value.Habilitado))
         cmd.Parameters.Add(New SqlParameter("@UserId", value.UserId))
         cmd.Parameters.Add(New SqlParameter("@Registro", value.Registro))
         cmd.Parameters.Add(New SqlParameter("@Modificacion", value.Modificacion))
         cmd.Parameters.Add(New SqlParameter("@Identificador", value.Identificador))



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
        Using cmd As New SqlCommand("dbo.Estados_Delete", Connection.Cnn)
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

    Public Shared Function GetById(value As String) As Models.Estados
        Using cmd As New SqlCommand("dbo.Estados_GetById", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.Estados = New Models.Estados

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.EstadoId = CType(drResultado("EstadoId"), Integer)
                registro.TEstadoId = CType(drResultado("TEstadoId"), Integer)
                registro.DscEstado = CType(drResultado("DscEstado"), Integer)
                registro.Habilitado = CType(drResultado("Habilitado"), Integer)
                registro.UserId = CType(drResultado("UserId"), Integer)
                registro.Registro = CType(drResultado("Registro"), Integer)
                registro.Modificacion = CType(drResultado("Modificacion"), Integer)
                registro.Identificador = CType(drResultado("Identificador"), Integer)


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

    Public Shared Function GetByGUID(value As String) As Models.Estados
        Using cmd As New SqlCommand("dbo.Estados_GetByGUID", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.Estados = New Models.Estados

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.EstadoId = CType(drResultado("EstadoId"), Integer)
                registro.TEstadoId = CType(drResultado("TEstadoId"), Integer)
                registro.DscEstado = CType(drResultado("DscEstado"), Integer)
                registro.Habilitado = CType(drResultado("Habilitado"), Integer)
                registro.UserId = CType(drResultado("UserId"), Integer)
                registro.Registro = CType(drResultado("Registro"), Integer)
                registro.Modificacion = CType(drResultado("Modificacion"), Integer)
                registro.Identificador = CType(drResultado("Identificador"), Integer)


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

    Public Shared Function GetAll() As List(Of Models.Estados)
        Using cmd As New SqlCommand("dbo.Estados_GetAll", Connection.Cnn)

            cmd.CommandType = CommandType.StoredProcedure
            Dim drResultado As IDataReader = Nothing
            Dim registros As List(Of Models.Estados) = New List(Of Models.Estados)

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                While drResultado.Read
                    Dim registro = New Models.Estados
                                    registro.EstadoId = CType(drResultado("EstadoId"), Integer)
                registro.TEstadoId = CType(drResultado("TEstadoId"), Integer)
                registro.DscEstado = CType(drResultado("DscEstado"), Integer)
                registro.Habilitado = CType(drResultado("Habilitado"), Integer)
                registro.UserId = CType(drResultado("UserId"), Integer)
                registro.Registro = CType(drResultado("Registro"), Integer)
                registro.Modificacion = CType(drResultado("Modificacion"), Integer)
                registro.Identificador = CType(drResultado("Identificador"), Integer)


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