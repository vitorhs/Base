using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Ingresso
{
    class CamaroteInferior : Vip
    {
        private string localização;


        public string Localização
        {
            set { localização = value; }
            get { return localização; }

        }

        public string Local()
        {
            return localização;
        }
    }
}
