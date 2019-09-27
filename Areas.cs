using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos_SC
{
    class Areas
    {

        public double Cuadro(double LadoA) //Metodo del area de un cuadrado
        {
            var area = LadoA * LadoA;
            return area;

        }

        public double rectangulo(double LadoA, double LadoB) //Metodo del area de un rectangulo

        {
            var area2 = LadoA * LadoB;
            return area2;
        }

        public double Triangulo(double LadoA, double LadoB, double LadoC)
        {
            LadoC = 2;
            var area3 = (LadoA * LadoB) / LadoC;
            return area3;
        }
    }
}
