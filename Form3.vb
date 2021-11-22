﻿Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ElementosArray1 = New String() {"Koenigsegg", "Lamborghini", "W Motors", "Bugatti", "Ferrari", "Aston Martin", "Pagani", "Maybach", "Porsche", "Bentley"}

        ComboMFamiliar.Items.Add(ElementosArray1(0))
        ComboMFamiliar.Items.Add(ElementosArray1(1))
        ComboMFamiliar.Items.Add(ElementosArray1(2))
        ComboMFamiliar.Items.Add(ElementosArray1(3))
        ComboMFamiliar.Items.Add(ElementosArray1(4))
        ComboMFamiliar.Items.Add(ElementosArray1(5))
        ComboMFamiliar.Items.Add(ElementosArray1(6))
        ComboMFamiliar.Items.Add(ElementosArray1(7))
        ComboMFamiliar.Items.Add(ElementosArray1(8))
        ComboMFamiliar.Items.Add(ElementosArray1(9))
    End Sub

    Private Sub BotonContinuar_Click(sender As Object, e As EventArgs) Handles BotonContinuar.Click
        Form5.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BotonCancelar.Click
        Dispose()
    End Sub

    Private Sub ComboMFamiliar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMFamiliar.SelectedIndexChanged
        Dim SignoDeBalboa = "Bl/. "
        Dim VPrecioHora
        Dim VPrecioDia
        Dim VPrecioSemana
        Dim VPrecioMes
        Select Case ComboMFamiliar.SelectedIndex
            Case 0
                VPrecioHora = 10
                VPrecioDia = 100
                VPrecioSemana = 1000
                VPrecioMes = 10000
            Case 1
                VPrecioHora = 11
                VPrecioDia = 101
                VPrecioSemana = 1001
                VPrecioMes = 10001
            Case 2
                VPrecioHora = 12
                VPrecioDia = 102
                VPrecioSemana = 1002
                VPrecioMes = 10002
            Case 3
                VPrecioHora = 13
                VPrecioDia = 103
                VPrecioSemana = 1003
                VPrecioMes = 10003
            Case 4
                VPrecioHora = 14
                VPrecioDia = 104
                VPrecioSemana = 1004
                VPrecioMes = 10004
            Case 5
                VPrecioHora = 15
                VPrecioDia = 105
                VPrecioSemana = 1005
                VPrecioMes = 10005
            Case 6
                VPrecioHora = 16
                VPrecioDia = 106
                VPrecioSemana = 1006
                VPrecioMes = 10006
            Case 7
                VPrecioHora = 17
                VPrecioDia = 107
                VPrecioSemana = 1007
                VPrecioMes = 10007
            Case 8
                VPrecioHora = 18
                VPrecioDia = 108
                VPrecioSemana = 1008
                VPrecioMes = 10008
            Case 9
                VPrecioHora = 19
                VPrecioDia = 109
                VPrecioSemana = 1009
                VPrecioMes = 10009
        End Select
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
        TextoHora.Text = SignoDeBalboa & VPrecioHora
        TextoDia.Text = SignoDeBalboa & VPrecioDia
        TextoSemana.Text = SignoDeBalboa & VPrecioSemana
        TextoMes.Text = SignoDeBalboa & VPrecioMes
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
    End Sub

End Class