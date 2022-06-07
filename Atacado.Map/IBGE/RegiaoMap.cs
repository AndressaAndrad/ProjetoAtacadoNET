using Atacado.Domain.IBGE;
using Atacado.POCO.IBGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.IBGE
{
    public static class RegiaoMap
    {
        public static RegiaoPOCO ConverterParaPoco(Regiao modelo)
        {
            return new RegiaoPOCO()
            {
                Codigo = modelo.Codigo,
                Descricao = modelo.Descricao
            };
        }

        public static Regiao ConverterParaModelo(RegiaoPOCO poco)
        {
            return new Regiao(poco.Codigo, poco.Descricao);
        }
    }
}