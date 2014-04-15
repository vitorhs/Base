using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Escola
{
    public class Estudantes
    {
      private List<string> Alunos = new List<string>();

        public Estudantes()
        {
            Alunos.Add("João");
            Alunos.Add("Maria");
            Alunos.Add("Benedito");
        }

        public void setProf(string Nome)
        {

            Alunos.Add(Nome);

        }

        public List<string> ListProf()
        {


            return Alunos;
        }


        
        
    }
}
