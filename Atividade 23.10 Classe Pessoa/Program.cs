namespace Atividade_23._10_Classe_Pessoa;

class Program
{
    static void Main(string[] args)
    {
        PessoaFisica pf = new PessoaFisica
        {
            Nome = "Ana Silva",
            Cpf = "123.456.789-00",
            DataNascimento = new DateTime(1995, 4, 12)
        };

        pf.AdicionarEndereco(new Endereco
        {
            Rua = "Rua das Flores",
            Numero = 100,
            Cidade = "São Paulo",
            Estado = "SP",
            Cep = "01000-000",
            Comercial = false
        });

        PessoaJuridica pj = new PessoaJuridica
        {
            Nome = "Loja Exemplo",
            RazaoSocial = "Loja Exemplo LTDA",
            Cnpj = "12.345.678/0001-99"
        };

        pj.AdicionarEndereco(new Endereco
        {
            Rua = "Av. Central",
            Numero = 2000,
            Cidade = "Campinas",
            Estado = "SP",
            Cep = "13000-000",
            Comercial = true
        });

        pf.PagarImposto();
        pj.PagarImposto();
    }
}
