using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesaafioDaGripe01
{
    public static class ProblemasMatematicos
    {

        public static int Exercicio01(Operacoes op, int num1, int num2)
        {
            int resul = 0;
           switch ( op )
            {
                case Operacoes.Adicao:
                    resul = num1 + num2;
                    break;
                case Operacoes.Subtracao:
                    resul = num1 - num2;
                    break;
                case Operacoes.Multipiolicacao:
                    resul = num1 * num2;
                    break ;
                case Operacoes.Divisao:
                    resul = num1 / num2;
                    break;
                default:
                    break;
 
            }
            return resul;
        }

        public static double Exercicio02(double comprimento, double altura, double largura)
        {
            double resul = comprimento * largura * altura;

            return resul;
        }

        public static double Exercicio03(double altura, double raiodabase)
        {
            double resul = Math.PI * Math.Pow(raiodabase, 2) * altura ;
            return resul;
        }

        public static double Exercicio04(double raio)
        {
            double resul = (4 * Math.PI * Math.Pow(raio, 3)) / 3 ;
            return resul;
        }

    }
     
   
}
