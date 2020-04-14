using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaAlunoProfessor
{
    class Aluno: Original

    {
        public string Nome { get; set; }

        public new string Materia { get; set; }

        public override string Mostra()
        {
            return $"Eu sou o aluno {this.Nome} minha matéria é: {this.Materia}";
        }
        public override string Mostra(string mensagem)
        {
            return $"Eu sou o aluno {this.Nome} minha matéria é {this.Materia} - {mensagem}";
        }

    }
}
