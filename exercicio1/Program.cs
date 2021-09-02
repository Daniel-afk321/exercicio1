using System;
using System.Globalization;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Triangulo = classe
            Triangulo X;
            Triangulo Y;

            //instanciar a variavel 
            X = new Triangulo();
            Y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo x:");
            X.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //===================================================================
            Console.WriteLine("Entre com as medidas do triangulo Y:");
            Y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // formula do Triangulo X
            double p = (X.A + X.B + X.C) / 2.0;
            double areaX = Math.Sqrt(p * (p = X.A) * (p = X.A) * (p = X.A));
            //==============================================================
            // formula do Triangulo Y
            double e = (Y.A + Y.B + Y.C) / 2.0;
            double areaY = Math.Sqrt(e * (e = Y.A) * (e = Y.A) * (e = Y.A));

            if ( areaX > areaY)
            {
                Console.WriteLine("Area de X é maior que Y = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            }else if (areaY > areaX)
            {
                Console.WriteLine("Area de Y é maior que X = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            }
           
        }
    }
}
