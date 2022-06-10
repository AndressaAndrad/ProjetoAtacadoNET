using Atacado.Domain.RH;
using Atacado.POCO.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.RH
{
    public static class EmpresaMap
    {
        public static EmpresaPOCO ConverterParaPoco(Empresa Domain)
        {
            return new EmpresaPOCO()
            {
                Codigo = Domain.Codigo,
                Telefone = Domain.Telefone,
                Email = Domain.Email,
                Endereco = Domain.Endereco,
                RazaoSocial = Domain.RazaoSocial,
                NomeFantasia = Domain.NomeFantasia,
                Cnpj = Domain.Cnpj,
                InscricaoEstadual = Domain.InscricaoEstadual
            };
        }

        public static Empresa ConverterParaDomain(EmpresaPOCO poco)
        {
            return new Empresa(poco.Codigo, poco.Telefone, poco.Email, poco.Endereco, poco.RazaoSocial,
                poco.NomeFantasia, poco.Cnpj, poco.InscricaoEstadual);
        }
    }
}