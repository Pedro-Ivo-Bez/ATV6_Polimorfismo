using System;
using System.Collections.Generic;
using System.Text;

namespace ATV6
{
    public class ContaPoupanca : Conta
    {
        float _Juros;
        public float Juros { get => _Juros; set => _Juros = value; } 

        public ContaPoupanca(int agencia, int numero, string nome, string cpf, float valor, float juros) : base(agencia, numero, nome, cpf, valor)
        {
            Juros = juros;
        }
        void Render(int meses)
        {

        }

    }
}
