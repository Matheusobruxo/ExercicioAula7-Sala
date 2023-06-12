using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula7_Sala
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
        }

        void exemplo()
        {
            double numero;
            Console.WriteLine("Digite um numero:");
            numero = double.Parse(Console.ReadLine());

            if (numero > 10)
            {
                numero = numero * 0.1;
            }
            Console.WriteLine($"O número é: {numero}");
            Console.ReadKey();
        }
        void exercicio1()
        {
            // Atividade do livro páginas 77 e 78

            double numero;
            Console.WriteLine("Digite um numero:");
            numero = double.Parse(Console.ReadLine());

            if (numero > 100)
            {
                numero = numero + 150;
            }
            Console.WriteLine($"O número é: {numero}");
            Console.ReadKey();
            Console.Clear();
            Main(null);
        }
        void exercicio2()
        {
            // Atividade do livro página 81 e continuação na página 84.
            double nota1, nota2, media;
            Console.WriteLine("Digite a nota 1:");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2:");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media > 6)
            {
                Console.WriteLine("Sua nota é superior a média mínima (6) ");
                Console.ReadKey();
            }
            else if (media == 6)
            {
                Console.WriteLine("Sua nota é igual a média mínima (6) ");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Sua nota é inferior a média mínima (6) ");
                Console.ReadKey();
            }
        }
        void exercicio3()
        {
            // Atividade do livro página 87
            int nota1, nota2, nota3;

            Console.WriteLine("Digite o numero 1:");
            nota1 = int.Parse(Console.ReadLine());
            if (nota1 < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            Console.WriteLine("Digite o numero 2:");
            nota2 = int.Parse(Console.ReadLine());
            if (nota2 < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            Console.WriteLine("Digite o numero 3:");
            nota3 = int.Parse(Console.ReadLine());
            if (nota3 < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            if (nota1 > nota2 && nota1 > nota3)
            {
                Console.WriteLine($"Sua maior nota foi a {nota1}!");
                Console.ReadKey();
            }
            else if (nota2 > nota1 && nota2 > nota3)
            {
                Console.WriteLine($"Sua maior nota foi a {nota2}!");
                Console.ReadKey();
            }
            else if (nota3 > nota2 && nota3 > nota1)
            {
                Console.WriteLine($"Sua maior nota foi a {nota3}!");
                Console.ReadKey();

            }
        }
    }

}


