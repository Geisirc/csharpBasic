using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DPAbstractFactory.Classes.Abstratas;

namespace DPAbstractFactory.Classes.Concretas
{
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CriarProdutoA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CriarProdutoB()
        {
            return new ProductB1();
        }
    }
}
