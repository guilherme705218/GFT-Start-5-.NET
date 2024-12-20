namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Guilherme", 25, 12345678);

            Console.WriteLine(pessoa.Nome);

            pessoa.Alterar();

            Console.WriteLine(pessoa.Nome);
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

        public void Alterar() 
        {
            this.Nome = "João";
        }
    
    }
}
