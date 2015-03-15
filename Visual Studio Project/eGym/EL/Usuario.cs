using System;
using System.Drawing;

namespace EL
{
    public class Usuario
    {
        #region Variables 
        private int _id;
        private string _identificacion;
        private string _nombre;
        private string _segundoNombre;
        private string _apellido;
        private string _segundoApellido;
        private string _alias;
        private DateTime _fechaNacimiento;
        private string _correoElectronico;
        private string _contrasena;
        private Image _fotografia;
        private DateTime _fechaIngreso;
        private string _numeroTelefono;
        private string _numeroCelular;
        private bool _habilitado;
        private Rol _rol;
        #endregion

        #region Propiedades
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Rol Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }
        public string Identificacion
        {
            get { return _identificacion; }
            set { _identificacion = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string SegundoNombre
        {
            get { return _segundoNombre; }
            set { _segundoNombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string SegundoApellido
        {
            get { return _segundoApellido; }
            set { _segundoApellido = value; }
        }
        public string Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public string CorreoElectronico
        {
            get { return _correoElectronico; }
            set { _correoElectronico = value; }
        }
        public string Contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }
        public Image Fotografia
        {
            get { return _fotografia; }
            set { _fotografia = value; }
        }
        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }
        public string NumeroTelefono
        {
            get { return _numeroTelefono; }
            set { _numeroTelefono = value; }
        }
        public string NumeroCelular
        {
            get { return _numeroCelular; }
            set { _numeroCelular = value; }
        }
        public bool Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }
        #endregion

        public Usuario(string pnombre, string papellido, Rol prol)
        {
            // TODO: Complete member initialization
            this.Nombre = pnombre;
            this.Apellido = papellido;
            this.Rol = prol;
            //this.Fotografia = pfoto;
        }

        public Usuario()
        {
            // TODO: Complete member initialization
        }
    }
}
