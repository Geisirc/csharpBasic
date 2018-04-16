using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DPAbstractFactory.Classes.Abstratas;

namespace DPAbstractFactory.Classes.Concretas
{
    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine("Produto B1 " +
            " interage com Produto A1");
        }
    }
}
