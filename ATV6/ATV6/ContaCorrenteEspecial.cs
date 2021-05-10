using System;
using System.Collections.Generic;
using System.Text;

namespace ATV6
{
    public class ContaCorrenteEspecial : ContaCorrente
    {
        float _LimiteChequeEspecial;
        public float LimiteChequeEspecial { get => _LimiteChequeEspecial; set => _LimiteChequeEspecial = value; }

        public ContaCorrenteEspecial(int agencia, int numero, string nome, string cpf, float valor, float ChequeLimite) : base (agencia, numero, nome, cpf, valor)
        {
            _LimiteChequeEspecial = ChequeLimite;
        }
    }
}
