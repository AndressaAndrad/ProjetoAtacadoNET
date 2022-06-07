using Atacado.Domain.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Domain.RH
{
    public class Funcionario : BasePessoa
    {
        private string nome;

        private string sobreNome;

        private int idade;

        private double altura;

        private double peso;

        private DateTime dtNascimento;

        private string naturalidade;

        private string nacionalidade;

        private string sexo;

        private string cpf;

        private string rg;


        public string Nome { get => nome; set => nome = value; }
        public string SobreNome { get => sobreNome; set => sobreNome = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Peso { get => peso; set => peso = value; }
        public DateTime DtNascimento { get => dtNascimento; set => dtNascimento = value; }
        public string Naturalidade { get => naturalidade; set => naturalidade = value; }
        public string Nacionalidade { get => nacionalidade; set => nacionalidade = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }



        public Funcionario(int codigo, string telefone, string email, string endereco, string nome, string sobreNome, int idade, double altura, double peso, DateTime dtNascimento, string naturalidade, string nacionalidade, string sexo, string cpf, string rg)
            : base(codigo, telefone, email, endereco)
        {
            this.nome = nome;
            this.sobreNome = sobreNome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
            this.dtNascimento = dtNascimento;
            this.naturalidade = naturalidade;
            this.nacionalidade = nacionalidade;
            this.sexo = sexo;
            this.cpf = cpf;
            this.rg = rg;
        }


        public Funcionario(int codigo, string nome, string sobreNome, string cpf, string telefone,
            string sexo, DateTime dataNascimento, string email)
            : base (codigo,telefone,email)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.sobreNome = sobreNome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.sexo = sexo;
            this.dtNascimento = dataNascimento;
            this.email = email;
        }

    }
}
