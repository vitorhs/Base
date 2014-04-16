using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Base.Academia
{
    public class aluno
    {
        private string nome;
        private int codigo;
        private string trainner;
        private int exercdiarios;
        private academia adm = new academia();

        public void setNome(string nome)
    {
        this.nome = nome;
    }
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public void setTrainner(string trainner)
        {
            this.trainner = trainner;
            adm.setProf(+1);
        }
        public void setExercdiarios(int exercdiarios)
        {
            this.exercdiarios = exercdiarios;
        }
        public void setAcademia(string acad)
        {
            adm.setNome(acad);
        }

        public string ToStringAluno()
        {
            return "Nome: " +nome+"\nCodigo: "+codigo+"\nTrainner: "+trainner+"\nExercicios Diarios: "+exercdiarios ;
        }
    }
}
