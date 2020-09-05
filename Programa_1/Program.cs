using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Evaluar si es par o impar

            Console.WriteLine("ESTE PROGRAMA EVALUA SI EL NUMERO ES PAR E IMPAR");
            Console.ReadLine();

            double numero;

            Console.WriteLine("Digite un numero");
            numero = Convert.ToDouble(Console.ReadLine());

            if ((numero % 2)== 0 )
            {
                Console.WriteLine("El numero digitado es par : "   + numero);
            }
            else
            {
                Console.WriteLine("El numero digitado es impar : "  + numero);
            }
            Console.ReadKey();

        }
    }
}
