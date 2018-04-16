using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DPAbstractFactory.Classes;
using DPAbstractFactory.Classes.Abstratas;
using DPAbstractFactory.Classes.Concretas;

namespace DPAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            // Fábrica Abstrata 1
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Fábrica Abstrata 2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();
            
            Console.ReadKey();

        }
    }
}
