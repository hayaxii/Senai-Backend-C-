using System;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] media = new double[10];

            for(int i = 0; i <= 9; i++){

                Console.Write("Digite uma média: ");
                media[i] = double.Parse(Console.ReadLine() );
                
            }

                Console.WriteLine(media [3] );
                Console.WriteLine();

                for(int i = 0 ; i <= media.Length - 1 ; i++){ // Quando o incide for menor que media ele conta -1 ou i <media 

                    Console.WriteLine("Média : " + media[1] );
                }
        }
    }
}
