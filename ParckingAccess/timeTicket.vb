Public Class timeTicket
    ' Diccionario para almacenar tickets y tiempos
    Private carTickets As New Dictionary(Of String, DateTime)()
    Private motoTickets As New Dictionary(Of String, DateTime)()

    Private Sub timeTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración inicial de los ListView
        ConfigureListView(ListView1)
        ConfigureListView(ListView2)

        ' Llenar ListView con tickets
        PopulateListView(ListView1, carTickets)
        PopulateListView(ListView2, motoTickets)

        ' Iniciar el temporizador
        Timer1.Start()
    End Sub

    Private Sub ConfigureListView(lv As ListView)
        ' Configuración de las columnas
        lv.Columns.Add("Ticket", 100, HorizontalAlignment.Left)
        lv.Columns.Add("Tiempo", 100, HorizontalAlignment.Left)
        lv.Columns.Add("Total a pagar", 100, HorizontalAlignment.Right)
        lv.View = View.Details
    End Sub

    Private Sub PopulateListView(lv As ListView, tickets As Dictionary(Of String, DateTime))
        lv.Items.Clear()
        For Each kvp In tickets
            Dim ticket As String = kvp.Key
            Dim startTime As DateTime = kvp.Value
            Dim elapsedTime As TimeSpan = DateTime.Now - startTime
            Dim formattedTime As String = String.Format("{0:D2}:{1:D2}:{2:D2}",
                                                        elapsedTime.Hours,
                                                        elapsedTime.Minutes,
                                                        elapsedTime.Seconds)
            Dim totalAmount As Decimal = Math.Floor(elapsedTime.TotalMinutes) * 5
            Dim item As New ListViewItem(ticket)
            item.SubItems.Add(formattedTime)
            item.SubItems.Add(totalAmount.ToString("C"))
            lv.Items.Add(item)
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Actualizar los ListView periódicamente
        PopulateListView(ListView1, carTickets)
        PopulateListView(ListView2, motoTickets)
    End Sub

    ' Método para agregar un ticket con la hora actual
    Public Sub AddCarTicket(ticket As String)
        carTickets(ticket) = DateTime.Now
    End Sub

    Public Sub AddMotoTicket(ticket As String)
        motoTickets(ticket) = DateTime.Now
    End Sub

    ' Método para eliminar un ticket
    Private Sub btnDelTK_Click(sender As Object, e As EventArgs) Handles btnDelTK.Click
        Dim ticketToRemove As String = tbxDelTK.Text.Trim()

        If String.IsNullOrEmpty(ticketToRemove) Then
            MessageBox.Show("Ingrese un ticket para eliminar.")
            Return
        End If

        ' Eliminar ticket del diccionario de autos si existe
        If carTickets.ContainsKey(ticketToRemove) Then
            carTickets.Remove(ticketToRemove)
        End If

        ' Eliminar ticket del diccionario de motos si existe
        If motoTickets.ContainsKey(ticketToRemove) Then
            motoTickets.Remove(ticketToRemove)
        End If

        ' Actualizar los ListView después de la eliminación
        PopulateListView(ListView1, carTickets)
        PopulateListView(ListView2, motoTickets)

        ' Limpiar el TextBox
        tbxDelTK.Clear()
    End Sub
End Class