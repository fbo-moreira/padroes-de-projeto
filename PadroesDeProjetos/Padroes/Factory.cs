using System;

namespace Padroes.Factory
{
    public class Factory
    {
        public Factory()
        {
            var palio = new FabricaFiat().criarCarro();
            var gol = new FabricaVolkswagem().criarCarro();

            palio.exibirInfo();
            gol.exibirInfo();
        }
    }

    public interface ICarro
    {
        void exibirInfo();
    }

    public interface IFabricaDeCarro
    {
        ICarro criarCarro();
    }

    public class FabricaFiat : IFabricaDeCarro
    {
        public ICarro criarCarro()
        {
            return new Palio();
        }
    }

    public class Palio : ICarro
    {
        public void exibirInfo()
        {
            Console.WriteLine("Modelo: Palio\nFabricante: Fiat");
        }
    }

    public class FabricaVolkswagem : IFabricaDeCarro
    {
        public ICarro criarCarro()
        {
            return new Gol();
        }
    }

    public class Gol : ICarro
    {
        public void exibirInfo()
        {
            Console.WriteLine("Modelo: Gol\nFabricante: VW");
        }
    }
}