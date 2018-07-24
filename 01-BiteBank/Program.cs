using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BiteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela H.";
            contaDaGabriela.numero =  863452;
            contaDaGabriela.agencia = 364;
            contaDaGabriela.saldo = 1000;

            Console.WriteLine("Dados da conta de: " + contaDaGabriela.titular);

            Console.WriteLine("Titular: " + contaDaGabriela.titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Numero " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: R$" + contaDaGabriela.saldo);


            Console.ReadLine();
                
        }
    }
}
