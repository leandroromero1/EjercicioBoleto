using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class Colectivo
    {
        public int Id { get; set; }
        public int Linea { get; set; }
        private List<Pasajero> pasajeros;

        public Colectivo()
        {
            pasajeros = new List<Pasajero>();
        }
    }
}
