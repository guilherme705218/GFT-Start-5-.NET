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

        static void Demo3() 
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

        static void Demo4() 
        {
            string nome = "Ricardo";

            Pessoa.TrocarNome(nome, "José");

            Console.WriteLine($"O novo nome é {nome}");
        }
        static void Main(string[] args)
        {

            int[] pares = new int[] {0,2,4,6,8};

            Pessoa.MudarParaImpar(pares);

            Console.WriteLine($"Os impares {string.Join(",", pares)}");



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

        public static void TrocarNome(string nome, string nomeNovo) 
        {
            nome = nomeNovo;
        }

        public static void MudarParaImpar(int[] impar) 
        {
            for (int i = 0; i < impar.Length; i++)
            {
                impar[i] = impar[i] + 1; 
            
            }

        
        }
    }
}
