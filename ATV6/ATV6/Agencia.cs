using System;
using System.Collections.Generic;
using System.Text;

namespace ATV6
{
    class Agencia
    {
        List<Conta> _contas;
        public List<Conta> Contas { get => _contas; set => _contas = value; }

        public void AdicionarConta(int agencia, int numero, string nome, string cpf, float valor)
        {
            Conta b = new Conta(agencia, numero, nome, cpf, valor);
            Contas = new List<Conta>();
            Contas.Add(b);

            foreach(Conta a in Contas)
            {
                Console.WriteLine($"{a.Agencia} || {a.Numero} || {a.Nome} || {a.Cpf} || {a.Valor}");
            }
        }

        public bool FecharConta()
        {
            return true;
        }
    }
}
