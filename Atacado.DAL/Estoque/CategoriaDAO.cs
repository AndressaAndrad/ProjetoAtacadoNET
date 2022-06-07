
using Atacado.DAL.Ancestral;
using Atacado.FakeDB.Estoque;
using Atacado.Domain.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DAL.Estoque
{
    public class CategoriaDAO : BaseAncestralDAO<Categoria>
    {
        public override Categoria Create(Categoria obj)
        {
            int chave = CategoriaFakeDB.Categorias.Max(cat => cat.Codigo) + 1;
            CategoriaFakeDB.Categorias.Add(obj);
            return obj;
        }

        public override Categoria Read(int id)
        {
            Categoria obj = CategoriaFakeDB.Categorias.FirstOrDefault(cat => cat.Codigo == id);
            return obj;
        }

        public override List<Categoria> ReadAll()
        {
            return CategoriaFakeDB.Categorias;
        }

        public override Categoria Update(Categoria obj)
        {
            Categoria alt = this.Read(obj.Codigo);
            alt.Descricao = obj.Descricao;
            alt.Situacao = obj.Situacao;
            return alt;
        }

        public override Categoria Delete(int id)
        {
            Categoria del = this.Read(id);
            CategoriaFakeDB.Categorias.Remove(del);
            return del;
        }

        public override Categoria Delete(Categoria obj)
        {
            return this.Delete(obj.Codigo);
        }
    }
}