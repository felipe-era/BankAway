using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAway_Modelos.BankAway.Modelos.ADM.Utilitario
{
    internal class AutenticacaoUtil
    {
        public bool ValidarSenha(string senhaverdadeira, string senhatentativa)
        {
            return senhaverdadeira.Equals(senhatentativa);
        }
    }
}
