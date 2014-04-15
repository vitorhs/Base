using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class CamaroteSuperior:Vip
    {
        private string localização;
        private double camarotesuperior;

        public string Localização
        {
            set { localização = value; }
            get { return localização; }

        }

        public double AdcionalCamaroteSuperior{

            set { camarotesuperior = value; }
            get { return camarotesuperior; }
        }

        public override void ImprimeValor()
        {
            var vip = Valor + ValorAdcional+camarotesuperior;
            Console.WriteLine(vip); ;
        }

        public void Local()
        {
            Console.WriteLine(localização);
        }
    }

}
