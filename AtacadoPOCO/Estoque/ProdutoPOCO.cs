using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtacadoPOCO.Estoque
{
    public class ProdutoPOCO
    {
        public int Codigo { get; set; }
        public int CodigoCategoria { get; set; }
        public int CodigoSubcategoria { get; set; }
        public string Descricao { get; set; }
        public int Situacao { get; set; }

    }
}
