using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor:Universitario
    {
        private Queque<EClases> _clasesDelDia;
        private Random _radom;

        #region Metodos
        private void _randomClases()
        { }

        protected string MostrarDatos()
        { }

        public static bool operator ==(Profesor i, EClases clase)
        { }

        public static bool operator !=(Profesor i, EClases clase)
        { }

        protected string ParticiparEnClase()
        { }

        public Profesor()
        { }

        private Profesor()
        { }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        { }

        public string ToString()
        { }






        #endregion

    }
}
