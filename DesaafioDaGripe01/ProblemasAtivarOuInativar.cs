using Atacado.FakeDB.RH;
using Atacado.Modelo.RH;
using DesafiosDaGripe01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesaafioDaGripe01
{
    public static class ProblemasAtivarOuInativar
    {
        public static Funcionario AtivarRegistro(int codigo)
        {
            Funcionario teste = FuncionarioFakeDB.Funcionarios.SingleOrDefault (fun => fun.Codigo == codigo);
            if (teste != null)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                teste.Situacao = SituacaoEnum.Ativo;
                ProblemasFuncionario.Exercicio01(teste);
                Console.ResetColor();
            }
            return teste;
        }
        public static Funcionario DesativarRegistro(int codigo)
        {
            Funcionario teste = FuncionarioFakeDB.Funcionarios.SingleOrDefault(fun => fun.Codigo == codigo);
            if (teste != null)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                teste.Situacao = SituacaoEnum.Inativo;
                ProblemasFuncionario.Exercicio01(teste);
                Console.ResetColor();
            }
            return teste;
        }
    } 
}
