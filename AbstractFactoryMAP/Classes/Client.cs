using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DPAbstractFactory.Classes.Abstratas;

namespace DPAbstractFactory.Classes
{
    class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        // Construtor
        public Client(AbstractFactory factory)
        {
            _abstractProductB = factory.CriarProdutoB();
            _abstractProductA = factory.CriarProdutoA();
        }
        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
