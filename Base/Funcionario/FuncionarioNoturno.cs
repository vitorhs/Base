using System;

namespace Base.Funcionario
{
	public class FuncionarioNoturno:Funcionarios
	{
		private double salarioNtn;
		private int valornoite = 60;
		private int noitestrab;

		public FuncionarioNoturno ()
		{
			this.salarioNtn = 0;
			this.noitestrab = 0;
		}

		public FuncionarioNoturno(string nome, string cpf, string sexo, int idade,  int noitetrabMes){
			Nome = nome;
			Cpf = cpf;
			Sexo = sexo;
			Idade = idade;
			NoitesTrabMes = noitetrabMes;
			var Salario = SalarioMensal ();
		}
				
		public int NoitesTrabMes{
			get{return noitestrab; }
			set{ noitestrab = value; }
		}

		public double SalarioMensal(){
			salarioNtn = (noitestrab*valornoite) + SalarioBase;
			return salarioNtn;
		}

		public override string ToString ()
		{
			SalarioMensal ();
			return base.ToString () + string.Format ("[FuncionarioNoturno: Noites Trabalhadas no Mes={0} Adcional Noturno: Valor=R${1} Salario Mensal = Salario=R${2} ]", NoitesTrabMes, valornoite,salarioNtn);
		}

		}

	}


