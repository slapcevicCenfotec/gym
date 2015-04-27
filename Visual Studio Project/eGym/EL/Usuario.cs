using System;
using System.Collections.Generic;
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
        private byte[] _fotografia;
        private DateTime _fechaIngreso;
        private string _numeroTelefono;
        private string _numeroCelular;
        private bool _habilitado;
        private Rol _rol;
        private int _idGenero;
        private int _idTipoIdentificacion;
        private List<Contacto> _contactos;
        private List<Horario> _horarios;

        public List<Horario> Horarios
        {
            get { return _horarios; }
            set { _horarios = value; }
        }

        public List<Contacto> Contactos
        {
            get { return _contactos; }
            set { _contactos = value; }
        }

        public Usuario()
        {
            Contactos = new List<Contacto>();
            Horarios = new List<Horario>();
        }
        public Usuario(string pNombre,string pSegundoNombre,string pApellido,string pSegundoApellido, string pCorreo, string pCel)
        {
            Contactos = new List<Contacto>();
            Horarios = new List<Horario>();
            this._nombre = pNombre;
            this._segundoNombre = pSegundoNombre;
            this._apellido = pApellido;
            this._segundoApellido = pSegundoApellido;
            this._correoElectronico = pCorreo;
            this._numeroCelular = pCel;
        }

        public int IdTipoIdentificacion
        {
            get { return _idTipoIdentificacion; }
            set { _idTipoIdentificacion = value; }
        }

        public int IdGenero
        {
            get { return _idGenero; }
            set { _idGenero = value; }
        }

        public Rol Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }
        #endregion

        #region Propiedades
        public int Id
        {
            get { return _id; }
            set { _id = value; }
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
        public byte[] Fotografia
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
        public string NombreCompleto
        {
            get
            {
                string nombreCompleto = string.Empty;
                nombreCompleto += Nombre;
                if (!string.IsNullOrEmpty(SegundoNombre))
                {
                    nombreCompleto += " " + SegundoNombre;
                }
                nombreCompleto += " " + Apellido;
                if (!string.IsNullOrEmpty(SegundoApellido))
                {
                    nombreCompleto += " " + SegundoApellido;
                }
                return nombreCompleto;
            }
        }
        public string HabilitadoString
        {
            get
            {
                if (Habilitado)
                {
                    return "Activo";
                }
                else
                {
                    return "No activo";
                }
            }
        }
        #endregion
    }
}
