using Atacado.Modelo.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Modelo.Estoque
{
    public class Produto : BaseCampoPadronizado03
    {
        private int codigoCategoria;
        private int codigoSubcategoria;


        public int CodigoCategoria { get { return codigoCategoria; } set { codigoCategoria = value; } }
        public int CodigoSubcategoria { get { return codigoSubcategoria; } set{ codigoSubcategoria = value; } }
        public Produto(int codigo, int codCategoria, int codSubcategoria, string descricao, int situacao) 
            : base(codigo, descricao, situacao)
        {
            this.codigoCategoria = codCategoria;
            this.codigoSubcategoria =codSubcategoria;
        }
    }
}
