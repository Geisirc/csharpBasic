using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* @autor Geisirc
 * Iniciando exercicios de Fixacao do Curso de C# Básico
 * 25 fev 2018
 */
namespace CursoNeriBasico
{
    class Program
    {
        //Classe Principal
        static void Main(string[] args)
        {
            //Declarando variaveis
            String MyName = "Gerc";
            String country = "Brazilian";
            Int16 year = 2018;

            //Imprimindo cabecalho
            Console.WriteLine("***********************************************************");
            Console.WriteLine("        Hello Windows - My First Program ");
            Console.WriteLine("***********************************************************\n");
          
            //Exibindo resultado da variáeis na saida do sistema
            Console.WriteLine("Hi! my name is " + MyName + " and, I'am " + country + ", it's " + year + ".");
            Console.ReadKey();
        }
    }
}
