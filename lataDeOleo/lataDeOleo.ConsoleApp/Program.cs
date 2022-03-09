using System;

namespace lataDeOleo.ConsoleApp
{
    public class TesteLataDeOleo
    {
        static void Main(string[] args)
        {
            LataDeOleo cilindroLataDeOleo = new LataDeOleo();

            cilindroLataDeOleo.pi = 3.14;
            cilindroLataDeOleo.raio = 8;
            cilindroLataDeOleo.raioAoQuadrado = cilindroLataDeOleo.raio * cilindroLataDeOleo.raio;
            cilindroLataDeOleo.altura = 10;

            cilindroLataDeOleo.VolumeCilindro();
        }
    }

    public class LataDeOleo
    {
        public double pi;
        public double raio;
        public double raioAoQuadrado;
        public double altura;

        public void VolumeCilindro()

        {
            double resultadoVolumeLataDeOleo = pi * raioAoQuadrado * altura;
            
            Console.WriteLine("O volume da lata de oleo é : " + resultadoVolumeLataDeOleo.ToString("F"));
            Console.ReadLine();
        }
    }
}
