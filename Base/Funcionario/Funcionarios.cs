using System;

namespace Base.Funcionario
{
	class Funcionarios
	{
		private string nome;
		private string cpf;
		private string sexo;
		private int idade;
		private double salariobase = 600;

		public Funcionarios()
		{
			this.cpf ="";
			this.idade=0;
			this.nome="";
			this.sexo="";
		}

		public string Nome {

			get{return nome;}
			set{nome = value;}
		}

		public string Cpf{

			get{return cpf;}
			set{cpf = value;}

		}

		public string Sexo{
			set{ sexo = value; }
			get{ return sexo; }

		}

		public int Idade{
			set{ idade = value; }
			get{ return idade; }
		}

		public double SalarioBase{

			get{ return salariobase; }
		}
			
		public override string ToString ()
		{
			return string.Format ("[Funcionarios: Nome={0}, Cpf={1}, Sexo={2}, Idade={3}, SalarioBase={4}]", Nome, Cpf, Sexo, Idade, SalarioBase);
		}

	}
}

