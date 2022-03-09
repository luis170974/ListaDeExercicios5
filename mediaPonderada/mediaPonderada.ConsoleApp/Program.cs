using System;

namespace mediaPonderada.ConsoleApp
{
  public class TesteMediaPonderadaAluno
  {
        static void Main(string[] args)
        {
            MediaPonderada aluno = new MediaPonderada();

            aluno.notaProvaUm = 8.0;
            aluno.notaProvaDois = 7.5;
            aluno.pesoProvaUm = 10;
            aluno.pesoProvaDois = 9;

            aluno.ObterMediaPonderada();
        }
  }

  public class MediaPonderada
    {
        //atributos
        public double notaProvaUm;
        public double notaProvaDois;
        public int pesoProvaUm;
        public int pesoProvaDois;

    public void ObterMediaPonderada()
    {
         double resultadoMediaPonderada = (notaProvaUm * pesoProvaUm + notaProvaDois * pesoProvaDois) / (pesoProvaUm + pesoProvaDois);
         Console.WriteLine("A média ponderada é: " + resultadoMediaPonderada.ToString("F"));
         Console.ReadLine();
    }
  }
}
