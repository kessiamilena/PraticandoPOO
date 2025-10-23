
namespace Atividade_23._10_Classe_Pessoa
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }

        public override void PagarImposto()
        {
            Console.WriteLine($"Pessoa física: {Nome}, CPF: {Cpf} - pagando imposto...");
        }
    }
}