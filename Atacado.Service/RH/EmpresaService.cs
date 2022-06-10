using Atacado.Business.RH;
using Atacado.DAL.RH.Admin;
using Atacado.Domain.RH;
using Atacado.Map.RH;
using Atacado.POCO.RH;
using Atacado.Service.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.RH
{
    public class EmpresaService :
       IAncestralSrv<EmpresaPOCO>

    {
        private EmpresaDAO dao;

        private EmpresaBizz bizz;

        private List<string> mensagensDeErro;

        public List<string> MensagensDeErro
        {
            get { return this.mensagensDeErro; }
        }

        public EmpresaService()
        {
            dao = new EmpresaDAO();
            this.bizz = new EmpresaBizz();
            this.mensagensDeErro = new List<string>();
        }

        public EmpresaPOCO Adicionar(EmpresaPOCO obj)
        {
            Empresa dom = EmpresaMap.ConverterParaDomain(obj);
            Empresa criado = this.dao.Create(dom);
            return EmpresaMap.ConverterParaPoco(criado);
        }

        public EmpresaPOCO Alterar(EmpresaPOCO obj)
        {
            Empresa dom = EmpresaMap.ConverterParaDomain(obj);
            Empresa alterado = this.dao.Update(dom);
            return EmpresaMap.ConverterParaPoco(alterado);
        }

        public EmpresaPOCO Excluir(EmpresaPOCO obj)
        {
            Empresa dom = EmpresaMap.ConverterParaDomain(obj);
            Empresa excluido = this.dao.Delete(dom);
            return EmpresaMap.ConverterParaPoco(excluido);
        }

        public List<EmpresaPOCO> ExcluirTodos(List<EmpresaPOCO> lista)
        {
            List<EmpresaPOCO> resultado = new List<EmpresaPOCO>();
            foreach (EmpresaPOCO item in lista)
            {
                Empresa dom = EmpresaMap.ConverterParaDomain(item);
                this.dao.Delete(dom);
                resultado.Add(item);
            }
            return resultado;
        }

        public List<EmpresaPOCO> Listar()
        {
            List<EmpresaPOCO> listPOCO = this.dao.ReadAll().Select(cat => new EmpresaPOCO()
            {
                Codigo = cat.Codigo,
                Telefone = cat.Telefone,
                Email = cat.Email,
                Endereco = cat.Endereco,
                RazaoSocial = cat.RazaoSocial,
                NomeFantasia = cat.NomeFantasia,
                Cnpj = cat.Cnpj,
                InscricaoEstadual = cat.InscricaoEstadual
            }).ToList();
            return listPOCO;
        }

        public EmpresaPOCO Selecionar(int id)
        {
            Empresa dom = this.dao.Read(id);
            if (dom != null)
                return EmpresaMap.ConverterParaPoco(dom);
            else
                return null;
        }

        public bool Validar(EmpresaPOCO obj)
        {
            Empresa dom = EmpresaMap.ConverterParaDomain(obj);
            if (this.bizz.Executar(dom) == false)
            {
                this.mensagensDeErro.AddRange(this.bizz.Mensagens);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
