using Atacado.FakeDB.RH;
using Atacado.FakeDB.IBGE;
using Atacado.Domain.IBGE;
using Atacado.Domain.RH;
using Atacado.DAL.Estoque;
using Atacado.Domain.Estoque;
using Atacado.DAL.RH;
using Atacado.DAL.IBGE;
using Atacado.DAL.RH.Admin;

namespace TesteAtacadoDAL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Informe o código: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            ApresentarFuncionario(codigo);
            Console.ReadLine();
        }

        private static void ApresentarCategoria(int id)
        {

            CategoriaDAO dao = new CategoriaDAO();
            Categoria cat = dao.Read(id);
            Imprimir(cat);

        }

        private static void Imprimir(Categoria cat)
        {
            Console.WriteLine("Código {0} - ", cat.Codigo);
            Console.Write("Nome {0} - ", cat.Descricao);
            Console.Write("Situação {0} - ", cat.Situacao);
        }

        private static void ApresentarFuncionario(int cod)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            Funcionario cat = dao.Read(cod);
            ImprimirFuncionario(cat);
            
        }
        private static void ImprimirFuncionario (Funcionario cat)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Código {0}", cat.Codigo);
            Console.Write("Nome: {0} {1}- ",cat.Nome, cat.SobreNome);
            Console.Write("Sexo: {0} - ", cat.Sexo);
            Console.Write("Email: {0} - ", cat.Email);
            Console.Write("Telefone: {0}", cat.Telefone);
        }
        private static void ApresentarMunicipio( int cod)
        { 
            MunicipioDAO dao = new MunicipioDAO();
            Municipio cat = dao.Read(cod);  
            //ImprimirMunicipio(cat);
        }
        
    }   
}
