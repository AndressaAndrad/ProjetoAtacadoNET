using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Modelo.Ancestral
{
    public abstract class BaseCampoPadronizado03 : BaseCampoPadronizado02
    {
        protected int situacao;

        public int Situacao { get => situacao; set => situacao = value; }

        public BaseCampoPadronizado03(int codigo, string descricao,int situcao) : base(codigo, descricao)
        {
            this.situacao = situcao;
        }
    }
}
