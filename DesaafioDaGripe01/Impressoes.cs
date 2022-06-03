using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesaafioDaGripe01
{
    public static class Impressoes
    {
        public static void ImprimirCabecalho(string mensagem)
        {
            Console.Clear();
            Console.WriteLine(mensagem);
        }

        public static void ImprimirRodape(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("-- Tecle <ENTER> para seguir. --");
            Console.ReadLine();
        }

    }
}
