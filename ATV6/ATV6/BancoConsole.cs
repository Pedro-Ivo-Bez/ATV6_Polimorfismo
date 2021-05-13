using System;
using System.Collections.Generic;
using System.Text;

namespace ATV6
{
    class BancoConsole
    {

        public void Menu()
        {
            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("___________________BANCO___________________\n " +
                    "\n" +
                    "1- Adicionar Conta: \n" +
                    "2- Fechar Conta: \n" +
                    "3- Sacar: \n" +
                    "4- Depositar: \n" +
                    "5- Render: \n" +
                    "\n" +
                    "__________________________________________");
                int a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.WriteLine("");
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
                        Console.WriteLine("");
                        b.AdicionarConta(ag, nmr, nom, CPF, val);
                        Console.WriteLine("");
                        break;
                    case 2:
                        break;

                }

                Console.WriteLine("Se desejar sair digite 'S' \n" +
                    "\n" +
                    "Se desejar prosseguir digite 'N' ");
                string s = Console.ReadLine();
                if (s == "S")
                {
                    i = -1;
                }
                else
                {
                    i = 1;
                }
            }

        }
    }
}
