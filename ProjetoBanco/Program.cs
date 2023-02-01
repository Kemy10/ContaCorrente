using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class Program
    {
        static void Main(string[] args)
        {
           // ContaCorrente conta1 = new ContaCorrente();
           // conta1.nome = "Astolfo";
           // conta1.conta = "2055-X";
           // conta1.agencia = 5;
           // conta1.saldo = 500.00;
            //Console.WriteLine("O saldo anterior é: R$ " + conta1.saldo);
            //conta1.Depositar(300.00);
            //Console.WriteLine("O saldo depois do deposito é: R$ " + conta1.saldo);

            //Console.WriteLine("O saldo disponível na sua conta é: R$ "+ conta1.saldo);
            //Console.WriteLine("O número de sua conta é: " + conta1.conta);
            //Console.WriteLine("O número da sua agencia é: " + conta1.agencia);
           // Console.WriteLine("O valo do seu saldo é R$" + conta1.saldo);


            ContaCorrente conta2 = new ContaCorrente();
            conta2.nome = "Kemy";
            conta2.conta = "3858-0";
            conta2.agencia = 8;
            conta2.saldo = 970;
            Console.WriteLine("O saldo da sua conta antes do saque é de: R$ " + conta2.saldo);
            conta2.sacar(200);
            Console.WriteLine("O saldo sa sua conta após o saque é de: R$ " + conta2.saldo);
        }
    }
}
