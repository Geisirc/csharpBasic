using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBAbstractFactory3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criar Fabricante FIAT e executar a montagem do Chassi Fiat com o Motor da Fiat
            FabricanteAutomoveis fiat = new Fiat();
            Montadora montadora = new Montadora(fiat);
            montadora.MontarChassi();
            
            // Cria Fabricante VOLKS e executa a montagem do Chassi Volks com o Motor da Volks
            FabricanteAutomoveis volks = new Volks();
            montadora = new Montadora(volks);            
            montadora.MontarChassi();
            
            
            
            //===========================================================

            Console.ReadKey();

        }
    }
}
