﻿using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Declaramos as notas que utilizaremos
            double nota1, nota2, nota3, media;
            
            //Capturamos a primeira nota
            Console.Write("Digite sua primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            //Capturamos a segunda nota
            Console.Write("Digite sua segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            //Capturamos a terceira nota
            Console.Write("Digite sua terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            //Calculamos a media das notas
            media = (nota1 + nota2+ nota3)/3;

            //Verificamos se a media do aluno é maior ou igual a 6
            if (media>=6){

                Console.WriteLine($"Media: {media} Aluno Aprovado!");
            
            } else {
                Console.WriteLine($"Media: {media} Aluno Reprovado!");
                
            }
        }   
    }
}
