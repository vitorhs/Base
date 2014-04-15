using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Vip:Ingresso
    {
        private double valoradd;

        public override void ImprimeValor(){

            var vip = Valor + valoradd;
            Console.WriteLine(vip);
        }

        public double ValorAdcional {
            set { valoradd = value; }
            get { return 0; }
        }


        
    }
}
