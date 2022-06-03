using Atacado.Modelo.Estoque;
using Atacado.POCO.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.Estoque
{
    public static class ProdutoMap
    {
        public static ProdutoPOCO ConverterParaPoco(Produto modelo)
        {
            ProdutoPOCO poco = new ProdutoPOCO();
            poco.Codigo = modelo.Codigo;
            poco.CodigoCategoria = modelo.CodigoCategoria;
            poco.CodigoSubcategoria = modelo.CodigoSubcategoria;
            poco.Descricao = modelo.Descricao;
            poco.Situacao = modelo.Situacao;
            return poco;
        }

        public static Produto ConverterParaModelo(ProdutoPOCO poco)
        {
            return new Produto(poco.Codigo, poco.CodigoCategoria, poco.CodigoSubcategoria, 
                poco.Descricao, poco.Situacao);
        }

    }
}
