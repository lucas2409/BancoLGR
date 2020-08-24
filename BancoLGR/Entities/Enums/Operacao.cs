using System;
using System.Collections.Generic;
using System.Text;

namespace BancoLGR.Entities.Enums
{
    enum Operacao : int
    {
        criarConta =1,
        excluirConta =2
    }
    enum Operacao2 : int
    {
        Saque =1,
        Transferencia = 2,
        Deposito = 3
    }
}
