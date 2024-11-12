using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Colectivo
    {
        public int Id { get; set; }
        public int Linea { get; set; }
        //public List<Pasajero> pasajeros { get; set; }


        public List<Pasajero> Pasajeros { get; set; }  = new List<Pasajero>();

        /* public Colectivo()
        {
            pasajeros = new List<Pasajero>();
        }*/
    }
}
