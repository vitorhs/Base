using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Pergunta
{
    public class Pergunta
    {
        private int _id = 0;
        private int id = 0;
        private string _pergunta;
        private string _a;
        private string _b;
        private string _c;
        private string _d;
        private string _resposta;
        private List<Pergunta> pg = new List<Pergunta>();

        public Pergunta()
        {
            _pergunta = "Quem desenvolveu está classe?";
            _a = "Vitor";
            _b = "Vitor Hugo";
            _c = "Victor Hugo";
            _d = "Vitor Santos";
            _resposta = "Vitor Santos";


        }

        private Pergunta(int id, string pergunta, string a, string b, string c, string d, string resposta)
        {

            _id = id;
            _pergunta = pergunta;
            _a = a;
            _b = b;
            _c = c;
            _d = d;
            _resposta = resposta;

        }

        private void Addpergunta()
        {
            id = pg.Count;
            Pergunta pr = new Pergunta(id, _pergunta, _a, _b, _c, _d, _resposta);
            pg.Add(pr);

        }

        public string ImprimePergunta()
        {
            Random rn = new Random();
            

            List<int> mm = new List<int>();
            for (int j = 0; j < pg.Count; j++)
            {
                int ranNums = rn.Next(pg.Count);
                if(!mm.Contains (ranNums))
                mm.Add(ranNums);
            }
            int r=-1;

            if (r < 0) {

                r = mm.Count;

            }
            else
            {
                r = r;
            }
            int z=0;
            for (int i=0; i<mm.Count ;i++) { 
                  z = mm[r-1];

            }

            /*Random rand = new Random(DateTime.Now.ToString().GetHashCode());
            int index = 0;
            index = rand.Next(pg.Count);*/
            r--;
            return pg[z].ToString();
            
        }

        public override string ToString()
        {
            return _id + _pergunta + "\nA)" + _a + "\nB)" + _b + "\nC)" + _c + "\nD)" + _d;
        }

        public string Correção(string resposta)
        {
            switch (resposta)
            {
                case "A":
                    resposta = A;
                    break;
                case "B":
                    resposta = B;
                    break;
                case "C":
                    resposta = C;
                    break;

                case "D":
                    resposta = D;
                    break;
            }

            var k = from c in pg where c._resposta == resposta select c;
            return k.Count().ToString();

        }

        public string Question
        {

            set { _pergunta = value; }
            get { return _pergunta; }
        }

        public string A
        {
            set { _a = value; }
            get { return _a; }
        }

        public string B
        {
            set { _b = value; }
            get { return _b; }
        }

        public string C
        {
            set { _c = value; }
            get { return _c; }
        }
        public string D
        {
            set { _d = value; }
            get { return _d; }
        }

        public string Answer
        {
            set
            {
                _resposta = value;
                Addpergunta();
            }
            get { return _resposta; }
        }
    }
}