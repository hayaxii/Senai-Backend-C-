using System;

namespace Aula_3_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int cont = 0;

            do{
                Console.WriteLine("Digite o numero: ");

                numero = int.Parse(Console.ReadLine() );

                cont++;

                if (numero /3 ==0)
                {
                    numero = numero + 1;

                }

            }while(cont <=20);
               Console.WriteLine("Os multiplos de são: " + numero);


        }
    }
}
