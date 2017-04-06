using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_2017
{
    public class Numero
    {
        private double numero;


        public double getNumero()
        {
            return this.numero;
        }

        public Numero()  // constructor por defecto q inicializa el atributo numero en 0
        {
            this.numero = 0;
        }

        public Numero(double numero) //recibe un double y cargara en numero.
        {
            this.numero = numero;
        }

        public Numero(string numero)  // recibe un string  q validara y cargara en numero
        {
            this.numero = (ValidarNumero(numero));
        }

        private void setNumero(string numero)
        {
            this.numero = Numero.ValidarNumero(numero);
        }


        private static double ValidarNumero(string numeroString)// valida q sea doble y en caso contrario retornara 0
        {
            double num;
            bool n = double.TryParse(numeroString, out num);

            if (n)
            {
                Console.WriteLine("numero doble");
                return double.Parse(numeroString);
            }

            else
            {
                Console.WriteLine("no es un numero de tipo double");
                return 0;

            }
        }



    }
}
