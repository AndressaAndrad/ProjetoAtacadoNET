using Atacado.DAL.Ancestral;
using Atacado.FakeDB.IBGE;
using Atacado.Modelo.IBGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DAL.IBGE
{
    public class RegiaoDAO : BaseAncestralDAO<Regiao>
    {
        public override Regiao Create(Regiao obj)
        {
            int chave = RegiaoFakeDB.Regioes.Max(cat => cat.Codigo) + 1;
            obj.Codigo = chave;
            RegiaoFakeDB.Regioes.Add(obj);
            return obj;
        }

        public override Regiao Read(int id)
        {
            Regiao obj = RegiaoFakeDB.Regioes.SingleOrDefault(cat => cat.Codigo == id);
            return obj;
        }

        public override List<Regiao> ReadALL()
        {
            return RegiaoFakeDB.Regioes;
        }

        public override Regiao Update(Regiao obj)
        {
            Regiao alt = this.Read(obj.Codigo);
            alt.Descricao = obj.Descricao;
            return alt;
        }
        public override Regiao Delete(int id)
        {
            Regiao del = this.Read(id);
            RegiaoFakeDB.Regioes.Remove(del);
            return del;
        }

        public override Regiao Delete(Regiao obj)
        {
            return this.Delete(obj.Codigo); 
        }
    }
}
