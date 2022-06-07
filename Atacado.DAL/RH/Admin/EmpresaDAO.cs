using Atacado.DAL.Ancestral;
using Atacado.FakeDB.RH;
using Atacado.Domain.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DAL.RH.Admin
{
    public class EmpresaDAO : BaseAncestralDAO<Empresa>
    {
        public override Empresa Create(Empresa obj)
        {
            int chave = EmpresaFakeDB.Empresa.Max(cat => cat.Codigo) + 1;
            obj.Codigo = chave;
            EmpresaFakeDB.Empresa.Add(obj);
            return obj;
        }

        public override Empresa Read(int id)
        {
            Empresa obj = EmpresaFakeDB.Empresa.SingleOrDefault(cat => cat.Codigo == id);
            return obj;
        }

        public override List<Empresa> ReadAll()
        {
            return EmpresaFakeDB.Empresa;
        }

        public override Empresa Update(Empresa obj)
        {
            Empresa alt = this.Read(obj.Codigo);
            alt.RazaoSocial=obj.RazaoSocial;
            alt.NomeFantasia=obj.NomeFantasia;
            alt.Cnpj=obj.Cnpj;
            alt.InscricaoEstadual=obj.InscricaoEstadual;
            return alt;
        }
        public override Empresa Delete(int id)
        {
            Empresa del = this.Read(id);
            EmpresaFakeDB.Empresa.Remove(del);
            return del;
            
        }

        public override Empresa Delete(Empresa obj)
        {
            return this.Delete(obj.Codigo);
        }

    }
}
