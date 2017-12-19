using System;

namespace Padroes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Factory.Factory factory = new Factory.Factory();
            Abstract.Abstract abstrac = new Abstract.Abstract();

            Console.ReadKey();
        }
    }
}