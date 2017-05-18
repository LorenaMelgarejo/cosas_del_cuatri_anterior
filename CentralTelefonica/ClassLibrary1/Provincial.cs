using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{
    class Provincial:Llamada
    {
        protected Franja _franjaHoraria;

        public float CostoLlamada
        { get; }

        #region
        private float CalcularCosto()
        { }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Provincial");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("franja horaria : " + this._franjaHoraria);
            sb.AppendLine("costo de llamada: " + this.CostoLlamada);
            

        }

        public Provincial(Franja miFranja, Llamada unaLlamada)
        { }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
        { }
        #endregion

    }
}
