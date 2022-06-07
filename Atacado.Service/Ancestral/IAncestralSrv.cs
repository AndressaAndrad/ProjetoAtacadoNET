using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Ancestral
{
    public interface IAncestralSrv<T> :
        IAcaoAdicionarSrv<T>,
        IAcaoAlterarSrv<T>,
        IAcaoExcluirSrv<T>,
        IAcaoExcluirTodosSrv<T>,
        IAcaoListarSrv<T>,
        IAcaoSelecionarSrv<T>,
        IAcaoValidarSrv<T>
    {

    }
}