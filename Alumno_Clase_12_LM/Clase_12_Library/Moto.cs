﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Clase_12_Library
{
    public class Moto:Vehiculo
    {
        public Moto(EMarca marca, string patente, ConsoleColor color)
            : base( marca,patente, color)
        {
        }
        /// <summary>
        /// Las motos tienen 2 ruedas
        /// </summary>
        public override short CantidadRuedas//se agrega set y public
        {
            get
            {
                return 2;
            }
            set { }
        }
        

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("RUEDAS : "+ this.CantidadRuedas);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
