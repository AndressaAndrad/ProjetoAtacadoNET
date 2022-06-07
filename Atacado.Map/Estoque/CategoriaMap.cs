using Atacado.Domain.Estoque;
using Atacado.POCO.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.Estoque
{
    public static class CategoriaMap
    {
        public static CategoriaPOCO ConverterParaPoco(Categoria domain)
        {
            CategoriaPOCO poco = new CategoriaPOCO();
            poco.Codigo = domain.Codigo;
            poco.Descricao = domain.Descricao;
            poco.Situacao = domain.Situacao;

            return poco;
        }

        public static Categoria ConverterParaDomain( CategoriaPOCO poco)
        {
            return new Categoria(poco.Codigo, poco.Descricao, poco.Situacao);
            
        }
    }
}
