using Atacado.Domain.RH;
using Atacado.POCO.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.RH
{
    public static class FuncionarioMap
    {
        public static FuncionarioPOCO ConverterParaPoco(Funcionario domain)
        {
            return new FuncionarioPOCO()
            {
                Codigo = domain.Codigo,
                Telefone = domain.Telefone,
                Email = domain.Email,
                Endereco = domain.Endereco,
                Nome = domain.Nome,
                SobreNome = domain.SobreNome,
                Idade = domain.Idade,
                Altura = domain.Altura,
                Peso = domain.Peso,
                DtNascimento = domain.DtNascimento,
                Naturalidade = domain.Naturalidade,
                Nacionalidade = domain.Nacionalidade,
                Sexo = domain.Sexo,
                Cpf = domain.Cpf,
                Rg = domain.Rg
            };
        }

        public static Funcionario ConverterParaDomain(FuncionarioPOCO poco)
        {
            return new Funcionario(poco.Codigo, poco.Telefone, poco.Email, poco.Endereco, poco.Nome
                , poco.SobreNome, poco.Idade, poco.Altura, poco.Peso, poco.DtNascimento, poco.Naturalidade
                , poco.Nacionalidade, poco.Sexo, poco.Cpf, poco.Rg);
        }
    }
}