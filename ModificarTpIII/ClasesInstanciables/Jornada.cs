using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Jornada
    {
         private List<Alumno> _alumnos;
        private EClases _clase;
        private Profesor  _instructor;


        public List<Alumno> Alumnos
        { get; set; }

        public EClases Clase
        { get; set; }

        public Profesor Instructor
        { get; set; }

        #region Metodos

        public bool Guardar(Jornada jornada)
        { }

        private Jornada()
        { }

        public Jornada(EClase clase, Profesor instructor)
        { }

        public string Leer()
        { }

        public static bool operator =!(Jornada j , Alumno a)
        {}
        public static bool operator+(Jornada j, Alumno a)
        {}

        public static bool operator ==(Jornada j , Alumno a)
        {}

        public string ToString()
        { }


        #endregion

    }
}
