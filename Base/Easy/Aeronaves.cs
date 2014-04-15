using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Easy
{
    class Aeronaves
    {
        private string codAero = "<Codigo>";
        private string modeloAero = "<Sem Modelo>";
        private string capacidAero = "<Sem Capacidade>";
        private int i;
		private List<Aeronaves> aerolist = new List<Aeronaves>();
        private string bkcod, bkmod, bkcap, v;
       
        public string CodAero
        {

            get { return codAero; }

            set
            {
                string validador = "" + value;
                if (validador.Contains("."))
                {

                    i++;
                }
                else
                {
                    codAero = value;
                    bkcod = codAero;
                }

            }

        }

        public string ModeloAero
        {

            get { return modeloAero; }

            set { modeloAero = value;
            bkmod = modeloAero;
            }

        }

        public string CapacidAero
        {

            get
            {
                return capacidAero;


            }

            set
            {
                string validador = value;
                if (validador.Contains("."))
                {

                    i++;
                }
                else
                {
                    capacidAero = value;
                    bkcap = capacidAero;
                }
            }
        }

        public string ToStringAero()
        {

            if (i > 0)
            {
                return "Cadastro não realizado com sucesso, Número invalido, não permitido ponto(.) Por favor Verifique";
            }
            else
            {
                addlist();
                return "Cadastro de Aeronave Realizado com sucesso >> Codigo: " + codAero + ">> Modelo: " + modeloAero + ">> Capacidade: " + capacidAero;
            }
        }
        
        private void addlist(){
            var l = new Aeronaves { codAero=bkcod, modeloAero=bkmod, capacidAero=bkcap };
            aerolist.Add(l);

        }

        public String AeroCadastrada(){
            v = "";
           
                foreach (var i in aerolist) {
                    v += i.codAero + i.modeloAero + i.capacidAero + "_";
                }
                return v;
	
            }
    
		public int QtdAeroCadast {
			get{ return i; }
        }

	}
}






