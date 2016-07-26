
Public MustInherit Class Animal
    Implements Hablante


    Public nombre As String
    Public edad As Byte
    Public raza As String
    Public Color As String
    Public peso As Decimal

    Sub New(ByVal nombre As String, ByVal edad As Byte)
        Me.nombre = nombre
        Me.edad = edad
    End Sub

    Public MustOverride Sub Comer()

    Public Sub irAlBanio()

    End Sub

    Public Overridable Sub correr()
        MsgBox("Estoy corriendo")
    End Sub

    Public Overridable Sub hablar() Implements Hablante.hablar
        MsgBox("Miau")
    End Sub
   
End Class
