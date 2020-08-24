using System;
using System.Globalization;
using BancoLGR.Entities;
using BancoLGR.Entities.Enums;

namespace BancoLGR
{
    class Program
    {
        static void Main(string[] args)
        {
            int validador = 1;

            while (validador == 1)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine("------------------------------- Bem vindo ao LGR Bank - Terminal ------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine("Você é administrador ou é um cliente:");
                Acesso tipoAcesso = Enum.Parse<Acesso>(Console.ReadLine());
                //tudo o que for pertinente ao banco
                if (tipoAcesso == Acesso.administrador)
                {
                    Admin adm = new Admin();
                    adm.iniciarAdmin();
                }
                //tudo o que for pertinente ao cliente
                else if (tipoAcesso == Acesso.cliente)
                {
                    Admin adm = new Admin();
                    adm.iniciarCli();
                }
                Console.WriteLine("Digite 1 para continuar ou 2 para encerrar.");
                validador = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Tecle qualquer tecla para encerrar");
        }
    }
}
