using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DPAbstractFactory.Classes.Abstratas;

namespace DPAbstractFactory.Classes.Concretas
{
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CriarProdutoA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CriarProdutoB()
        {
            return new ProductB2();
        }
    }
}
