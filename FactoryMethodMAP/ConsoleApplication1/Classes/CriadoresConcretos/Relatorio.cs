using ConsoleApplication1.Classes.CriadoresAbstratos;
using ConsoleApplication1.Classes.ProdutosConcretos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Classes.CriadoresConcretos
{
    class Relatorio : Documento
    {
        public override void CriarPaginas()
        {
            Paginas.Add(new PaginaIntroducao());
            Paginas.Add(new PaginaResultados());
            Paginas.Add(new PaginaConclusao());
            Paginas.Add(new PaginaResumo());
            Paginas.Add(new PaginaBibliografica());
        }
    }
}
