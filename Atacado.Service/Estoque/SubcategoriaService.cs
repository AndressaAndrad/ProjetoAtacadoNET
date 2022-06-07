using Atacado.DAL.Estoque;
using Atacado.Domain.Estoque;
using Atacado.Map.Estoque;
using Atacado.POCO.Estoque;
using Atacado.Service.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Estoque
{
    public class SubcategoriaService :
        IAcaoExcluirSrv<SubcategoriaPOCO>,
        IAcaoAlterarSrv<SubcategoriaPOCO>,
        IAcaoAdicionarSrv<SubcategoriaPOCO>,
        IAcaoSelecionarSrv<SubcategoriaPOCO>,
        IAcaoListarSrv<SubcategoriaPOCO>
    {
        private SubcategoriaDAO dao;

        public SubcategoriaService()
        {
            dao = new SubcategoriaDAO();
        }

        public SubcategoriaPOCO Adicionar(SubcategoriaPOCO obj)
        {
            Subcategoria dom = SubcategoriaMap.ConverterParaDomain(obj);
            Subcategoria criado = this.dao.Create(dom);
            return SubcategoriaMap.ConverterParaPoco(criado);
        }

        public SubcategoriaPOCO Alterar(SubcategoriaPOCO obj)
        {
            Subcategoria dom = SubcategoriaMap.ConverterParaDomain(obj);
            Subcategoria alterado = this.dao.Update(dom);
            return SubcategoriaMap.ConverterParaPoco(alterado);
        }

        public SubcategoriaPOCO Excluir(SubcategoriaPOCO obj)
        {
            Subcategoria dom = SubcategoriaMap.ConverterParaDomain(obj);
            Subcategoria excluido = this.dao.Delete(dom);
            return SubcategoriaMap.ConverterParaPoco(excluido);
        }

        public List<SubcategoriaPOCO> Listar()
        {
            List<SubcategoriaPOCO> listPOCO = this.dao.ReadAll().Select(cat => new SubcategoriaPOCO()
            {
                Codigo = cat.Codigo,
                Descricao = cat.Descricao,
                Situacao = cat.Situacao
            }).ToList();
            return listPOCO;
        }

        public SubcategoriaPOCO Selecionar(int id)
        {
            Subcategoria dom = this.dao.Read(id);
            if (dom != null)
                return SubcategoriaMap.ConverterParaPoco(dom);
            else
                return null;
        }
    }
}
