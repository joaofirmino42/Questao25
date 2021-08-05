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
        //a 20 ?
        static void Main(string[] args)
        {
            CalcularMenorMultiploComum();
        }
        public static void CalcularMenorMultiploComum()
        {
            int num1, num2, x, y, mmc = 0;

            Console.Write("Informe o primeiro número : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo número : ");
            num2 = int.Parse(Console.ReadLine());
            x = num1;
            y = num2;
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }
            mmc = (x * y) / num1;
            Console.Write("\nO Menor múltiplo Comum entre : ");
            Console.WriteLine("{0} e {1} é {2}", x, y, mmc);
            Console.ReadLine();

        }
    }
}
