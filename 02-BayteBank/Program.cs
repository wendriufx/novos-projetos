using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BayteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para iniciar, Tecle 1");
            var acao = Console.ReadLine();
            while (acao == "1")
            {
                ContaCorrente contaDoBruno = new ContaCorrente();

                contaDoBruno.titular = "Bruno";

                Console.WriteLine(contaDoBruno.saldo);

                bool resultadoSaque = contaDoBruno.Sacar(500);

                Console.WriteLine(contaDoBruno.saldo);
                Console.WriteLine(resultadoSaque);

            
                Console.WriteLine("Para continuar, Tecle 1");

                acao = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}