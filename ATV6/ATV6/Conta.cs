using System;
using System.Collections.Generic;
using System.Text;

namespace ATV6
{
    public class Conta
    {
        int _Agencia;
        int _Numero;
        string _Nome;
        string _Cpf;
        float _Valor;

        public int Agencia { get => _Agencia; set => _Agencia = value; }
        public int Numero { get => _Numero; set => _Numero = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Cpf { get => _Cpf; set => _Cpf = value; }
        public float Valor { get => _Valor; set => _Valor = value; }

        public Conta (int agencia, int numero, string nome, string cpf, float valor)
        {
            _Agencia = agencia;
            _Numero = numero;
            _Nome = nome;
            _Cpf = cpf;
            _Valor = valor;
        }

        public bool Sacar(float valor)
        {
            return true;
        } 

        public bool Depositar (float valor)
        {
            return true;
        }
    }
}
