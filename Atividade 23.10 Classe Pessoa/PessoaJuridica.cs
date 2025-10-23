
namespace Atividade_23._10_Classe_Pessoa
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; } = string.Empty;
        public string RazaoSocial { get; set; } = string.Empty;

        public override void PagarImposto()
        {
            Console.WriteLine($"Pessoa jurídica: {RazaoSocial}, CNPJ: {Cnpj} - pagando imposto...");
        }
    }
}