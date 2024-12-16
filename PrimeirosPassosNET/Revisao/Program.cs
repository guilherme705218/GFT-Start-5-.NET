namespace Revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;


            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":

                        Console.WriteLine("Informe o nome do aluno");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota");

                        var nota = decimal.Parse(Console.ReadLine());

                        aluno.Nota = nota;

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;

                    case "2":
                        foreach (var a in alunos) 
                        {
                            Console.WriteLine($"{a.Nome} e {a.Nota}");
                        }
                        break;

                    case "3":
                        decimal notaTotal = 0;
                        var nmrAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++) 
                        { 
                            if (string.IsNullOrEmpty(alunos[i].Nome)) 
                            {

                                notaTotal = notaTotal + alunos[i].Nota;
                                nmrAlunos++;
                            }           
                        }

                        var mediaGeral = notaTotal / nmrAlunos;
                        ConceitoEnum conceitoGeral = new ConceitoEnum();

                        if (mediaGeral < 3) 
                        {
                            conceitoGeral = ConceitoEnum.E;
                        
                        }

                        Console.WriteLine($"{mediaGeral}");

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();


                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
