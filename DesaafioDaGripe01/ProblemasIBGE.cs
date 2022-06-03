using Atacado.Modelo.IBGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesaafioDaGripe01
{
    public static class ProblemasIBGE
    {
        public static void Exercicio01(Estado sigla)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sigla {0}", sigla.SiglaUF);
            Console.WriteLine("Codigo {0}", sigla.Codigo);
            Console.WriteLine("Desacrição {0}", sigla.Descricao);
            Console.WriteLine("Região {0}", sigla.RegiaoBrasil);
            Console.ResetColor();
        }
        public static void Exercicio02(Municipio sigla)
        {
            
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sigla {0}  ", sigla.SiglaUF);
                Console.Write("Código: {0}  ", sigla.Codigo);
                Console.Write("Nome: {0} ", sigla.Descricao);
                Console.Write("Sigla: {0} ", sigla.SiglaUF);
                Console.WriteLine("Cód. IBGE 7: {0} ", sigla.CodigoIBGE7);
               Console.ResetColor();
        }
        public static void Exercicio03(Estado regiao)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Região : {0}", regiao.RegiaoBrasil);
            Console.Write("Codigo {0}", regiao.Codigo);
            Console.WriteLine("Desacrição {0}", regiao.Descricao);
            Console.ResetColor();

        }
    }
}
