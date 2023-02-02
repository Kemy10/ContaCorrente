using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ProjetoBanco;



public class ContaCorrente
{
    public string nome;
    public string conta;
    public int agencia;
    public double saldo;
    public double valorTranferencia;

    public bool Sacar(double valor)
    {
        if (this.saldo >= valor)
        {
            this.saldo -= valor;
            return true;
        }
        else
        {
            Console.WriteLine("Saldo " +
                "insuficiente para realizar o saque.");
            return false;
        }
    }

        public void Depositar(double valor)
        { 
            this.saldo += valor;
        }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {

        if (this.saldo >= valor)
        {
            valorTranferencia = valor;
            this.saldo -= valor;
            contaDestino.saldo += valor;
            return true;
        }
        else
        {
            Console.WriteLine("Não foi possível relizar a transferência. O saldo é insuficiente.");
                return false;
        }

       
    }

    
}


