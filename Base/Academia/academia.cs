using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazer
{
    class academia
    {
        private string nome = "<sem nome>";
        private int aluno = 0;
        private int prof = 0;
        private int aparelhos = 0;
        private string porte ="<sem porte>";

        public void setNome(string nome)
        {
            if (nome.Length > 3)
                this.nome = nome;
        }

        public void setAluno(int aluno)
        {
            if (aluno > 1)
                this.aluno = aluno;
        }

        public void setProf(int prof)
        {
            if (prof > 1)
                this.prof = prof;
        }

        public void setAparelhos(int aparelhos)
        {
            if (aparelhos > 1)
                this.aparelhos = aparelhos;
        }

        public string Tostring(){

            if (aparelhos <= 9 && prof <= 2)
                porte = "Pequeno Porte - Iniciante";
            else
            {
                if (aparelhos > 9 && aparelhos <= 17 && prof <= 5)
                    porte = "Medio Porte - Amador";
                else
                {
                    if (aparelhos > 18 && prof > 10)
                        porte = "Grande Porte - Veterano";
                    else
                    {
                        porte = "Sem Classificação para o Programa";
                    }
                }

            }
            
            
        
            return "Academia de Porte: "+porte+"\nAcademia: \n\n" + "Nome: "+nome +"\nQuantidades de Alunos: "+ aluno + "\nQuantidade de Professores: "+prof+ "\nQuantidade de Aparelhos: "+aparelhos;
        }
        
      
    }
}
