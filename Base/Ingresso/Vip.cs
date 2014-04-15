using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Ingresso
{
    class Vip:Ingresso
    {
        private double valoradd;

        public override double ImprimeValor(){

            var vip = Valor + valoradd;
            return vip;
        }

        public double ValorAdcional {
            set { valoradd = value; }
            get { return 0; }
        }


        
    }
}
