using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        

        #region Propiedades

        public float Duracion
        { get { return this._duracion; } }

        public string NroDestino
        { get { return this._nroDestino; } }

        public string NroOrigen
        { get { return this._nroOrigen; } }

        #endregion

        #region Metodos

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;

        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("origen: " + this._nroOrigen);
            sb.AppendLine("destino: " + this._nroDestino);
            sb.AppendLine("duracion: " + this._duracion);

            //return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            if (dos._duracion > uno._duracion)
            {
                
                
            }    
            }
        #endregion
    }
}
