using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Locadora
{
    public class Veiculos
    {
        private string modelo;
        private string marca;
        private string cor;
        private string placa;
        private string anoModel;
        private string tipo;
        private Proprietarios p = new Proprietarios();

        public Veiculos()
        {
            this.modelo = "";
            this.marca = "";
            this.cor = "";
            this.placa = "";
            this.anoModel = "";
            this.tipo = "";
        }
           
        public Veiculos(string modelo, string marca, string cor, string placa, string anoModel,  string tipo, string cpf){

            this.modelo = modelo;
            this.marca = marca;
            this.cor = cor;
            this.placa = placa;
            this.anoModel = anoModel;
            this.tipo = tipo;
            p.Cpf = cpf;
        }

        public string Modelo {
            get { return modelo; }
            set { modelo = value ;}
        
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value;}

        }
        public string Cor
        {
            get { return cor; }
            set { cor = value ;}

        }
        public string Placa
        {
            get { return placa; }
            set { placa = value;}

        }
        public string AnoModel
        {
            get { return anoModel; }
            set { anoModel = value;}

        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value ;}

        }

        public string Cpf
        {
            get { return p.Cpf; }
            set { p.Cpf = value; }

        }

        public override string ToString()
        {
            return "\nVeículos: \nModelo: " + modelo + "\nMarca:" + marca + "\nCor: " + cor + "\nPlaca: " + placa + "\nAno Modelo: " + anoModel + "\nTipo: " + tipo+"\nCPF: "+p.Cpf;
        }

    }
}
