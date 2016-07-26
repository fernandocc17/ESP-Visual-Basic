Public Class Gato
    Inherits Animal

    Public vidasVividas As Byte

    Public colorOjos As String
    Public pedigree As String
    Private pata As Byte

    Sub New(ByVal nombre As String, ByVal raza As String, ByVal edad As Byte)
        MyBase.New(nombre, edad)
        Me.raza = raza
    End Sub

    Public Property Patas As Byte
        Get
            Return pata
        End Get
        Set(ByVal value As Byte)
            If (value >= 0 And value <= 4) Then
                pata = value
            End If

        End Set
    End Property

    Public Overrides Sub comer()
        MsgBox("Soy don gato y estoy comiendo")
    End Sub

    Sub saltar()
    End Sub


    Public Overrides Sub correr()
        MyBase.correr()
        MsgBox("Soy un gato y estoy corriendo")
    End Sub


    Sub caminar()
    End Sub

    Public Overrides Sub hablar()
        MsgBox("Miau")
    End Sub


End Class
