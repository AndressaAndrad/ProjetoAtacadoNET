using Atacado.Domain.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.FakeDB.Estoque
{
    public static class CategoriaFakeDB
    {
        private static List<Categoria> categorias = new List<Categoria>();

        public static List<Categoria> Categorias
        {
            get
            {
                if (categorias.Count() == 0)
                {
                    AdicionarCategorias();
                }
                return categorias;
            }
        }

        private static void AdicionarCategorias()
        {
            categorias.Add(new Categoria(1, "Alimento Infantil", 1));
            categorias.Add(new Categoria(2, "Suplementos", 1));
            categorias.Add(new Categoria(3, "Bebidas", 1));
            categorias.Add(new Categoria(4, "Biscoitos, Bolos e Bolachas", 1));
            categorias.Add(new Categoria(5, "Carnes", 1));
            categorias.Add(new Categoria(6, "Congelados", 1));
            categorias.Add(new Categoria(7, "Conservas", 1));
            categorias.Add(new Categoria(8, "Doces, Balas, Chocolates e Cia", 1));
            categorias.Add(new Categoria(9, "Farinhas, Cereais e Complementos", 1));
            categorias.Add(new Categoria(10, "Fast-Food, Aperitivos e Petiscos", 1));
            categorias.Add(new Categoria(11, "Frios e Embutidos", 1));
            categorias.Add(new Categoria(12, "Frutas", 1));
            categorias.Add(new Categoria(13, "Legumes, Verduras e Grãos", 1));
            categorias.Add(new Categoria(14, "Massas", 1));
            categorias.Add(new Categoria(15, "Molhos, Caldos e Condimentos", 1));
            categorias.Add(new Categoria(16, "Ovos, Leite, Queijo e Cia", 1));
            categorias.Add(new Categoria(17, "Pães", 1));
            categorias.Add(new Categoria(18, "Sopas & Cremes", 1));
            categorias.Add(new Categoria(19, "Diversos", 1));

        }
    }
}
