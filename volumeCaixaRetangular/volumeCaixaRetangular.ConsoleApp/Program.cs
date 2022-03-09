using System;

namespace volumeCaixaRetangular.ConsoleApp
{
    public class TestaCaixa
    {
        static void Main(string[] args)
        {

            //instancia
            Caixa caixaRetangular = new Caixa();

            caixaRetangular.altura = 2;
            caixaRetangular.comprimento = 5;
            caixaRetangular.largura = 7;

            caixaRetangular.ContaVolume();
            
            

        }

        public class Caixa {

            //caracteristicas, atributos

            public int altura;
            public int comprimento;
            public int largura;
            
            //metodos, açoes


            public void ContaVolume()
            {
                

                double resultadoVolume =  comprimento * largura * altura ;
                Console.WriteLine("Volume do retangulo: " + resultadoVolume.ToString("F"));
                Console.ReadLine();
            }


        }


    }
}

