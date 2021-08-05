using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    public class Program
    {
        //            Questão 25 - Faça o algoritmo (repositório no github ou azure devops, em c#):
        //2520 é o menor número que pode ser dividido por cada um dos números de 1 a 10 sem
        //qualquer resto.Qual é o menor número positivo que é divisível por todos os números de 1
        //a 20 -> 232.792.560 ?
        static void Main(string[] args)
        {
            Int64 x = MMC(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20);

            Console.WriteLine(x);
            Console.ReadKey();
        }
        public static Int64 MMC(IList<Int64> numeros)
        {
            return MMC(numeros, 0);
        }

        public static Int64 MMC(params Int64[] numeros)
        {
            return MMC((IList<Int64>)numeros);
        }
        private static Int64 MMC(IList<Int64> numeros, int i)
        {
            // Recursividade usando seguinte lógica: MMC(a,b,c) = MMC(a,MMC(b,c))

            if (i + 2 == numeros.Count)
            {
                return MMC(numeros[i], numeros[i + 1]);
            }
            else
            {
                return MMC(numeros[i], MMC(numeros, i + 1));
            }
        }
        public static Int64 MMC(Int64 a, Int64 b)
        {
            return (a * b / MDC(a, b));
        }
        public static Int64 MDC(Int64 a, Int64 b)
        {

            Int64 t;
            while (b != 0)
            {
                t = b;
                b = a % b;
                a = t;
            }
            return a;
        }


    }
}
