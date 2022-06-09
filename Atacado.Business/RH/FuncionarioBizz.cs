using Atacado.Business.Ancestral;
using Atacado.Domain.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Business.RH
{
	public class FuncionarioBizz : BaseAncestralBizz
	{
		public FuncionarioBizz() : base()
		{ }

		public bool Executar(Funcionario obj)
		{
			Funcionario funcionario = obj;

			bool resultado = true;

			if (this.ValidarCpfVazio(funcionario.Cpf) == false)
			{
				this.mensagens.Add("- CPF não pode ser vazio.");
				resultado = false;
			}

			if (this.ValidarCpf(funcionario.Cpf) == false)
			{
				this.mensagens.Add("- Cpf inválido");
				resultado = false;
			}

			if (this.ValidarRgVazio(funcionario.Rg) == false)
			{
				this.mensagens.Add("- RG não pode ser vazio.");
				resultado = false;
			}

			if (this.ValidarNomeVazio(funcionario.Nome) == false)
			{
				this.mensagens.Add("- Nome não pode ser vazio.");
				resultado = false;
			}

			if (this.ValidarSobrenomeVazio(funcionario.SobreNome) == false)
			{
				this.mensagens.Add("- Sobrenome não pode ser vazio.");
				resultado = false;
			}

			if (this.ValidarEnderecoVazio(funcionario.Endereco) == false)
			{
				this.mensagens.Add("- Endereço não popde ser vazio.");
				resultado = false;
			}

			if (this.ValidarTelefoneVazio(funcionario.Telefone) == false)
			{
				this.mensagens.Add("- Telefone não pode ser vazio.");
				resultado = false;
			}

			if (this.ValidarTelefoneDigitos(funcionario.Telefone) == false)
			{
				this.mensagens.Add("- Telefone inválido.");
				resultado = false;
			}

			if (this.ValidarEmailVazio(funcionario.Email) == false)
			{
				this.mensagens.Add("- Email não pode ser vazio.");
				resultado = false;
			}

			//if (this.ValidarIdadeVazio(funcionario.Idade) == false)
			//{
			//	this.mensagens.Add("- Idade não pode ser vazia.");
			//	resultado = false;
			//}

			if (this.ValidarDtNascimento(funcionario.DtNascimento) == false)
			{
				this.mensagens.Add("- Data de nascimento inválida.");
				resultado = false;
			}

			int idade;
			if (this.ValidarIdade(funcionario.DtNascimento, out idade) == false)
			{
				this.mensagens.Add("- Não pode ser cadastrado, menor de 18.");
				resultado = false;
			}
			else
			{
				funcionario.Idade = idade;
			}

			return resultado;
		}

		private bool ValidarCpfVazio(string cpf)
		{
			return !(cpf == String.Empty);
		}

		private bool ValidarCpf(string cpf)
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

		private bool ValidarData(string data)
		{
			DateTime dtnasc;
			return (DateTime.TryParse(data, out dtnasc));
		}

		private bool ValidarRgVazio(string rg)
		{
			return !(string.IsNullOrEmpty(rg));
		}

		private bool ValidarNomeVazio(string nome)
		{
			return !(string.IsNullOrEmpty(nome));
		}

		private bool ValidarSobrenomeVazio(string sobrenome)
		{
			return !(string.IsNullOrEmpty(sobrenome));
		}

		private bool ValidarEnderecoVazio(string endereco)
		{
			return !(string.IsNullOrEmpty(endereco));
		}

		private bool ValidarTelefoneVazio(string telefone)
		{
			return !(string.IsNullOrEmpty(telefone));
		}

		private bool ValidarTelefoneDigitos(string telefone)
		{
			if (string.IsNullOrEmpty(telefone) != true)
			{
				if ((telefone.Length <= 10) && (telefone.Length > 11))
				{
					this.mensagens.Add("- Telefone inválido.");
					return false;
				}
				else
					return true;
			}
			else
				return false;
		}

		private bool ValidarEmailVazio(string email)
		{
			return !(string.IsNullOrEmpty(email));
		}

		private bool ValidarIdadeVazio(int? idade)
		{
			if ((idade.HasValue) && (idade == 0))
				return false;
			else
				return true;
		}

		private bool ValidarDtNascimento(DateTime dtNascimento)
		{
			DateTime dtteste;
			if (DateTime.TryParse(dtNascimento.ToString(), out dtteste))
			{
				if (dtNascimento == DateTime.MinValue)
					return false;
				else
					return true;

			}
			else
				return false;
		}

		private bool ValidarIdade(DateTime dtNascimento, out int idade)
		{
			idade = 0;
			if (dtNascimento != DateTime.MinValue)
			{
				if (DateTime.Today.DayOfYear < dtNascimento.DayOfYear)
				{
					idade = DateTime.Today.Year - dtNascimento.Year - 1;
				}
				else
				{
					idade = DateTime.Today.Year - dtNascimento.Year;
				}

				return ((idade < 18) ? false : true);
			}
			else
			{
				return false;
			}
		}
	}
}