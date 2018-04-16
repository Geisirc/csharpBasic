using ConsoleApplication1.Classes.ProdutosAbstratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Classes.CriadoresAbstratos
{
    abstract class Documento
    {
        private List<Pagina> listaDePaginas = new List<Pagina>();

        public Documento()
        {
            this.CriarPaginas();
        }
        public List<Pagina> Paginas
        {

            get { return listaDePaginas; }

        }

        public abstract void CriarPaginas();

    }
}
