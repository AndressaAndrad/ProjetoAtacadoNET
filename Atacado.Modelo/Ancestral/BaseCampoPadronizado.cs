using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Domain.Ancestral
{
    public abstract class BaseCampoPadronizado
    {
        protected int codigo;

        public int Codigo { get => codigo; set => codigo = value; }

        public BaseCampoPadronizado(int codigo)
        {
            this.codigo = codigo;
        }

    }
}
