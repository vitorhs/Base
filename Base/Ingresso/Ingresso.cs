using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Ingresso
    {
        private double valor;

        public Ingresso()
        {
            valor = 0;
        }

        public Ingresso(double valor)
        {
            this.valor = valor;
        }

        public double Valor {

            set { valor = value ;}
            get { return valor; }
        }
        public virtual void ImprimeValor() {
        
        
        }

    }
}
