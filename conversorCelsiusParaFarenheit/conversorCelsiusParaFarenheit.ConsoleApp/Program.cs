using System;

namespace conversorCelsiusParaFarenheit.ConsoleApp
{
    public class TesteConversorCelsiusParaFarenheit
    {
        static void Main(string[] args)
        {
            //instancia


            ConversorCelsiusParaFarenheit ConversorCelsius = new ConversorCelsiusParaFarenheit();

            ConversorCelsius.celsius = 5;

            ConversorCelsius.MetodoConversorCelsiusParaFarenheit();

            
        }
    }
    public class ConversorCelsiusParaFarenheit
    {
        //caracteristicas

        public double celsius;



        public void MetodoConversorCelsiusParaFarenheit()
        {
            double resultadoConversorCelsiusParaFarenheit = (celsius * 1.8) + 32 ;
            Console.WriteLine(celsius + " º graus celsius é igual a " + resultadoConversorCelsiusParaFarenheit + " F");
            Console.ReadLine();

        }

    }
}
