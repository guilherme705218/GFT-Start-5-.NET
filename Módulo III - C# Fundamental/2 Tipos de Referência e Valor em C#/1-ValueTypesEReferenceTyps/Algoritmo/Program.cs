namespace Algoritmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo 1
            /*int[] numeros = new int[] { 0, 2, 4, 6, 8 };
            Console.WriteLine($"Digite o número que gostaria de encontrar");
            var numero = int.Parse(Console.ReadLine());
            var idxEncontrado = EncontrarNumero(numeros, numero);

            if (idxEncontrado >= 0)
            {
                Console.WriteLine($"O número digitado está na posição {idxEncontrado}");
            }
            else
            {
                Console.WriteLine("O numéro digitado não foi encontrado");
            }
            //Fim Demo1*/

            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa(){Nome = "Ricado"},
                new Pessoa(){Nome = "José"},
                new Pessoa(){Nome = "Maria"},
            };

            Console.WriteLine("Digite a pessoa que gostaria de localizar");
            var nome = Console.ReadLine();
            var pessoa = new Pessoa() { nome = nome };
            var encontrado = EncontrarPessoa(pessoas, pessoa);
            if (encontrado)
            {
                Console.WriteLine("pessoa localizada");
            }
            else 
            {

                Console.WriteLine("nao");

            }
        }

        static int EncontrarNumero(int[] numeros, int numero)
        {
            for (int i = 0; i < numeros.Length; i++)
            {

                if (numeros[i] == numero)
                {
                    return i;
                }

            }
            return -1;
        }

        static bool EncontrarPessoa(List<Pessoa> pessoa, Pessoa pessoa) 
        { 
            foreach(var item in pessoas) 
            { 
                if(item == pessoa) 
                {

                    return true;
                    
                }
            }
            return false;

        }

    }
}
