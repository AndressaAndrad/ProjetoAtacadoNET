using Atacado.Service.Ancestral;
using Atacado.DAL.Estoque;
using Atacado.POCO.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atacado.Domain.Estoque;
using Atacado.Map.Estoque;

namespace Atacado.Service.Estoque
{
    public class ProdutoService : 
        IAcaoAdicionarSrv<ProdutoPOCO>, 
        IAcaoAlterarSrv<ProdutoPOCO>,
        IAcaoExcluirSrv<ProdutoPOCO>,
        IAcaoSelecionarSrv<ProdutoPOCO>,
        IAcaoListarSrv<ProdutoPOCO>  
    {
        private ProdutoDAO dao;

        public ProdutoService()
        {
            this.dao = new ProdutoDAO();
        }
        public ProdutoPOCO Adicionar (ProdutoPOCO obj)
        {
            Produto dom = ProdutoMap.ConverterParaDomain(obj);
            Produto criado = this.dao.Create(dom);
            return ProdutoMap.ConverterParaPoco(criado);
        }

        public ProdutoPOCO Alterar(ProdutoPOCO obj)
        {
            Produto dom = ProdutoMap.ConverterParaDomain(obj);
            Produto alterado = this.dao.Update(dom);
            return ProdutoMap.ConverterParaPoco(alterado);
        }

        public ProdutoPOCO Excluir(ProdutoPOCO obj)
        {
            Produto dom = ProdutoMap.ConverterParaDomain(obj);
            Produto excluido = this.dao.Delete(dom);
            return ProdutoMap.ConverterParaPoco(excluido);
        }

        public List<ProdutoPOCO> Listar()
        {
            List<ProdutoPOCO> listPOCO = this.dao.ReadAll().Select(cat => new ProdutoPOCO()
            {
                Codigo = cat.Codigo,
                Descricao = cat.Descricao,
                Situacao = cat.Situacao
            }).ToList();
            return listPOCO;
        }

        public ProdutoPOCO Selecionar(int id)
        {
            Produto dom = this.dao.Read(id);
            if (dom != null)
                return ProdutoMap.ConverterParaPoco(dom);
            else
                return null;
        }
    }
}
