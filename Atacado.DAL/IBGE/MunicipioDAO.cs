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
    public class MunicipioDAO : BaseAncestralDAO<Municipio>
    {
        public override Municipio Create(Municipio obj)
        {
            int chave = MunicipioFakeDB.Municipios.Max(cat => cat.Codigo) + 1;
            obj.Codigo = chave;
            MunicipioFakeDB.Municipios.Add(obj);
            return obj;
        }

        public override Municipio Read(int id)
        {
            Municipio obj = MunicipioFakeDB.Municipios.SingleOrDefault(cat => cat.Codigo == id);
            return obj;
        }

        public override List<Municipio> ReadALL()
        {
            return MunicipioFakeDB.Municipios;
        }

        public override Municipio Update(Municipio obj)
        {
            Municipio alt = this.Read(obj.Codigo);
            alt.CodigoUF=obj.CodigoUF;
            alt.SiglaUF=obj.SiglaUF;
            alt.CodigoMesoregiao = obj.CodigoMesoregiao;
            alt.CodigoMicroregiao = obj.CodigoMicroregiao;
            alt.CodigoIBGE7 = obj.CodigoIBGE7;
            alt.CodigoIBGE6 = obj.CodigoIBGE6;
            alt.PopulacaoMunicipio = obj.PopulacaoMunicipio;
            alt.PorteMunicipio=obj.PorteMunicipio;
            alt.Cep = obj.Cep;
            return alt;
        }
        public override Municipio Delete(int id)
        {
            Municipio del = this.Read(id);
            MunicipioFakeDB.Municipios.Remove(del);
            return del;
        }

        public override Municipio Delete(Municipio obj)
        {
            return this.Delete(obj.Codigo);
        }

    }
}
