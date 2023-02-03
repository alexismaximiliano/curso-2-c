using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_1


{
    internal class Program
        /*Crear algunos objetos en el main de Program y probar escribirle datos y 
         * mostrar en pantalla el estado del Telefono.*/

    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("modelo","marca");
            Console.Write("ingrese numero de telefono:");
            t1.NumeroTelefonico =Console.ReadLine();
            Console.WriteLine(t1.Llamar());
            Console.WriteLine(t1.Llamar("ana"));
            Console.ReadKey();
        }
    }
}
