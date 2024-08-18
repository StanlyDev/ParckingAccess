Public Class indexFrm
    ' Definición de los límites para cada tipo de ticket
    Const T_car As Integer = 20
    Const T_moto As Integer = 10

    ' Contador de tickets generados para autos
    Private carTicketCount As Integer = 0
    ' Límite máximo de tickets para autos
    Private Const maxCarTickets As Integer = T_car

    ' Contador de tickets generados para motos
    Private motoTicketCount As Integer = 0
    ' Límite máximo de tickets para motos
    Private Const maxMotoTickets As Integer = T_moto

    ' Instancia del generador de números aleatorios
    Private random As New Random()

    Private Sub btnValidTime_Click(sender As Object, e As EventArgs) Handles btnValidTime.Click
        Dim timeForm As New timeTicket()

        ' Pasar los tickets generados al formulario timeTicket
        For Each kvp In carTickets
            timeForm.AddCarTicket(kvp.Key)
        Next

        For Each kvp In motoTickets
            timeForm.AddMotoTicket(kvp.Key)
        Next

        timeForm.Show()
    End Sub

    ' Diccionario para almacenar los tickets generados para autos y motos
    Private carTickets As New Dictionary(Of String, DateTime)()
    Private motoTickets As New Dictionary(Of String, DateTime)()

    Private Sub btnCar_Click(sender As Object, e As EventArgs) Handles btnCar.Click
        If carTicketCount >= maxCarTickets Then
            MessageBox.Show("El límite de tickets generados para autos ha sido alcanzado.")
            Return
        End If

        ' Generar un número aleatorio entre 0 y 999
        Dim randomNumber As Integer = random.Next(0, 1000)
        ' Formatear el número con ceros a la izquierda
        Dim formattedNumber As String = randomNumber.ToString("D3")
        ' Crear el ticket con el formato "TK000"
        Dim ticket As String = "TK" & formattedNumber

        ' Mostrar el ticket en el TextBox
        tbxCar.Text = ticket

        ' Agregar el ticket al diccionario
        carTickets(ticket) = DateTime.Now

        ' Incrementar el contador de tickets generados
        carTicketCount += 1
        ' Mostrar el contador en el Label
        txtCoutCar.Text = carTicketCount & " / 20"
    End Sub

    Private Sub btnMoto_Click(sender As Object, e As EventArgs) Handles btnMoto.Click
        If motoTicketCount >= maxMotoTickets Then
            MessageBox.Show("El límite de tickets generados para motos ha sido alcanzado.")
            Return
        End If

        Dim randomNumber As Integer = random.Next(0, 1000)
        Dim formattedNumber As String = randomNumber.ToString("D3")
        Dim ticket As String = "TK" & formattedNumber

        tbxMoto.Text = ticket

        ' Agregar el ticket al diccionario
        motoTickets(ticket) = DateTime.Now

        motoTicketCount += 1
        txtCoutMoto.Text = motoTicketCount & " / 10"
    End Sub
End Class