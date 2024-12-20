namespace CompararValoreseRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            Numero c = new Numero(2);
            Numero d = new Numero(4);

            if (a == b) 
            {
                Console.WriteLine("A E B SÃO IGUAIS");

            }
            else
            {
                Console.WriteLine("São diferentes");
            }
        }

        class Numero 
        { 
            public int N { get; set; }  

            public Numero(int n) 
            {
            
                N = n;
           
            }
        
        }
    }
}
