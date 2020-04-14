using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaAlunoProfessor
{
    class Original
    {

        public string Materia { get; set; }
        public string Professor { get; set; }

       



        public virtual string Mostra()
        {
            return $"Eu sou o professor {this.Professor} minha matéria é {this.Materia}";
        }
        public virtual string Mostra(string mensagem)
        {
            return $"Eu sou o professor {this.Professor} minha matéria é {this.Materia} - {mensagem}";
        }

    }
}
