namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Digite a idade");
            idade = int.Parse(Console.ReadLine());

            if(idade >= 18) 
            {
                Console.WriteLine("Maior de idade");
            } 
            else
            {
                Console.WriteLine("Menor de idade");
            }

            int mes;

            Console.WriteLine("Digite o mês");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 0:
                    Console.WriteLine("Janeiro");
                    break;

                case 1:
                    Console.WriteLine("Fevereiro");
                    break;

                default:
                    Console.WriteLine("Não disponível");
                    break;
            }
        }
    }
}
