Imports System.IO
Public Class Form1
    Private Sub CargarAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarAlumnosToolStripMenuItem.Click

        'Limpiamos los textos por si los habia'
        TextBox_Delegado.Text = ""
        TextBox_Delegado_Votos.Text = ""
        TextBox_Subdelegado.Text = ""
        TextBox_Subdelegado_Votos.Text = ""

        ListBox_Alumnos.Items.Clear()
        ListBox_Votados.Items.Clear()
        ListBox_Votos.Items.Clear()

        Try
            Dim sr As New StreamReader("../../Alumnos.txt")
            Dim texto As String
            texto = sr.ReadLine
            Do While Not texto Is Nothing
                ListBox_Alumnos.Items.Add(texto)
                texto = sr.ReadLine
            Loop
            sr.Close()


        Catch errorFile As System.IO.FileNotFoundException
            MsgBox("No se ha encontrado el archivo Alumnos.txt")
        End Try

    End Sub

    Private Sub GrabarEscrutinioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrabarEscrutinioToolStripMenuItem.Click
        If ListBox_Votados.Items.Count > 0 Then
            Dim sw As New StreamWriter("Escrutinio.txt", False, System.Text.Encoding.Unicode)
            Dim alumno As String
            Dim contador As Integer = 0
            For Each alumno In ListBox_Votados.Items
                Dim text As String
                Dim numVotos As Integer
                numVotos = ListBox_Votos.Items.Item(contador)
                text = alumno + "," + numVotos.ToString()
                sw.WriteLine(text)
                contador = contador + 1
            Next
            sw.Close()
            MsgBox("Archivo guardado en ~/bin/debug/Escrutinio.txt")
        End If
    End Sub

    Private Sub OrdenarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarToolStripMenuItem.Click, Button_Ordenar.Click
        If ListBox_Votados.Items.Count > 1 Then
            'Ordenamos por el metodo de la burbuja'
            Dim i, j, variable As Integer
            Dim varString As String
            For i = 1 To ListBox_Votados.Items.Count - 1
                For j = 0 To ListBox_Votados.Items.Count - i - 1
                    If ListBox_Votos.Items.Item(j) < ListBox_Votos.Items.Item(j + 1) Then
                        variable = ListBox_Votos.Items.Item(j + 1)
                        varString = ListBox_Votados.Items.Item(j + 1)
                        ListBox_Votos.Items.Item(j + 1) = ListBox_Votos.Items.Item(j)
                        ListBox_Votos.Items.Item(j) = variable
                        ListBox_Votados.Items.Item(j + 1) = ListBox_Votados.Items.Item(j)
                        ListBox_Votados.Items.Item(j) = varString
                    End If
                Next
            Next
            TextBox_Delegado.Text = ListBox_Votados.Items.Item(0).ToString
            TextBox_Subdelegado.Text = ListBox_Votados.Items.Item(1).ToString
            TextBox_Delegado_Votos.Text = ListBox_Votos.Items.Item(0).ToString
            TextBox_Subdelegado_Votos.Text = ListBox_Votos.Items.Item(1).ToString
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button_mas1_Click(sender As Object, e As EventArgs) Handles Button_mas1.Click
        If ListBox_Alumnos.Items.Count > 0 Then
            Dim alumnoSeleccionado As String = ListBox_Alumnos.SelectedItem.ToString()
            'Si el alumno no esta en la lista de votados, lo añadimos'
            If Not ListBox_Votados.FindString(alumnoSeleccionado) <> ListBox.NoMatches Then
                ListBox_Votados.Items.Add(ListBox_Alumnos.SelectedItem.ToString())
                ListBox_Votos.Items.Add(1)
            Else
                'Si el alumno ya esta en la lista lo actualizamos'
                Dim numIndice As Integer = ListBox_Votados.FindString(alumnoSeleccionado)
                Dim numVotos As Integer = ListBox_Votos.Items.Item(numIndice) + 1
                ListBox_Votos.Items.RemoveAt(numIndice)
                ListBox_Votos.Items.Insert(numIndice, numVotos)
            End If
        End If
    End Sub

    Private Sub Button_menos1_Click(sender As Object, e As EventArgs) Handles Button_menos1.Click
        If ListBox_Alumnos.Items.Count > 0 Then
            Dim alumnoSeleccionado As String = ListBox_Alumnos.SelectedItem.ToString()

            If ListBox_Votados.FindString(alumnoSeleccionado) <> ListBox.NoMatches Then

                Dim numIndice As Integer = ListBox_Votados.FindString(alumnoSeleccionado)
                Dim numVotos As Integer = ListBox_Votos.Items.Item(numIndice) - 1
                'si tiene mas de 0 votos lo actualizamos'
                If numVotos > 0 Then
                    ListBox_Votos.Items.RemoveAt(numIndice)
                    ListBox_Votos.Items.Insert(numIndice, numVotos)
                    'si no tiene ningun voto, lo eliminamos'    
                Else
                    ListBox_Votos.Items.RemoveAt(numIndice)
                    ListBox_Votados.Items.RemoveAt(numIndice)
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub
End Class
