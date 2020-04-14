using System;

namespace ProgramaAlunoProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Digite o nome do Aluno ");
            var aluno = Console.ReadLine();
            Console.WriteLine("2. Digite a materia do Aluno");
            var materiaAluno = Console.ReadLine();
            Console.WriteLine("3. Digite o nome do Professor");
            var professor = Console.ReadLine();
            Console.WriteLine("4. Digite a materia do Professor");
            var materiaProfessor = Console.ReadLine();
            Console.WriteLine("5. Professor, digite a mensagem");
            var mensagemProfessor = Console.ReadLine();
            Console.WriteLine("6. Aluno, digite a mensagem");
            var mensagemAluno = Console.ReadLine();

            var ClasseOriginal = new Original();
            var ClasseAluno = new Aluno();

            ClasseOriginal.Professor = professor;
            ClasseOriginal.Materia = materiaProfessor;
            ClasseAluno.Nome = aluno;
            ClasseAluno.Materia = materiaAluno;


            //Console.WriteLine(ClasseOriginal.Mostra(professor));
            //Console.WriteLine(ClasseOriginal.Mostra(materiaProfessor));
            //Console.WriteLine(ClasseOriginal.Mostra());
            Console.WriteLine(ClasseOriginal.Mostra(mensagemProfessor));

            //Console.WriteLine(ClasseAluno.Mostra());
            //Console.WriteLine(ClasseAluno.Mostra(aluno));
            //Console.WriteLine(ClasseAluno.Mostra(materiaAluno));
            Console.WriteLine(ClasseAluno.Mostra(mensagemAluno));

            
        }
    }
}
