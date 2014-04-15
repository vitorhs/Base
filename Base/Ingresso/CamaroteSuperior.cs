using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Base.Ingresso
{
    public class CamaroteSuperior : Vip
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

        public override double ImprimeValor()
        {
            var vip = Valor + ValorAdcional+camarotesuperior;
            return vip ;
        }

        public string Local()
        {
           return localização;
        }
    }

}
