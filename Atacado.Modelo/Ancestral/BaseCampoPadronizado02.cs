using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Modelo.Ancestral
{
    public abstract class BaseCampoPadronizado02 : BaseCampoPadronizado
    {
        protected string descricao;

        public string Descricao { get { return descricao; } set { descricao = value; } } 
        
        public BaseCampoPadronizado02(int codigo,string descricao) 
            : base(codigo)
        {
            this.descricao = descricao;
        }
    }
}
