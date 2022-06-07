using Atacado.Domain.Estoque;
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
        public static ProdutoPOCO ConverterParaPoco(Produto domain)
        {
            ProdutoPOCO poco = new ProdutoPOCO();
            poco.Codigo = domain.Codigo;
            poco.CodigoCategoria = domain.CodigoCategoria;
            poco.CodigoSubcategoria = domain.CodigoSubcategoria;
            poco.Descricao = domain.Descricao;
            poco.Situacao = domain.Situacao;
            return poco;
        }

        public static Produto ConverterParaDomain(ProdutoPOCO poco)
        {
            return new Produto(poco.Codigo, poco.CodigoCategoria, poco.CodigoSubcategoria, 
                poco.Descricao, poco.Situacao);
        }

    }
}
