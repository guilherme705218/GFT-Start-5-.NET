namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean condicao = true;
            int valor;


            while (condicao == true) 
            {
                Console.WriteLine("Digite um valor, 0 para sair");
                valor = int.Parse(Console.ReadLine());
            }

            int valor2;
            Console.WriteLine("Digite um valor");
            valor2 = int.Parse(Console.ReadLine());

            for(int i = valor2; i <= valor2; i++) 
            {
                Console.WriteLine(i);
            }

            int[] lista = { 1, 2, 3, 4, 5 }; 

            foreach(int numero in lista) 
            {
                Console.WriteLine(numero);
            }

        }
    }
}
