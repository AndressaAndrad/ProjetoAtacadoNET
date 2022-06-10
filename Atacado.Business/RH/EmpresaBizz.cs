using Atacado.Business.Ancestral;
using Atacado.Domain.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Atacado.Business.RH
{
	public class EmpresaBizz : BaseAncestralBizz
	{
		public EmpresaBizz() : base()
		{ }

		public bool Executar(Empresa obj)
		{
			Empresa empresa = obj;

			bool resultado = true;

			if (this.ValidarCnpjVazio(empresa.Cnpj) == false)
			{
				this.mensagens.Add("- CNPJ não pode ser vazio.");
				resultado = false;
			}
			if (this.ValidarCnpj(empresa.Cnpj) == false)
            {
				this.mensagens.Add("- CNPJ Inválido");
				resultado = false;
            }
			if(this.ValidarIncricaoEstadualVazio(empresa.InscricaoEstadual)== false)
            {
				this.mensagens.Add("- Inscrição Estadual não pode ser vazio");
				resultado = false;
            }
			if(this.ValidarInscricaoEstadualDigitos(empresa.InscricaoEstadual)== false)
            {
				this.mensagens.Add("- Digitos Inválidos");
				resultado = false;
            }
			if(this.ValidarEmailVazio(empresa.Email)== false)
            {
				this.mensagens.Add("-Email não pode ser vazio.");
				resultado = false;
            }
			if (this.ValidarEmail(empresa.Email)== false)
            {
				this.mensagens.Add("-Email Inválido.");
				resultado = false;
			}
			if (this.ValidarRazaoSocialVazio(empresa.RazaoSocial)== false)
            {
				this.mensagens.Add("-Razão Social não pode ser vazio.");
				resultado = false;
			}
			if (this.ValidarNomeFantasiaVazio(empresa.NomeFantasia)== false)
            {
				this.mensagens.Add("-Nome não pode ser vazio.");
				resultado = false;
			}
			if (this.ValidarTelefoneVazio(empresa.Telefone) == false)
			{
				this.mensagens.Add("- Telefone não pode ser vazio.");
				resultado = false;
			}

			if (this.ValidarTelefoneDigitos(empresa.Telefone) == false)
			{
				this.mensagens.Add("- Telefone inválido.");
				resultado = false;
			}
			if (this.ValidarEnderecoVazio(empresa.Endereco) == false)
			{
				this.mensagens.Add("- Endereço não popde ser vazio.");
				resultado = false;
			}

			return resultado;
		}
		
		private bool ValidarCnpjVazio(string cnpj)
        {
			return !(cnpj == String.Empty);
        }
		private bool ValidarCnpj(string cnpj)
		{
			int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
			int soma;
			int resto;
			string digito;
			string tempCnpj;
			cnpj = cnpj.Trim();
			cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
			if (cnpj.Length != 14)
				return false;
			tempCnpj = cnpj.Substring(0, 12);
			soma = 0;
			for (int i = 0; i < 12; i++)
				soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
			resto = (soma % 11);
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCnpj = tempCnpj + digito;
			soma = 0;
			for (int i = 0; i < 13; i++)
				soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
			resto = (soma % 11);
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = digito + resto.ToString();
			return cnpj.EndsWith(digito);
		}

		private bool ValidarIncricaoEstadualVazio(string inscricaoestadual)
        {
			return !(inscricaoestadual == string.Empty);
        }

		private bool ValidarInscricaoEstadualDigitos(string inscricaoestadual) //inscricao somente com digitos.
        {
			if ((inscricaoestadual.Length <= 13) && (inscricaoestadual.Length > 14))
			{
				this.mensagens.Add("- Inscrição Estadual Inválido.");
				return false;
			}
			else
				return true;
		}

		private bool ValidarEmailVazio(string email)
		{
			return !(string.IsNullOrEmpty(email));
		}

		private bool ValidarEmail(string email)
		{
			bool ValidEmail = false;
			int indexArr = email.IndexOf("@");

			if (indexArr > 0)
			{
				int indexDot = email.IndexOf(".", indexArr);
				if (indexDot - 1 > indexArr)
				{
					if (indexDot + 1 < email.Length)
					{
						string indexDot2 = email.Substring(indexDot + 1, 1);
						if (indexDot2 != ".")
						{
							ValidEmail = true;
						}
					}
				}
			}
			return ValidEmail;
		}

		private bool ValidarRazaoSocialVazio(string razaosocial)
		{
			return !(string.IsNullOrEmpty(razaosocial));
		}
		private bool ValidarNomeFantasiaVazio(string nomefantasia)
		{
			return !(string.IsNullOrEmpty(nomefantasia));
		}
		private bool ValidarTelefoneVazio(string telefone)
		{
			return !(string.IsNullOrEmpty(telefone));
		}

		private bool ValidarTelefoneDigitos(string telefone)
		{
			Regex Rgx = new Regex(@"^\(\d{2}\)\d{5}-\d{4}$"); //formato (XX)XXXXX-XXXX
			Regex Rgxx = new Regex(@"^\(\d{2}\)\d{4}-\d{4}$");
			if ((!Rgx.IsMatch(telefone)) && (!Rgxx.IsMatch(telefone)))
			{
				this.mensagens.Add("- Telefone inválido.");
				return false;
			}
			else
				return true;
		}

		private bool ValidarEnderecoVazio(string endereco)
		{
			return !(string.IsNullOrEmpty(endereco));
		}


	}	
}   
