
Imports LiveCharts
Imports LiveCharts.Definitions.Series
Imports LiveCharts.Wpf
Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        exchange()
        history()


    End Sub

    Public Sub exchange()
        CartesianChart1.Series = New SeriesCollection From {
       New LineSeries With {
           .Title = "Exchange",
           .Values = New ChartValues(Of Double) From {
       4,
       6,
       5,
       2,
       7
       }
       }
       }
        CartesianChart1.AxisX.Add(New Axis With {
            .Title = "Month",
            .Labels = {"Jan", "Feb", "Mar", "Apr", "May"}
                                  })
        CartesianChart1.AxisY.Add(New Axis With {
        .Title = "Money",
        .LabelFormatter = Function(value) value.ToString("C")
        })
    End Sub

    Public Sub history()
        Guna2DataGridView1.Rows.Add(8)
        Guna2DataGridView1.Rows(0).Cells(0).Value = Image.FromFile("img\\1.png")
        Guna2DataGridView1.Rows(0).Cells(1).Value = "Guy Hawkins"
        Guna2DataGridView1.Rows(0).Cells(2).Value = "$320"
        Guna2DataGridView1.Rows(0).Cells(3).Value = "Complate"
        Guna2DataGridView1.Rows(0).Cells(4).Value = "Aug 20, 2020"
        Guna2DataGridView1.Rows(0).Cells(5).Value = Image.FromFile("img\\11.png")

        ' Guna2DataGridView1.Rows.Add(8)
        Guna2DataGridView1.Rows(1).Cells(0).Value = Image.FromFile("img\\2.png")
        Guna2DataGridView1.Rows(1).Cells(1).Value = "Floyd Miles"
        Guna2DataGridView1.Rows(1).Cells(2).Value = "$320"
        Guna2DataGridView1.Rows(1).Cells(3).Value = "Complate"
        Guna2DataGridView1.Rows(1).Cells(4).Value = "Aug 20, 2020"
        Guna2DataGridView1.Rows(1).Cells(5).Value = Image.FromFile("img\\11.png")

        ' Guna2DataGridView1.Rows.Add(8)
        Guna2DataGridView1.Rows(2).Cells(0).Value = Image.FromFile("img\\1.png")
        Guna2DataGridView1.Rows(2).Cells(1).Value = "Donal Duck"
        Guna2DataGridView1.Rows(2).Cells(2).Value = "$320"
        Guna2DataGridView1.Rows(2).Cells(3).Value = "Complate"
        Guna2DataGridView1.Rows(2).Cells(4).Value = "Aug 20, 2020"
        Guna2DataGridView1.Rows(2).Cells(5).Value = Image.FromFile("img\\11.png")

        ' Guna2DataGridView1.Rows.Add(8)
        Guna2DataGridView1.Rows(1).Cells(0).Value = Image.FromFile("img\\2.png")
        Guna2DataGridView1.Rows(3).Cells(1).Value = "Jacki Chain"
        Guna2DataGridView1.Rows(3).Cells(2).Value = "$320"
        Guna2DataGridView1.Rows(3).Cells(3).Value = "Complate"
        Guna2DataGridView1.Rows(3).Cells(4).Value = "Aug 20, 2020"
        Guna2DataGridView1.Rows(3).Cells(5).Value = Image.FromFile("img\\11.png")

        '  Guna2DataGridView1.Rows.Add(8)
        Guna2DataGridView1.Rows(4).Cells(0).Value = Image.FromFile("img\\1.png")
        Guna2DataGridView1.Rows(4).Cells(1).Value = "Ip Man"
        Guna2DataGridView1.Rows(4).Cells(2).Value = "$320"
        Guna2DataGridView1.Rows(4).Cells(3).Value = "Complate"
        Guna2DataGridView1.Rows(4).Cells(4).Value = "Aug 20, 2020"
        Guna2DataGridView1.Rows(4).Cells(5).Value = Image.FromFile("img\\11.png")

        ''  Guna2DataGridView1.Rows.Add(8)
        Guna2DataGridView1.Rows(1).Cells(0).Value = Image.FromFile("img\\2.png")
        Guna2DataGridView1.Rows(5).Cells(1).Value = "Stephen Cow"
        Guna2DataGridView1.Rows(5).Cells(2).Value = "$320"
        Guna2DataGridView1.Rows(5).Cells(3).Value = "Complate"
        Guna2DataGridView1.Rows(5).Cells(4).Value = "Aug 20, 2020"
        Guna2DataGridView1.Rows(5).Cells(5).Value = Image.FromFile("img\\11.png")

        Guna2DataGridView1.Rows(6).Cells(0).Value = Image.FromFile("img\\1.png")
        Guna2DataGridView1.Rows(6).Cells(1).Value = "Erick"
        Guna2DataGridView1.Rows(6).Cells(2).Value = "$320"
        Guna2DataGridView1.Rows(6).Cells(3).Value = "Complate"
        Guna2DataGridView1.Rows(6).Cells(4).Value = "Aug 20, 2020"
        Guna2DataGridView1.Rows(6).Cells(5).Value = Image.FromFile("img\\11.png")


        Guna2DataGridView1.Rows(1).Cells(0).Value = Image.FromFile("img\\2.png")
        Guna2DataGridView1.Rows(7).Cells(1).Value = "Bonaparte"
        Guna2DataGridView1.Rows(7).Cells(2).Value = "$320"
        Guna2DataGridView1.Rows(7).Cells(3).Value = "Complate"
        Guna2DataGridView1.Rows(7).Cells(4).Value = "Aug 20, 2020"
        Guna2DataGridView1.Rows(7).Cells(5).Value = Image.FromFile("img\\11.png")

        Guna2DataGridView1.Rows(8).Cells(0).Value = Image.FromFile("img\\1.png")
        Guna2DataGridView1.Rows(8).Cells(1).Value = "Hanna Haruna"
        Guna2DataGridView1.Rows(8).Cells(2).Value = "$320"
        Guna2DataGridView1.Rows(8).Cells(3).Value = "Complate"
        Guna2DataGridView1.Rows(8).Cells(4).Value = "Aug 20, 2020"
        Guna2DataGridView1.Rows(8).Cells(5).Value = Image.FromFile("img\\11.png")

    End Sub


End Class
