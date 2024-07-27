using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ejemplo3ConsolaInterfaces_Polimorfismo
{
     class Coche:IVehiculo
    {
        public Coche() { }
        public void Arrancar()
        {
            Console.WriteLine("El coche está arrancando");
        }


        public void Detener()
        {
            Console.WriteLine("El coche se está deteniendo");
        }

      
    }
}
