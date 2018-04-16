using ConsoleApplication1.Classes.CriadoresAbstratos;
using ConsoleApplication1.Classes.ProdutosConcretos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Classes.CriadoresConcretos
{
    class Curriculo : Documento
    {
        public override void CriarPaginas()
        {
            Paginas.Add(new PaginaHabilidades());
            Paginas.Add(new PaginaEducacao());
            Paginas.Add(new PaginaExperiencia());
        }
    }
}
