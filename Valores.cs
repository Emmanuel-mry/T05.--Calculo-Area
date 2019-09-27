using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos_SC
{
    class Valores
    {
        int LadoC; //Declare esta variable de manera global para no tener ningun problema
        public void ObtenerValores() //Metodo donde pide los valores de los lados y muestra los resultados
        {
            Areas AR = new Areas();//Instanciando la clase Areas
            Console.WriteLine("-BIENVENIDO-");
            Console.WriteLine();
            Console.WriteLine("INGRESE LADO A");
            double LadoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("INGRESE LADO B");
            double LadoB = Convert.ToDouble(Console.ReadLine());

            double area = AR.Cuadro(LadoA), area2 = AR.rectangulo(LadoA, LadoB), area3 = AR.Triangulo(LadoA, LadoB, LadoC);
            Console.WriteLine("CUADRADO" +"   = " + area);
            Console.WriteLine("RECTANGULO" + " = " + area2);
            Console.WriteLine("TRIANGULO" + "  = " + area3);
            Console.ReadLine();
            





        }

    }
}
