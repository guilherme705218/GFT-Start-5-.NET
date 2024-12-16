namespace ValoresEReferencia
{
    internal class Program
    {
        static void Demo2() 
        {
            Pessoa pessoa = new Pessoa("Guilherme", 25, 12345678);

            Console.WriteLine(pessoa.Nome);

            Pessoa pessao2 = pessoa.Clone();

        }


        static void Main(string[] args)
        {
            StructPessoa p1 = new StructPessoa()
            {
                Documento = 1234,
                Idade = 30,
                Nome = "Ricardo"
            };

            StructPessoa p = default;

            p.Nome = "Cida";

            Pessoa.TrocarNome(p, "João");
        }
    }
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Documento { get; set; }

        public Pessoa(string nome, int idade, int documento)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Documento = documento;

        }

        public Pessoa()
        {
        }

        public void Alterar()
        {
            this.Nome = "João";
        }

        public Pessoa Clone()
        {
            return new Pessoa()
            {
                Nome = this.Nome,
                Idade = this.Idade,
                Documento = this.Documento
            };
        }

        public static void TrocarNome(StructPessoa p1, string nomeNovo) 
        {
            p1.Nome = nomeNovo;

        
        }
    }
}
