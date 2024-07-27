using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ejemplo3ConsolaInterfaces_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehiculo miCoche = new Coche();
            IVehiculo miMoto = new Moto();

            miCoche.Arrancar();
            miCoche.Detener();

            miMoto.Arrancar();
            miMoto.Detener();
        }
    }
}
