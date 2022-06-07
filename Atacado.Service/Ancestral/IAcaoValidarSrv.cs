using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Ancestral
{
    public interface IAcaoValidarSrv<T>
    {
        List<string> MensagensDeErro { get; }

        bool Validar(T obj);

    }
}
