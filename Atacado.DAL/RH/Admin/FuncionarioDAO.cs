using Atacado.DAL.Ancestral;
using Atacado.FakeDB.RH;
using Atacado.Modelo.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DAL.RH.Admin
{
    public class FuncionarioDAO : BaseAncestralDAO<Funcionario>
    {
        public override Funcionario Create(Funcionario obj)
        {
            int chave= FuncionarioFakeDB.Funcionarios.Max(cat=>cat.Codigo)+1;
            obj.Codigo = chave;
            FuncionarioFakeDB.Funcionarios.Add(obj);
            return obj;
        }

        public override Funcionario Read(int id)
        {
            Funcionario obj = FuncionarioFakeDB.Funcionarios.SingleOrDefault(cat=>cat.Codigo == id);
            return obj;
        }

        public override List<Funcionario> ReadALL()
        {
            return FuncionarioFakeDB.Funcionarios;
        }

        public override Funcionario Update(Funcionario obj)
        {
            Funcionario alt = this.Read(obj.Codigo);
            alt.Nome = obj.Nome;
            alt.SobreNome = obj.SobreNome;
            alt.Altura = obj.Altura;
            alt.Peso=obj.Peso;
            alt.Idade = obj.Idade;
            alt.DtNascimento = obj.DtNascimento;
            alt.Naturalidade=obj.Naturalidade;
            alt.Nacionalidade=obj.Nacionalidade;
            alt.Telefone= obj.Telefone;
            alt.Endereco= obj.Endereco;
            alt.Email  = obj.Email;
            alt.Cpf = obj.Cpf;
            alt.Rg = obj.Rg;
            return alt;
            
        }
        public override Funcionario Delete(int id)
        {
            Funcionario del = this.Read(id);
            FuncionarioFakeDB.Funcionarios.Remove(del);
            return del;
        }

        public override Funcionario Delete(Funcionario obj)
        {
           return this.Delete(obj.Codigo);
        }
    }
}
