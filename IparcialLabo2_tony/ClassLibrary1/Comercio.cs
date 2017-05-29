using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{
    class Comercio
    {
        private string _dueño;
        private List<Ventas> _misVentas;



        public Comercio(string dueño)
        { this._dueño = dueño; }

        public void ComprarArticulo(Articulo articuloComprado)
        { }

        public void MostrarArticulos(Comercio ComercioAMostrar)
        { }

        public void MostrarGanancia(Comercio ComercioParaResumen)
        { }

        public void VenderArticulo(Articulo articuloSolicitado, int cantidad)
        { }




    }
}
