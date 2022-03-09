using System;

namespace VolumeCilindro.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Cilindro cilindro = new Cilindro();

            cilindro.pi = 3.14;
            cilindro.raio = 5;
            cilindro.raioAoQuadrado = cilindro.raio * cilindro.raio;
            cilindro.altura = 7;

            cilindro.VolumeCilindro();
            
        }
    }

        public class Cilindro
        {

        public double pi;
        public double raio;
        public double raioAoQuadrado;
        public double altura;

        public void VolumeCilindro()

        {
            double resultadoVolumeCilindro = pi * raioAoQuadrado * altura;
            Console.WriteLine("O volume do cilindro é : " + resultadoVolumeCilindro.ToString("F"));
            Console.ReadLine();
        }
    }
}
