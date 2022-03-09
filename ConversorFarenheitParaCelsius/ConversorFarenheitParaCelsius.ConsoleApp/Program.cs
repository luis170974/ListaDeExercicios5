using System;

namespace ConversorFarenheitParaCelsius.ConsoleApp
{
    public class TestaConversor
    {
        static void Main(string[] args)
        {
            //instancia

            Console.WriteLine("Bem vindo!");

            ConversorFarenheitParaCelsius ConversorFarenheit = new ConversorFarenheitParaCelsius();

            ConversorFarenheit.farenheit = 2;

            ConversorFarenheit.MetodoConversorFarenheitParaCelsius();

            
        }
    }

        public class ConversorFarenheitParaCelsius
        {
        //caracteristicas

        public double farenheit;
        
        

        public void MetodoConversorFarenheitParaCelsius()
        {
            double resultadoConversorFarenheitParaCelsius = (farenheit - 32) / 1.8;
            Console.WriteLine(farenheit + " F é igual a " + resultadoConversorFarenheitParaCelsius + " º graus celsius");
            Console.ReadLine();

        }
        
        }
}
