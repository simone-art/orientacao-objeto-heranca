using System;
using System.Collections.Generic;

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


     
            Console.WriteLine(ClasseOriginal.Mostra(mensagemProfessor));
            Console.WriteLine(ClasseAluno.Mostra(mensagemAluno));
            Console.WriteLine("==============================================");
            Console.WriteLine("==============================================\n");
            



            List<string> listaNomeMaterias = new List<string>();

            Console.WriteLine("=============Lista de Materias===============");
            listaNomeMaterias.Add("1. Arquitetura de software\n");
            listaNomeMaterias.Add("2. Tecnología e Innovação\n");
            listaNomeMaterias.Add("3. C Sharp\n");
            listaNomeMaterias.Add("4. Multipotencialidade\n");
            listaNomeMaterias.Add("5. Habilidades de organização e planificação\n");
            listaNomeMaterias.Add("6. Produtividade\n");
            Console.WriteLine("==============================================");

            foreach (var dato in listaNomeMaterias)
            {
                Console.WriteLine(dato.ToString());
            }
        }
    }
}

