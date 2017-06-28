using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Universitario: Persona
    {
        private int _legajo;

        #region metodos

        public bool Equals(object obj)
        { }

        protected string MostrarDatos()
        { }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        { }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        { }

        protected string ParticiparEnClase()
        { }

        public Universitario()
        { }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        { }
        #endregion
    }
}
