using Arus_namespace;
using _5_Jogo_de_RPG.src.Entities;

namespace principal
{
    class Program
    {
        static void Main(string[] args)
        {

            Knight hero = new Knight("Arus", 23, "Knight");
            Wizzard jennica = new Wizzard("Jennica", 23, "White Wizard");
            Knight oponente = new Knight("Maleficus", 99, "Devil");
            hero.Attack();
            System.Console.WriteLine(hero);
            System.Console.WriteLine(oponente);

        }
    }
}