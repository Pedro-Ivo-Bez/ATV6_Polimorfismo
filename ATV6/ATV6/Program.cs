using System;

namespace ATV6
{
    class Program
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia();
            Conta b = new Conta(01, 12, "Pedro Ivo", "090.749.739-06", 3000);
            ContaCorrente c = new ContaCorrente(05, 19, "Andre", "123.456.789-10", 3000);
            ContaCorrenteEspecial d = new ContaCorrenteEspecial(02, 10, "Ivan", "123.123.123-12", 1000, 200);
            ContaPoupanca e = new ContaPoupanca(03, 14, "Maeda", "111.111.111-11", 2000, 12);
            BancoConsole i = new BancoConsole();

            i.Menu();
        }
    }
}
