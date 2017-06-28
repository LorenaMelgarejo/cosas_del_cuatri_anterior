using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno: Universitario
    {
          public enum EEstadoCuenta
        {
        }

        private EClases _claseQueToma;
        private EEstadoCuenta;
    #region Metodos
     public Alumnos()
     {}

     public Alumnos(int id, string nombre,string apellido, string dni, ENacionalidad nacionalidad, EClase claseQueToma)                     
     {}

     public Alumnos(int id, string nombre,string apellido, string dni, ENacionalidad nacionalidad, EClase claseQueToma,EEstadoCuenta estadoCuenta)                     
     {}


     protected string MostrarDatos()
     {}

    public static bool operator ==(Alumno a, EClases clase)
    {}

    public static bool operator !=(Alumno a, EClases clase)
    {}


    protected string ParticiparEnClase()
    {}

    public string ToString()
    {}



     #endregion
       
    }
}
