using ConsoleApplication1.Classes.CriadoresAbstratos;
using ConsoleApplication1.Classes.CriadoresConcretos;
using ConsoleApplication1.Classes.ProdutosAbstratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Documento[] listaDeDocumentos = new Documento[2];

            listaDeDocumentos[0] = new Curriculo();
            listaDeDocumentos[1] = new Relatorio();

            foreach(Documento documento in listaDeDocumentos)
            {
                Console.WriteLine("\n" + documento.GetType().Name + "--");
                foreach(Pagina pagina in documento.Paginas)
                {
                    Console.WriteLine(" " + pagina.GetType().Name);
                }
            }

            Console.ReadKey();

        }
    }
}
