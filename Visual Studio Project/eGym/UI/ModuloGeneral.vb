Imports BLL
Imports EL
Public Module ModuloGeneral
    Public objGestorRol As New GestorRol()
    Public objGestorPermiso As New GestorPermiso()
    Public objGestorTipoDeMaquina As New GestorTiposDeMaquina()
    Public objGestorMaquina As New GestorMaquina()
    Public objGestorMusculo As New GestorMusculo()
    Public objeGestorEjercicio As New GestorEjercicio()
    Public objGestorSesion As New GestorSesion()
    Public Gestor As Gestor = New Gestor()

    Public usuarioSesion As Usuario

End Module
