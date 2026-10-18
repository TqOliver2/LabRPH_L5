Imports System.Drawing

Namespace UI
    ''' <summary>
    ''' Paleta de colores oficial del sistema 'Registro de Pacientes en un Hospital'.
    ''' </summary>
    Public Module ColoresTema
        ''' <summary>Morado oscuro (#413074) - Encabezados, títulos y elementos importantes.</summary>
        Public ReadOnly MoradoOscuro As Color = ColorTranslator.FromHtml("#413074")

        ''' <summary>Morado claro (#736FA1) - Detalles, bordes, encabezados secundarios y acentos.</summary>
        Public ReadOnly MoradoClaro As Color = ColorTranslator.FromHtml("#736FA1")

        ''' <summary>Turquesa (#0FB7B8) - Botones principales, estados activos y confirmaciones.</summary>
        Public ReadOnly Turquesa As Color = ColorTranslator.FromHtml("#0FB7B8")

        ''' <summary>Fondo claro (#F7F8FA) - Áreas de trabajo y fondos generales de los formularios.</summary>
        Public ReadOnly FondoClaro As Color = ColorTranslator.FromHtml("#F7F8FA")

        ''' <summary>Blanco puro para contrastes altos sobre fondos oscuros.</summary>
        Public ReadOnly Blanco As Color = Color.White
    End Module
End Namespace
