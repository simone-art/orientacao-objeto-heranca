using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaAlunoProfessor
{
    class Aluno: Original
    {

        public override string Mostra()
        {
            return $"Eu sou o aluno {this.Nome} minha matéria é:  {this.Materia}";
        }
        public override string Mostra(string mensagem)
        {
            return $"Eu sou o aluno {this.Nome} minha matéria é : {this.Materia} - {mensagem}";
        }

    }
}
