﻿using BankAway.Modelos.ADM.Funcionarios;
using BankAway_ATENDIMENTO.BankAway.Atendimento;
using BankAway_Modelos.BankAway.Modelos.ADM.Utilitario;

Console.WriteLine("Boas Vindas ao BankAway, Atendimento.");
new BankAwayAtendimento().AtendimentoCliente();

public class Estagiario : Funcionario
{
    public Estagiario(double salario, string cpf) : base(salario, cpf)
    {
    }

    public override void AumentarSalario()
    {
        throw new NotImplementedException();
    }

    internal override double getBonificacao()
    {
        throw new NotImplementedException();
    }
}

