using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Ancestral
{
    public interface IAcaoExcluirTodosSrv<T>
    {
        List<T> ExcluirTodos(List<T> lista);
    }
}
