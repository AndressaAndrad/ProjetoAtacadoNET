using Atacado.Modelo.Estoque;
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
        public static CategoriaPOCO ConverterParaPoco(Categoria modelo)
        {
            CategoriaPOCO poco = new CategoriaPOCO();
            poco.Codigo = modelo.Codigo;
            poco.Descricao = modelo.Descricao;
            poco.Situacao = modelo.Situacao;

            return poco;
        }

        public static Categoria ConverterParaModelo( CategoriaPOCO poco)
        {
            return new Categoria(poco.Codigo, poco.Descricao, poco.Situacao);
            
        }
    }
}
