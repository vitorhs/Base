using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Locadora
{
   public class Proprietarios:Cliente
    {
        private string email;
        private string senha;
        private List<Veiculos> v1 = new List<Veiculos>();
        private List<Proprietarios> p1 = new List<Proprietarios>();

        public Proprietarios(){

        }

        private Proprietarios(string nome, string cpf, string fone, string email, string senha, Veiculos veiculo)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.fone = fone;
            this.email = email;
            this.senha = senha;
            v1.Add(veiculo);
        
        }
        private Proprietarios(string nome, string cpf, string fone, string email, string senha)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.fone = fone;
            this.email = email;
            this.senha = senha;
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value ;}

        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value;}

        }
        public string Fone
        {
            get { return fone; }
            set { fone =  value;}

        }
        public string Email
        {
            get { return email; }
            set { email = value;}

        }
        public string Senha
        {
            get { return senha; }
            set { 
            senha = value;
            AddProprietario();
            }

            

        }

        private void AddProprietario() {

            var propr = new Proprietarios(nome, cpf, fone, email, senha);
            p1.Add(propr);
           
        }

        public string ListProprietarios() {
            var prope = "";
            for (var i = 0; i < p1.Count; i++)
            {

                prope += p1[i].ToString();

            }
            return prope;
        
        }

        public void AddVeiculos(Veiculos veiculo) {

            v1.Add(veiculo);

                  }

        public override string ToString()
        {
            return "\nProprietario: \nNome: " + nome + "\nCPF: " + cpf + "\nTelefone: " + fone + "\nEmail: " + email + "\nSenha: " + senha ;
        }

        public virtual string ListProprietarioCarro() {

            return ListProprietarios() + ListaCarros();
        
        }
        private string ListaCarros() {
            var crs = "";
            for (var i = 0; i < v1.Count; i++) { 
            
                 crs += v1[i].ToString();
            
            }

            return crs;
        
        }

        public string  BuscaCarros(string cpf) {
            string resultv= "" ;
            string resultp = ""; 

            var l = from p in p1 where p.Cpf == cpf select p;
            foreach (var e in l)
            {
                resultp += e;
            }
             var l1 = from car in v1 where car.Cpf == cpf select car;
             foreach (var c in l1) {
                 resultv += c;
             }

             return resultp + resultv ;
        }
    }
}
