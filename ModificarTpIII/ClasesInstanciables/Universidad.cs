using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public class Universidad
    {
        public enum EClases
        { }

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;


        public list<Alumno> Alumnos
        { get; set; }

        public list<Profesor> Instructores
        { get; set; }

        public list<Jornada> Jornadas
        { get; set; }

        public Jornada this[int i]
        { get; set; }

        #region Metodos

        public bool Guardar(Universidad gim)
        { }

        private string MostrarDatos(Universidad gim)
        { }

        public static bool operator !=(Universidad g, Alumno a)
        { }

        public static Profesor operator !=(Universidad g, EClases clase)
        { }


        public static bool operator !=(Universidad g, Profesor i)
        { }

        public static Universidad operator +(Universidad g, Alumno a)
        { }

        public static Universidad operator +(Universidad g, EClases clase)
        { }

        public static Universidad operator +(Universidad g, Profesor i)
        { }


        public static bool operator ==(Universidad g, Alumno a)
        { }

        public static Profesor operator ==(Universidad g, EClases clase)
        { }

        public static bool operator ==(Universidad g, Profesor i)
        { }

        public string ToString()
        { }

        public Universidad()
        { }


        #endregion

    }
}
