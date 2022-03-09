using System;

namespace Vendedor.ConsoleApp
{
    public class TesteVendedorSalarioTotal
    {
        static void Main(string[] args)
        {
            VendedorSalarioTotal vendedor = new VendedorSalarioTotal();

            vendedor.salarioBase = 2500.00;
            vendedor.totalVendas = 10000.00;
            vendedor.comissao = 0.05 * vendedor.totalVendas;

            vendedor.ObterSalarioTotal();
            
        }
    }

    public class VendedorSalarioTotal
    {
        public double salarioBase;
        public double totalVendas;
        public double comissao;

        public void ObterSalarioTotal() 
        {

            double salarioTotal = comissao + salarioBase;
            Console.WriteLine("A comissao do vendedor é : " + comissao.ToString("C") + "\nO salario total com a comissao é : " + salarioTotal.ToString("C"));
            Console.ReadLine();
        }
    }
}
