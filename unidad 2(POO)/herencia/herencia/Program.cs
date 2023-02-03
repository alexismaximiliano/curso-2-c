using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vehiculo
            //auto>auto deportivo ||auto urbano
            //motocicleta
            Vehiculo v1= new Vehiculo();
            Auto a1= new Auto();
            Auto a2= new Auto();
            Auto a3=new Auto();

            a1.Color = "blanco";
            a2.Color = "rojo";
            a3.Color = "negro";
            //colecciones
            List<Auto> ListaAutos= new List<Auto>(); //lista
            ListaAutos.Add(a1);
            ListaAutos.Add(a2); 
            ListaAutos.Add(a3);

            Console.WriteLine("n° de autos: "+ListaAutos.Count);
            Console.WriteLine("color 2°:" + ListaAutos[1].Color);
            

            foreach(Auto auto in ListaAutos) //bucle lista
            {
                Console.WriteLine(auto.Color);
            }
            Console.ReadKey();
        }
    }
}
