using BankAway.Modelos.ADM.Funcionarios;
using BankAway_ATENDIMENTO.BankAway.Atendimento;
using BankAway_GeradorChavePix;
using BankAway_Modelos.BankAway.Modelos.ADM.Utilitario;

Console.WriteLine("Boas Vindas ao BankAway, Atendimento.");
//new BankAwayAtendimento().AtendimentoCliente();

Console.WriteLine(GeradorPix.GetChavePix());

var listaDeChaves = GeradorPix.GetChavePix(10);

foreach (var chave in listaDeChaves)
{
    Console.WriteLine(chave);

}


////testes proteção de classes //processo correto
//public class Estagiario : Funcionario
//{
//    public Estagiario(double salario, string cpf) : base(salario, cpf)
//    {
//    }

//    public override void AumentarSalario()
//    {
//        throw new NotImplementedException();
//    }

//    protected internal override double getBonificacao()
//    {
//        throw new NotImplementedException();
//   }


