Public NotInheritable Class Perro
    Inherits Animal

    Public tamanio As Double

    Public Overrides Sub comer()
        MsgBox("Soy un perro feliz y estoy comiendo")
    End Sub

  Sub New(ByVal nombre As String, ByVal raza As String, ByVal edad As Byte)
        MyBase.New(nombre, edad)
        Me.raza = raza
    End Sub


    Sub Respirar()

    End Sub


    Public Overrides Sub hablar()
        MsgBox("Guau")
    End Sub

End Class
