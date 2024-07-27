using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ejemplo3ConsolaInterfaces_Polimorfismo
{
    internal class Moto: IVehiculo
    {
        public Moto() { }
        public void Arrancar()
        {
            Console.WriteLine("La moto está arrancando");
        }


        public void Detener()
        {
            Console.WriteLine("La moto se está deteniendo");
        }

    }
}
