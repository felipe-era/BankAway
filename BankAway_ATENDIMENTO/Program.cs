using BankAway_ATENDIMENTO.BankAway.Atendimento;
using BankAway_Modelos.BankAway.Modelos.ADM.Utilitario;

Console.WriteLine("Boas Vindas ao BankAway, Atendimento.");
new BankAwayAtendimento().AtendimentoCliente();

AutenticacaoUtil autenticador = new AutenticacaoUtil();