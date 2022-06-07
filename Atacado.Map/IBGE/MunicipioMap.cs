using Atacado.Domain.IBGE;
using Atacado.POCO.IBGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.IBGE
{
    public static class MunicipioMap
    {
        public static MunicipioPOCO ConverterParaPoco(Municipio modelo)
        {
            return new MunicipioPOCO()
            {
                Codigo = modelo.Codigo,
                Descricao = modelo.Descricao,
                CodigoUF = modelo.CodigoUF,
                SiglaUF = modelo.SiglaUF,
                CodigoMesoregiao = modelo.CodigoMesoregiao,
                CodigoMicroregiao = modelo.CodigoMicroregiao,
                CodigoIBGE6 = modelo.CodigoIBGE6,
                CodigoIBGE7 = modelo.CodigoIBGE7,
                PopulacaoMunicipio = modelo.PopulacaoMunicipio,
                Porte = modelo.PorteMunicipio,
                Cep = modelo.Cep
            };
        }

        public static Municipio ConverterParaModelo(MunicipioPOCO poco)
        {
            return new Municipio(
                poco.Codigo,
                poco.Descricao,
                poco.CodigoUF,
                poco.SiglaUF,
                poco.CodigoMesoregiao,
                poco.CodigoMicroregiao,
                poco.CodigoIBGE6,
                poco.CodigoIBGE7,
                poco.PopulacaoMunicipio,
                poco.Porte,
                poco.Cep
                );
        }
    }
}
