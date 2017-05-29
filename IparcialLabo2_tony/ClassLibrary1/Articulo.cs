using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class Articulo
    {
        private int _codigo;
        private string _nombre;
        private float _precioCosto;
        private float _precioVenta;
        private int _stock;
        private int _cantidad;


        public Articulo(int codigo, string nombre, float precioCosto, int cantidad)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._precioCosto=precioCosto;
            this._cantidad = cantidad;
        
        }

        //public Articulo(int codigo, string nombre, float precioCosto, float precioVenta, int stock)
        //{
        //    this._codigo = codigo;
        //    this._nombre = nombre;
        //    this._precioCosto=precioCosto;
        //    this._precioVenta = precioVenta;
        //    //this._stock = stock;
        //}


        public string NombreyCodigo
        { get { return this._nombre + this._codigo; } }

        public float PrecioCosto
        {
            set 
            
            {
                this._precioVenta = this._precioCosto *(float) 0.30;
            }
            
          }

        public float PrecioVenta
        {
            get { return this._precioVenta; }
            
        }

        //public int Stock
        //{ set { this._stock = stock; } }



        
        public bool HayStock(int cantidad)
        {
            if (cantidad >= this._stock)
            { return true; }
        }

        public static bool operator !=(Articulo articuloUno, Articulo articuloDos)
        {
            return !(articuloUno.NombreyCodigo == articuloDos.NombreyCodigo);
        }

        public static int  operator -( Articulo articuloUno,int cantidad)
        
        {
            int result2 = 0;
            result2 = articuloUno._cantidad- cantidad;
            return result2;

        }

        public static int  operator +(Articulo articuloUno, Articulo articuloDos)
        {
            int result = 0;
            result = articuloUno._stock + articuloDos._stock;
            return (int )result;
        }

        public static bool operator ==(Articulo articuloUno, Articulo articuloDos)
        {
            if (articuloUno.NombreyCodigo == articuloDos.NombreyCodigo)
            {
                return true;
            }
        }




   }
}
