using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exception;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        private string _apellido;
        private int _dni;
        private ENacionalidad _nacionalidad;
        private string _nombre;


        #region Propiedades

        public string Apellido
        {
            get { return this._apellido; }
            set
            {
                if (ValidarNombreApellido(value) != null)
                    _apellido = value;
            }
        }

       
        public int DNI
        {
            get { return _dni; }
            set
            {
                _dni = ValidarDni(Nacionalidad, value);
            }
        }

        
        public ENacionalidad Nacionalidad
        {
            get { return this._nacionalidad; }

            set{ this._nacionalidad = value; } 
            
        }

        public string Nombre
        {
            get { return this._nombre; }
            set {
                if (ValidarNombreApellido(value) != null)
                this._nombre = value; 
                }
        }

        public string StringToDNI
        { set { _dni = ValidarDni(Nacionalidad, value); } }
        #endregion

        #region Metodos

        public Persona()
        { }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._nacionalidad = nacionalidad;

        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        { this._dni = dni; }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        { this.StringToDNI = dni; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine("NOMBRE COMPLETO: " + this.Apellido + ", " + this.Nombre);
            sb.AppendLine("NACIONALIDAD: " + this.Nacionalidad.ToString());
            return sb.ToString();
        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (((nacionalidad.Equals(ENacionalidad.Argentino)) && (dato < 0 || dato > 90000000)))
            {
                throw new DniInvalidoException();
            }
            if (((nacionalidad.Equals(ENacionalidad.Extranjero)) && (dato < 90000000)))
            {
                throw new NacionalidadInvalidaException();
            }

            return dato; 

        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {

           

        }

        private string ValidarNombreApellido(string dato)
        {

            if (Regex.IsMatch(dato, @"^[a-zA-Z]+$"))
                return dato;
            else
                return null;   
        }






        #endregion


    }
}
