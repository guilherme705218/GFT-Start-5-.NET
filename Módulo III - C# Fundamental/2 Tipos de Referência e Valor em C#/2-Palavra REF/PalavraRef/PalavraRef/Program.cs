namespace PalavraRef
{
    internal class Program
    {
        static void Demo1()
        {
            int a = 5;
            Adicionar20(ref a);
            Console.WriteLine($"O valor de a é {a}!");
        }

        static void Demo2()
        {



        }

        static void Main(string[] args)
        {
            var nomes = new string[] { "José", "Maria", "Ricardo", "Alice", "Pedro" };
            Console.WriteLine("Digite o nome a ser substituido");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o nome novo");
            var nomeNovo = Console.ReadLine();

            var indice = LocalizarNome(nomes, nome);

            if(indice >= 0) 
            {
                nomes[indice] = nomeNovo;
                Console.WriteLine($"{nomes}");
            }
            else 
            {
                Console.WriteLine("Nome não encontrado");
            }
        }


        static void Adicionar20(ref int a)
        {
            a += 20;
        }

        static void AlterarNome(string[] nomes, string nome, string nomeNovo)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == nome)
                {
                    nomes[i] = nomeNovo;

                }
            }
        }

        static ref string LocalizarNome(string[] nomes,ref string nome)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == nome)
                {
                    return ref nome;
                }
            }
            throw new Exception("Nome não encontrado");
        }

    }
}
