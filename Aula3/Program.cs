using System;

namespace Aula3 {
    class Program {
        static void Main (string[] args) {
            /* 
            //LANÇO CONTATO = FOR - INCREMENTO (+)
            for (int cont = 1; cont <= 100; cont++) {

            //Verificamos se o número é diferente de par
                if (cont % 2 != 0) {
                    Console.WriteLine ("FOR DE 0-100 " + cont);
                }
            }

            //LANÇO CONTATO = FOR - INCREMENTO (-)
            for (int cont = 100; cont >= 0; cont--) {

                //Verificamos se o número é diferente de par
                if (cont % 2 != 0) {
                    Console.WriteLine ("FOR DE 100-0 " + cont);
                }

            //LAÇOS CONDICIONAL - WHILE
            */

            double acumuladora = 0;
            double nota = 0;
            int cont = 0;
            string sair = "";

            while (sair != "sair") {

                Console.WriteLine ("Digite a nota de um aluno: ");
                nota = double.Parse (Console.ReadLine ());

                acumuladora += nota;
                cont++;

                Console.Write ("Deseja sair da aplicacao? sim/nao ");
                sair = Console.ReadLine ().ToLower ();

            }

            Console.WriteLine ("Media das notas : " + (acumuladora / cont));

        }
    }
}