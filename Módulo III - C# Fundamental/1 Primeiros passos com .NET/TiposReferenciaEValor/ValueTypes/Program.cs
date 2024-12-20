using System.Security.Cryptography.X509Certificates;

namespace ValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da Main");
            int valorInteiro = int.Parse(Console.ReadLine());

            AlteradorDeValor.Alterador(ref valorInteiro);

            Console.WriteLine(valorInteiro);
        }
    }

    class AlteradorDeValor 
    { 
        
        public static void Alterador(ref int valorInteiro ) 
        { 
          
            Random randNum = new Random();
            valorInteiro = randNum.Next(valorInteiro);
        }
    
    }
}
