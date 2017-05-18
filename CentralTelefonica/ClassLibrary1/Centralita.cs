using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Centralita
    {
        private List<Llamada> _listaDeLlamada;
        protected string _razonSocial;


        #region Propiedades

        public float GananciaPorLocal
        { get; }

        public float GanaciaPorProvincial
        { get; }

        public float GananciaTotal
        { get; }

        public List<Llamada> Llamada
        { get; }


        #endregion


        #region Metodos


        private float CalcularGanancia(TipoLlamada tipo)
        { }

        public Centralita()
        { }

        public Centralita(string nombreEmpresa)
        { }

        public void Mostrar()
        { }

        public void OrdenarLlamadas()
        { }



        #endregion
    }
}
