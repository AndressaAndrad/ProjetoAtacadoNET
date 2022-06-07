using Atacado.Domain.IBGE;
using Atacado.POCO.IBGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.IBGE
{
    public static class EstadoMap
    {
        public static EstadoPOCO ConverterParaPoco(Estado modelo)
        {
            return new EstadoPOCO()
            {
                Codigo = modelo.Codigo,
                Descricao = modelo.Descricao,
                SiglaUF = modelo.SiglaUF,
                RegiaoBrasil = modelo.RegiaoBrasil,
            };
        }

        public static Estado ConverterParaModelo(EstadoPOCO poco)
        {
            return new Estado(poco.Codigo, poco.Descricao, poco.SiglaUF, poco.RegiaoBrasil);
        }
    }
}