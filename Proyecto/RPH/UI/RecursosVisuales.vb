Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO

Namespace UI
    ''' <summary>
    ''' Proporciona las imágenes oficiales del sistema hospitalario (Logo y Arte Médico).
    ''' Si no se encuentran los archivos en disco, los genera dinámicamente con alta calidad.
    ''' </summary>
    Public Class RecursosVisuales

        ''' <summary>
        ''' Genera u obtiene la imagen de espacio reservado para el logo del hospital.
        ''' </summary>
        Public Shared Function ObtenerImagenLogo(ancho As Integer, alto As Integer) As Image
            Dim rutaArchivo As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "espacio_logo.png")
            If File.Exists(rutaArchivo) Then
                Try
                    Return Image.FromFile(rutaArchivo)
                Catch
                    ' Si hay error de bloqueo o lectura, generar dinámicamente
                End Try
            End If

            ' Generación dinámica con dibujo vectorial
            Dim bmp As New Bitmap(ancho, alto)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.SmoothingMode = SmoothingMode.AntiAlias
                g.Clear(ColoresTema.FondoClaro)

                Using penBorde As New Pen(ColoresTema.MoradoClaro, 1.5F)
                    penBorde.DashStyle = DashStyle.Dash
                    g.DrawRectangle(penBorde, 2, 2, ancho - 5, alto - 5)
                End Using

                Using brushTexto As New SolidBrush(ColoresTema.MoradoOscuro)
                    Using fuente As New Font("Segoe UI", 9.0F, FontStyle.Bold)
                        Dim formato As New StringFormat With {
                            .Alignment = StringAlignment.Center,
                            .LineAlignment = StringAlignment.Center
                        }
                        g.DrawString("Espacio para logo", fuente, brushTexto, New RectangleF(0, 0, ancho, alto), formato)
                    End Using
                End Using
            End Using

            Return bmp
        End Function

        ''' <summary>
        ''' Genera u obtiene la ilustración médica para el formulario de detalle o vistas médicas.
        ''' </summary>
        Public Shared Function ObtenerIlustracionMedica(ancho As Integer, alto As Integer) As Image
            Dim rutaArchivo As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "ilustracion_medica.png")
            If File.Exists(rutaArchivo) Then
                Try
                    Return Image.FromFile(rutaArchivo)
                Catch
                    ' Si hay problema leyendo el archivo, generar dinámicamente
                End Try
            End If

            Dim bmp As New Bitmap(ancho, alto)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.SmoothingMode = SmoothingMode.AntiAlias
                g.Clear(ColoresTema.FondoClaro)

                Dim margen As Integer = Math.Min(ancho, alto) \ 10
                Dim rectCirculo As New Rectangle(margen, margen, ancho - (margen * 2), alto - (margen * 2))

                ' Círculo exterior
                Using brushFondo As New SolidBrush(Color.White)
                    g.FillEllipse(brushFondo, rectCirculo)
                End Using

                Using penBorde As New Pen(ColoresTema.MoradoClaro, 3.0F)
                    g.DrawEllipse(penBorde, rectCirculo)
                End Using

                ' Cruz médica turquesa
                Dim centroX As Integer = ancho \ 2
                Dim centroY As Integer = alto \ 2
                Dim largoCruz As Integer = (rectCirculo.Width * 6) \ 10
                Dim anchoCruz As Integer = largoCruz \ 3

                Dim rectVertical As New Rectangle(centroX - (anchoCruz \ 2), centroY - (largoCruz \ 2), anchoCruz, largoCruz)
                Dim rectHorizontal As New Rectangle(centroX - (largoCruz \ 2), centroY - (anchoCruz \ 2), largoCruz, anchoCruz)

                Using brushCruz As New SolidBrush(ColoresTema.Turquesa)
                    g.FillRectangle(brushCruz, rectVertical)
                    g.FillRectangle(brushCruz, rectHorizontal)
                End Using

                ' Centro de la cruz en morado oscuro
                Dim centroTamano As Integer = anchoCruz - 6
                Dim rectCentro As New Rectangle(centroX - (centroTamano \ 2), centroY - (centroTamano \ 2), centroTamano, centroTamano)
                Using brushCentro As New SolidBrush(ColoresTema.MoradoOscuro)
                    g.FillEllipse(brushCentro, rectCentro)
                End Using

                ' Pequeño símbolo más blanco en el centro
                Using brushBlanco As New SolidBrush(Color.White)
                    Using fuente As New Font("Segoe UI", 11.0F, FontStyle.Bold)
                        Dim formato As New StringFormat With {
                            .Alignment = StringAlignment.Center,
                            .LineAlignment = StringAlignment.Center
                        }
                        g.DrawString("+", fuente, brushBlanco, New RectangleF(rectCentro.X, rectCentro.Y, rectCentro.Width, rectCentro.Height), formato)
                    End Using
                End Using
            End Using

            Return bmp
        End Function

    End Class
End Namespace
