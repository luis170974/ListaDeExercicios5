using System;

namespace mediaHarmonica.ConsoleApp
{
    public class TesteMediaHarmonica
    {
        static void Main(string[] args)
        {
            MediaHarmonica aluno = new MediaHarmonica();

            aluno.notaUm = 8.0;
            aluno.notaDois = 7.5;
            aluno.notaTres = 9.0;
            aluno.notaQuatro = 6.5;

            aluno.ObterMediaHarmonica();

        }
    }

    public class MediaHarmonica
    {
        public double notaUm;
        public double notaDois;
        public double notaTres;
        public double notaQuatro;

        public void ObterMediaHarmonica()
        {
            double resultadoMediaHarmonica = (4/((1/notaUm) + (1/notaDois) + (1/notaTres) + (1 / notaQuatro)));

            Console.WriteLine("A media Harmonica: " + resultadoMediaHarmonica.ToString("F"));
            Console.ReadLine();
        }

    }
}
