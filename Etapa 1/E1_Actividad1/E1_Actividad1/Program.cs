using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1_Actividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Altura: ");

            int altura = int.Parse(Console.ReadLine());

            while(altura < 0 || altura > 25)
            {
                Console.Write("Altura: ");
                altura = int.Parse(Console.ReadLine());
            }

            int aux = altura;

            for(int i = 0; i < altura; i++)
            {
                Console.WriteLine();
                for(int j = aux-1; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                aux--;
                for(int k = 0; k <= i; k++)
                {
                    Console.Write("#");
                }
            }

            Console.ReadLine();

        }
    }
}
