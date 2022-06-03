using Atacado.Modelo.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Modelo.IBGE
{
    public class Estado : BaseCampoPadronizado02
    {
        private string siglaUF;

        private string regiaoBrasil;

        private List<Municipio> municipios;

        public string SiglaUF { get => siglaUF; set => siglaUF = value; }

        public string RegiaoBrasil { get => regiaoBrasil; set => regiaoBrasil = value; }
        public List<Municipio> Municipios { get => municipios; set => municipios = value; }

        public Estado(int codigo, string descricao, string siglaUF, string regiaoBrasil)
            : base(codigo, descricao)
        {
            this.siglaUF = siglaUF;
            this.regiaoBrasil = regiaoBrasil;
        }
    }
}
