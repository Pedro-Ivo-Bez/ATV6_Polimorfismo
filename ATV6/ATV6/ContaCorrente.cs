using System;
using System.Collections.Generic;
using System.Text;

namespace ATV6
{
    public class ContaCorrente : Conta
    {
        
        public ContaCorrente(int agencia, int numero, string nome, string cpf, float valor) : base(agencia, numero, nome, cpf, valor)
        {
            Agencia = agencia;
            Numero = numero;
            Nome = nome;
            Cpf = cpf;
            Valor = valor;
        }

    }
}
