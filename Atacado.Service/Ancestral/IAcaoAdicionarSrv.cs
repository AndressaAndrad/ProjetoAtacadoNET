using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Ancestral
{
    public interface IAcaoAdicionarSrv<T>
    {
        T Adicionar(T obj);
    }
}
