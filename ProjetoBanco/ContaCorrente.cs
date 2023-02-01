using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



    public class ContaCorrente
    {
         public string nome;
        public string conta;
       public  int agencia;
       public double saldo;

    public void Depositar(double valor)
    {
       this.saldo += valor;
    }

    public void sacar(double valor)
    { this.saldo -= valor; 
    }

    }


