using System;

namespace Padroes.Abstract
{
    internal class Abstract
    {
        public Abstract()
        {
            IFabricaDeCarro fabrica = new FabricaFiat();
            ICarroSedan sedan = fabrica.criarCarroSedan();
            ICarroPopular popular = fabrica.criarCarroPopular();
            sedan.exibirInfoSedan();
            Console.WriteLine();
            popular.exibirInfoPopular();
            Console.WriteLine();

            fabrica = new FabricaFord();
            sedan = fabrica.criarCarroSedan();
            popular = fabrica.criarCarroPopular();
            sedan.exibirInfoSedan();
            Console.WriteLine();
            popular.exibirInfoPopular();
        }
    }

    public interface IFabricaDeCarro
    {
        ICarroSedan criarCarroSedan();

        ICarroPopular criarCarroPopular();
    }

    public class FabricaFiat : IFabricaDeCarro
    {
        public ICarroSedan criarCarroSedan()
        {
            return new Siena();
        }

        public ICarroPopular criarCarroPopular()
        {
            return new Palio();
        }
    }

    public class FabricaFord : IFabricaDeCarro
    {
        public ICarroSedan criarCarroSedan()
        {
            return new KaSedan();
        }

        public ICarroPopular criarCarroPopular()
        {
            return new FordKa();
        }
    }

    public interface ICarroPopular
    {
        void exibirInfoPopular();
    }

    public interface ICarroSedan
    {
        void exibirInfoSedan();
    }

    public class Palio : ICarroPopular
    {
        public void exibirInfoPopular()
        {
            Console.WriteLine("Modelo: Palio\nFábrica: Fiat\nCategoria:Popular");
        }
    }

    public class Siena : ICarroSedan
    {
        public void exibirInfoSedan()
        {
            Console.WriteLine("Modelo: Siena\nFábrica: Fiat\nCategoria:Sedan");
        }
    }

    public class FordKa : ICarroPopular
    {
        public void exibirInfoPopular()
        {
            Console.WriteLine("Modelo: Ford Ka\nFábrica: Ford\nCategoria:Popular");
        }
    }

    public class KaSedan : ICarroSedan
    {
        public void exibirInfoSedan()
        {
            Console.WriteLine("Modelo: Ka Sedam\nFábrica: Ford\nCategoria:Sedan");
        }
    }
}