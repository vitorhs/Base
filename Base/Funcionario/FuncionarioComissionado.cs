using System;

namespace Base.Funcionario
{
	public class FuncionarioComissionado:Funcionarios
	{
		private double salarioCms ;
		private double comissão;

		public FuncionarioComissionado ()
		{
			this.salarioCms = 0;
		}

		public FuncionarioComissionado (string nome, string cpf, string sexo, int idade, double comissão)
		{
			Nome = nome;
			Cpf = cpf;
			Sexo = sexo;
			Idade = idade;
			Comissão = comissão;
			var Salario = SalarioMensal ();

		}


		public double Comissão{
			get{return comissão; }
			set{ comissão = value; }
		}

		public double SalarioMensal(){
			salarioCms = SalarioBase + comissão;
			return salarioCms;
		}

		public override string ToString()
		{
			SalarioMensal ();
			return base.ToString() + string.Format ("[FuncionarioComissionado: Comissão={0} Salario Mensal: Salario={1}", Comissão,salarioCms);
		}
				
	}
}

