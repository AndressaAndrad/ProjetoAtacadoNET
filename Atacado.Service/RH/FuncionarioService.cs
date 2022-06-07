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
    public class FuncionarioService :
        IAncestralSrv<FuncionarioPOCO>
    {
        private FuncionarioDAO dao;

        private FuncionarioBizz bizz;

        private List<string> mensagensDeErro;

        public List<string> MensagensDeErro
        {
            get { return this.mensagensDeErro; }
        }

        public FuncionarioService()
        {
            dao = new FuncionarioDAO();
            this.bizz = new FuncionarioBizz();
            this.mensagensDeErro = new List<string>();  
        }

        public FuncionarioPOCO Adicionar(FuncionarioPOCO obj)
        {
            Funcionario dom = FuncionarioMap.ConverterParaDomain(obj);
            Funcionario criado = this.dao.Create(dom);
            return FuncionarioMap.ConverterParaPoco(criado);
        }

        public FuncionarioPOCO Alterar(FuncionarioPOCO obj)
        {
            Funcionario dom = FuncionarioMap.ConverterParaDomain(obj);
            Funcionario alterado = this.dao.Update(dom);
            return FuncionarioMap.ConverterParaPoco(alterado);
        }

        public FuncionarioPOCO Excluir(FuncionarioPOCO obj)
        {
            Funcionario dom = FuncionarioMap.ConverterParaDomain(obj);
            Funcionario excluido = this.dao.Delete(dom);
            return FuncionarioMap.ConverterParaPoco(excluido);
        }

        public List<FuncionarioPOCO> ExcluirTodos(List<FuncionarioPOCO> lista)
        {
           List<FuncionarioPOCO> resultado = new List<FuncionarioPOCO>();
            foreach(FuncionarioPOCO item in lista)
            {
                Funcionario dom = FuncionarioMap.ConverterParaDomain(item);
                this.dao.Delete(dom);
                resultado.Add(item);
            }
            return resultado;
        }

        public List<FuncionarioPOCO> Listar()
        {
            List<FuncionarioPOCO> listPOCO = this.dao.ReadAll().Select(cat => new FuncionarioPOCO()
            {
                Codigo = cat.Codigo,
                Telefone = cat.Telefone,
                Email = cat.Email,
                Endereco = cat.Endereco,
                Nome = cat.Nome,
                SobreNome = cat.SobreNome,
                Idade = cat.Idade,
                Altura = cat.Altura,
                Peso = cat.Peso,
                DtNascimento = cat.DtNascimento,
                Naturalidade = cat.Naturalidade,
                Nacionalidade = cat.Nacionalidade,
                Sexo = cat.Sexo,
                Cpf = cat.Cpf,
                Rg = cat.Rg
            }).ToList();
            return listPOCO;
        }

        public FuncionarioPOCO Selecionar(int id)
        {
            Funcionario dom = this.dao.Read(id);
            if (dom != null)
                return FuncionarioMap.ConverterParaPoco(dom);
            else
                return null;
        }

        public bool Validar(FuncionarioPOCO obj)
        {
            Funcionario dom = FuncionarioMap.ConverterParaDomain(obj);
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
