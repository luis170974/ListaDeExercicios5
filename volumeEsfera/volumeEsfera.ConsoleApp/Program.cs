using System;

namespace volumeEsfera.ConsoleApp
{
    public class TesteEsfera
    {
        static void Main(string[] args)
        {
            ObterVolumeEsfera esfera = new ObterVolumeEsfera();

            esfera.pi = 3.14;
            esfera.raio = 3;
            esfera.raioAoCubo = esfera.raio * esfera.raio * esfera.raio;


            esfera.VolumeEsfera();
            
        }
    }

    public class ObterVolumeEsfera
    {
        public double pi;
        public double raio;
        public double raioAoCubo;

        public void VolumeEsfera()

        {
            double resultadoVolumeEsfera = (4 * pi * raioAoCubo) / 3;
            Console.WriteLine("O volume do cilindro é : " + resultadoVolumeEsfera.ToString("F"));
            Console.ReadLine();

        }
    }
}
