using Atacado.Domain.Estoque;
using Atacado.POCO.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.Estoque
{
    public static class SubcategoriaMap
    {
        public static SubcategoriaPOCO ConverterParaPoco(Subcategoria domain)
        {
            SubcategoriaPOCO poco = new SubcategoriaPOCO();
            poco.Codigo = domain.Codigo;
            poco.CodigoCategoria = domain.CodigoCategoria;
            poco.Descricao = domain.Descricao;
            poco.Situacao = domain.Situacao;
            return poco;
        }

        public static Subcategoria ConverterParaDomain(SubcategoriaPOCO poco)
        {
            return new Subcategoria(poco.Codigo, poco.CodigoCategoria, poco.Descricao, poco.Situacao);
        }
    }
}
