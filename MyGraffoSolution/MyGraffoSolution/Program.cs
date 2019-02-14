using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraffoSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cola cola1 = new Cola();
            //cola1.Insertar("A");
            //cola1.Insertar("B");
            //cola1.Insertar("C");
            //cola1.Imprimir();
            //Console.WriteLine("Extraemos uno de la cola:" + cola1.Extraer());
            //cola1.Imprimir();
            //Console.ReadKey();
            Cola nodito = new Cola();
            nodito.Insertar("A", "B", "C", "D");
            nodito.Insertar("B", "E", "F");
            nodito.Insertar("C","G");
            nodito.Imprimir();

            Console.WriteLine(Environment.NewLine+"Ingrese nodo objetivo");
            Console.WriteLine(nodito.verificadorderutasporanchura("A", "G"));
            Console.WriteLine("separacion");
            //Console.WriteLine(nodito.verificadorderutasporprofundidad("A", "D"));
            nodito.mostrarelmentosdeunalista();
            Console.ReadKey();
        }
    }
}
