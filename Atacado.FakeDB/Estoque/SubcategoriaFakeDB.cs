using Atacado.Modelo.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.FakeDB.Estoque
{
    public static class SubcategoriaFakeDB
    {
        private static List<Subcategoria> subcategorias = new List<Subcategoria>();

        public static List<Subcategoria> Subcategorias
        {
            get
            {
                if (subcategorias.Count() == 0)
                {
                    AdicionarSubcategorias();
                }
                return subcategorias;
            }
        }

        private static void AdicionarSubcategorias()
        {
            subcategorias.Add(new Subcategoria(1, 1, "Papinha", 1));
            subcategorias.Add(new Subcategoria(2, 1, "Sopinha", 1));
            subcategorias.Add(new Subcategoria(3, 2, "Proteína", 1));
            subcategorias.Add(new Subcategoria(4, 2, "Carboidratos", 1));
            subcategorias.Add(new Subcategoria(5, 2, "Vitaminas", 1));
            subcategorias.Add(new Subcategoria(6, 2, "Hipercalóricos", 1));
            subcategorias.Add(new Subcategoria(7, 2, "Óxido Nítrico", 1));
            subcategorias.Add(new Subcategoria(8, 2, "Aminoácidos", 1));
            subcategorias.Add(new Subcategoria(9, 2, "Propriedade Funcional", 1));
            subcategorias.Add(new Subcategoria(10, 3, "Achocolatados", 1));
            subcategorias.Add(new Subcategoria(11, 3, "Bebidas a Base de Soja", 1));
            subcategorias.Add(new Subcategoria(12, 3, "Bebidas Alcoólicas", 1));
            subcategorias.Add(new Subcategoria(13, 3, "Café e Cia", 1));
            subcategorias.Add(new Subcategoria(14, 3, "Chás", 1));
            subcategorias.Add(new Subcategoria(15, 3, "Isotônicos e Energéticos", 1));
            subcategorias.Add(new Subcategoria(16, 3, "Refrescos em Pó", 1));
            subcategorias.Add(new Subcategoria(17, 3, "Refrigerantes", 1));
            subcategorias.Add(new Subcategoria(18, 3, "Sucos Concentrados", 1));
            subcategorias.Add(new Subcategoria(19, 3, "Sucos de Frutas Prontos", 1));
            subcategorias.Add(new Subcategoria(20, 3, "Sucos Naturais", 1));
            subcategorias.Add(new Subcategoria(21, 3, "Sucos Orgânicos", 1));
            subcategorias.Add(new Subcategoria(22, 4, "Biscoitos e Bolachas", 1));
            subcategorias.Add(new Subcategoria(23, 4, "Bolos Caseiros", 1));
            subcategorias.Add(new Subcategoria(24, 4, "Bolos Prontos", 1));
            subcategorias.Add(new Subcategoria(25, 4, "Misturas para Bolos", 1));
            subcategorias.Add(new Subcategoria(26, 5, "Aves (Frango, Peru, etc)", 1));
            subcategorias.Add(new Subcategoria(27, 5, "Boi", 1));
            subcategorias.Add(new Subcategoria(28, 5, "Frutos do Mar", 1));
            subcategorias.Add(new Subcategoria(29, 5, "Hamburguers", 1));
            subcategorias.Add(new Subcategoria(30, 5, "Outras Carnes", 1));
            subcategorias.Add(new Subcategoria(31, 5, "Peixes", 1));
            subcategorias.Add(new Subcategoria(32, 5, "Porco", 1));
            subcategorias.Add(new Subcategoria(33, 5, "Vitela", 1));
            subcategorias.Add(new Subcategoria(34, 6, "Empanados", 1));
            subcategorias.Add(new Subcategoria(35, 6, "Hamburguers", 1));
            subcategorias.Add(new Subcategoria(36, 6, "Legumes & Cia Congelados", 1));
            subcategorias.Add(new Subcategoria(37, 6, "Pizzas Congeladas", 1));
            subcategorias.Add(new Subcategoria(38, 6, "Polpas de Frutas Congeladas", 1));
            subcategorias.Add(new Subcategoria(39, 6, "Pratos Prontos Congelados", 1));
            subcategorias.Add(new Subcategoria(40, 6, "Salgados Congelados", 1));
            subcategorias.Add(new Subcategoria(41, 7, "Conservas em Geral", 1));
            subcategorias.Add(new Subcategoria(42, 8, "Adoçantes", 1));
            subcategorias.Add(new Subcategoria(43, 8, "Balas", 1));
            subcategorias.Add(new Subcategoria(44, 8, "Chicletes", 1));
            subcategorias.Add(new Subcategoria(45, 8, "Chocolates", 1));
            subcategorias.Add(new Subcategoria(46, 8, "Doces de Frutas", 1));
            subcategorias.Add(new Subcategoria(47, 8, "Doces Diversos", 1));
            subcategorias.Add(new Subcategoria(48, 8, "Gelatinas", 1));
            subcategorias.Add(new Subcategoria(49, 8, "Geléias", 1));
            subcategorias.Add(new Subcategoria(50, 8, "Ingredientes Doces", 1));
            subcategorias.Add(new Subcategoria(51, 8, "Mel e Xaropes", 1));
            subcategorias.Add(new Subcategoria(52, 8, "Sobremesas em Pó", 1));
            subcategorias.Add(new Subcategoria(53, 8, "Sobremesas Lácteas", 1));
            subcategorias.Add(new Subcategoria(54, 8, "Sorvetes", 1));
            subcategorias.Add(new Subcategoria(55, 8, "Tortas", 1));
            subcategorias.Add(new Subcategoria(56, 9, "Cereal Matinal", 1));
            subcategorias.Add(new Subcategoria(57, 9, "Farinhas e Cereais Diversos", 1));
            subcategorias.Add(new Subcategoria(58, 9, "Mingau e Cia", 1));
            subcategorias.Add(new Subcategoria(59, 10, "Amendoim e Etc", 1));
            subcategorias.Add(new Subcategoria(60, 10, "Batata Frita", 1));
            subcategorias.Add(new Subcategoria(61, 10, "Bobs", 1));
            subcategorias.Add(new Subcategoria(62, 10, "Casa da Empada", 1));
            subcategorias.Add(new Subcategoria(63, 10, "Habibs", 1));
            subcategorias.Add(new Subcategoria(64, 10, "Mc Donalds", 1));
            subcategorias.Add(new Subcategoria(65, 10, "Pastas & Patês", 1));
            subcategorias.Add(new Subcategoria(66, 10, "Petiscos Diversos", 1));
            subcategorias.Add(new Subcategoria(67, 10, "Pipoca", 1));
            subcategorias.Add(new Subcategoria(68, 10, "Pizzas Congeladas", 1));
            subcategorias.Add(new Subcategoria(69, 10, "Rei do Mate", 1));
            subcategorias.Add(new Subcategoria(70, 10, "Salgadinhos & Snacks", 1));
            subcategorias.Add(new Subcategoria(71, 11, "Frios e Embutidos em Geral", 1));
            subcategorias.Add(new Subcategoria(72, 12, "Doces de Frutas", 1));
            subcategorias.Add(new Subcategoria(73, 12, "Frutas Diversas", 1));
            subcategorias.Add(new Subcategoria(74, 12, "Frutas Secas e em Calda", 1));
            subcategorias.Add(new Subcategoria(75, 12, "Polpas de Frutas Congeladas", 1));
            subcategorias.Add(new Subcategoria(76, 12, "Sucos Concentrados", 1));
            subcategorias.Add(new Subcategoria(77, 12, "Sucos de Frutas Prontos", 1));
            subcategorias.Add(new Subcategoria(78, 12, "Sucos Naturais", 1));
            subcategorias.Add(new Subcategoria(79, 12, "Sucos Orgânicos", 1));
            subcategorias.Add(new Subcategoria(80, 13, "Legumes & Cia Congelados", 1));
            subcategorias.Add(new Subcategoria(81, 13, "Legumes e Cia Naturais", 1));
            subcategorias.Add(new Subcategoria(82, 14, "Massas em Geral", 1));
            subcategorias.Add(new Subcategoria(83, 15, "Caldos", 1));
            subcategorias.Add(new Subcategoria(84, 15, "Catchup & Mostarda", 1));
            subcategorias.Add(new Subcategoria(85, 15, "Maionese", 1));
            subcategorias.Add(new Subcategoria(86, 15, "Molhos", 1));
            subcategorias.Add(new Subcategoria(87, 15, "Outros Condimentos", 1));
            subcategorias.Add(new Subcategoria(88, 16, "Iogurtes", 1));
            subcategorias.Add(new Subcategoria(89, 16, "Leite", 1));
            subcategorias.Add(new Subcategoria(90, 16, "Milkshakes", 1));
            subcategorias.Add(new Subcategoria(91, 16, "Ovos", 1));
            subcategorias.Add(new Subcategoria(92, 16, "Queijos", 1));
            subcategorias.Add(new Subcategoria(93, 16, "Sobremesas Lácteas", 1));
            subcategorias.Add(new Subcategoria(94, 17, "Pães em Geral", 1));
            subcategorias.Add(new Subcategoria(95, 18, "Sopas em Geral", 1));
            subcategorias.Add(new Subcategoria(96, 19, "Diversos sem Categoria", 1));


        }
    }
}
