using System;

namespace ConsumoVeiculo.ConsoleApp
{
     public class TesteConsumoVeiculo
     {
        
        static void Main(string[] args)
        {

            ConsumoVeiculo veiculo = new ConsumoVeiculo();

            veiculo.kilometragemInicial = 100;
            veiculo.kilometragemFinal = 300;
            veiculo.consumo = 52;

            veiculo.ObterConsumoPorKilometro();
            
        }

        

    }

     public class ConsumoVeiculo
     {
        public double kilometragemInicial;
        public double kilometragemFinal;  
        public double consumo;
        

        public void ObterConsumoPorKilometro()
        {

        double distanciaPercorrida = kilometragemFinal - kilometragemInicial;

        double gasto = distanciaPercorrida / consumo;

            Console.WriteLine("O a distancia percorrida é: " + distanciaPercorrida );
            Console.WriteLine("O gasto por km é : " + gasto);
            Console.ReadLine();

        }

    }
}
