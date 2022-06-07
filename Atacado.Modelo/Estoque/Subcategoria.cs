using Atacado.Domain.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Domain.Estoque
{
    public class Subcategoria : BaseCampoPadronizado03
    {
        private int codigoCategoria;
        private List<Produto> produtos; 

        public int CodigoCategoria { get => codigoCategoria; set => codigoCategoria = value; }
        public List<Produto> Produtos { get => produtos; set => produtos = value; }

        public Subcategoria(int codigo, int codigoCategoria, string descricao, int situacao) 
            : base(codigo, descricao, situacao)
        {
            this.codigoCategoria = codigoCategoria;
        }
     
    }
}
