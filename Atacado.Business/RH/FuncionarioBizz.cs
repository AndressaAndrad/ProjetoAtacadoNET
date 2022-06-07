using Atacado.Domain.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Business.RH
{
    public class FuncionarioBizz
    {
        private Funcionario funcionario;

		private List<string> mensagens;
		public List<string> Mensagens
        {
			get { return mensagens; }
        }

        public FuncionarioBizz()
        {
			this.mensagens = new List<string>();
        }

        public bool Executar(Funcionario obj)
        {
			this.funcionario = obj;
			if (this.ValidarCPFVazio(funcionario.Cpf) == false)
            {
				this.mensagens.Add("- CPF não pode ser vazio.");
				return false;
			}
			if (this.ValidarCPF(funcionario.Cpf) == false)
            {
				this.mensagens.Add("- CPF inválido.");
				return false;
            }
			else
            {
				return true;
            }
        }

		private bool ValidarCPFVazio(string cpf)
        {
			return !(cpf == String.Empty);
			
		}

        private bool ValidarCPF(string cpf)
        {
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf;
			string digito;
			int soma;
			int resto;
			cpf = cpf.Trim();
			cpf = cpf.Replace(".", "").Replace("-", "");
			if (cpf.Length != 11)
				return false;
			tempCpf = cpf.Substring(0, 9);
			soma = 0;

			for (int i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCpf = tempCpf + digito;
			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = digito + resto.ToString();
			return cpf.EndsWith(digito);
		}
    }
}
