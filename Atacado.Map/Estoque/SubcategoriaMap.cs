using Atacado.Modelo.Estoque;
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
        public static SubcategoriaPOCO ConverterParaPoco(Subcategoria modelo)
        {
            SubcategoriaPOCO poco = new SubcategoriaPOCO();
            poco.Codigo = modelo.Codigo;
            poco.CodigoCategoria = modelo.CodigoCategoria;
            poco.Descricao = modelo.Descricao;
            poco.Situacao = modelo.Situacao;
            return poco;
        }

        public static Subcategoria ConverterParaModelo(SubcategoriaPOCO poco)
        {
            return new Subcategoria(poco.Codigo, poco.CodigoCategoria, poco.Descricao, poco.Situacao);
        }
    }
}
