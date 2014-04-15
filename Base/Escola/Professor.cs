using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Escola
{
   public class Professor
    {
        private List<string> ProfList = new List<string>();

        public Professor()
        {
            ProfList.Add("Maria Joaquina");
            ProfList.Add("Cirilo");
            ProfList.Add("Clara");
        }

        public void setProf(string Nome) {

            ProfList.Add(Nome);
        
        }

        public List<string> ListProf() {


            return ProfList;
        }

    }
}
