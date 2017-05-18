using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Local:Llamada
    {
        protected float _costo;


        public float CostoLlamada
        { get{this.CalcularCosto();}}


        #region Metodos

        private float CalcularCosto()
        { }

        public Local(Llamada unaLlamada, float costo)
        {
            this._costo = costo;
            Llamada = unaLlamada;
          
        }

        public Local(string origen, float duracion, string destino, float costo)
        { }

        public void Mostrar()
        { }


        #endregion


    }
}
