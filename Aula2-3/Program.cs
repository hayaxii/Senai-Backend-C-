using System;

namespace Aula2_3
{
    class Program
    {
        static void Main(string[] args)
        {   

            //Deixamos desclarada como falsa por padrão
            bool entrada = false;
            int idade;
            string retorno = "Entrada nao permitida";

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine() );

            //Como ja atribuimos anteriormente, mudamos o estado
            //estado da variavel para verdadeira caso
            //entre nessa condição
            if (idade >17){
                entrada = true;            }

            if (entrada == true){
                retorno = "Entrada Permitida!!!";
            }else{
                retorno = "Entrada não permitida :( ";
            }

            Console.WriteLine(retorno);    
        }

    }
}
