using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atacado.DAL.Estoque;
using Atacado.Domain.Estoque;
using Atacado.Map.Estoque;
using Atacado.POCO.Estoque;
using Atacado.Service.Ancestral;

namespace Atacado.Service.Estoque
{
    public class CategoriaService :
        IAcaoAdicionarSrv<CategoriaPOCO>,
        IAcaoAlterarSrv<CategoriaPOCO>,
        IAcaoExcluirSrv<CategoriaPOCO>,
        IAcaoListarSrv<CategoriaPOCO>,
        IAcaoSelecionarSrv<CategoriaPOCO>
    {
        private CategoriaDAO dao;

        public CategoriaService()
        {
            this.dao = new CategoriaDAO();
        }

        public CategoriaPOCO Adicionar(CategoriaPOCO obj)
        {
            Categoria dom = CategoriaMap.ConverterParaDomain(obj);
            Categoria criado = this.dao.Create(dom);
            return CategoriaMap.ConverterParaPoco(criado);
        }

        public CategoriaPOCO Alterar(CategoriaPOCO obj)
        {
            Categoria dom = CategoriaMap.ConverterParaDomain(obj);
            Categoria alterado = this.dao.Update(dom);
            return CategoriaMap.ConverterParaPoco(alterado);
        }

        public CategoriaPOCO Excluir(CategoriaPOCO obj)
        {
            Categoria dom = CategoriaMap.ConverterParaDomain(obj);
            Categoria excluido = this.dao.Delete(dom);
            return CategoriaMap.ConverterParaPoco(excluido);
        }

        public List<CategoriaPOCO> Listar()
        {
            // FORMA OTIMIZADA:
            List<CategoriaPOCO> listPOCO = this.dao.ReadAll().Select(cat => new CategoriaPOCO()
            {
                Codigo = cat.Codigo,
                Descricao = cat.Descricao,
                Situacao = cat.Situacao
            }).ToList();
            return listPOCO;


            // FORMA BÁSICA:
            //List<CategoriaPOCO> listPOCO = new List<CategoriaPOCO>();
            //foreach (Categoria item in this.dao.ReadAll())
            //{
            //    CategoriaPOCO poco = new CategoriaPOCO();
            //    {
            //        Codigo = item.Codigo,
            //        Descricao = item.Descricao,
            //        Situacao = item.Situacao
            //    };
            //    listPOCO.Add(poco);
            //}
            //return listPOCO;
        }

        public CategoriaPOCO Selecionar(int id)
        {
            Categoria dom = this.dao.Read(id);
            if (dom != null)
                return CategoriaMap.ConverterParaPoco(dom);
            else
                return null;
        }
    }
}