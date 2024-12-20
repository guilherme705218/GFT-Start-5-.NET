namespace PraticaStructRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Ricardo";
            p1.Idade = 30;
            p1.EnderecoPessoa = new Endereco()
            {
                Logradouro = "Rua teste",
                CEP = "0000",
                Cidade = "São Paulo",
            };

            Console.WriteLine("Fim");
        }
    }
}
