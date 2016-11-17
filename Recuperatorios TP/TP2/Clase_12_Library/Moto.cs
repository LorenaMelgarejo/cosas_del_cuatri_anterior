using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_12_Library_2;//using

using System.Drawing;

namespace Clase_12_Library
{
    public class Moto : Vehiculo//falto invocar a la clase padre
    {
        public Moto(EMarca marca, string patente, ConsoleColor color)
            : base(patente, marca, color)//constructor
        {
        }
        /// <summary>
        /// Las motos tienen 2 ruedas
        /// </summary>
        public override short CantidadRuedas//publico y agregar el set para que sea igual al de Vehiculo
        {
            get{return 2;}
            set { }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("RUEDAS :" + this.CantidadRuedas);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();//falto ToString
        }
    }
}
