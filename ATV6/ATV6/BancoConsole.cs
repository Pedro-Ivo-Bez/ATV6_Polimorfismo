using System;
using System.Collections.Generic;
using System.Text;

namespace ATV6
{
    class BancoConsole
    {

        public void Menu()
        {
            Console.WriteLine("Digite a Agencia: ");
            int ag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Numero: ");
            int nmr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Nome: ");
            string nom = Console.ReadLine();
            Console.WriteLine("Digite o CPF: ");
            string CPF = Console.ReadLine();
            Console.WriteLine("Digite o Valor");
            float val = Convert.ToInt32(Console.ReadLine());

            Agencia b = new Agencia();
            b.AdicionarConta(ag, nmr, nom, CPF, val);

        }
    }
}
