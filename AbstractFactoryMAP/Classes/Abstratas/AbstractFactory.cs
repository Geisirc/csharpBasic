using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPAbstractFactory.Classes.Abstratas
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CriarProdutoA();
        public abstract AbstractProductB CriarProdutoB();
    }
}
