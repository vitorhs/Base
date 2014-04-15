using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class CamaroteInferior : Vip
    {
        private string localização;


        public string Localização
        {
            set { localização = value; }
            get { return localização; }

        }

        public void Local()
        {
            Console.WriteLine(localização);
        }
    }
}
