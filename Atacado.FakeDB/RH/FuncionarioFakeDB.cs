using Atacado.Modelo.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.FakeDB.RH
{
    public static class FuncionarioFakeDB
    {
        private static List<Funcionario> funcionarios = new List<Funcionario>();

        public static List<Funcionario> Funcionarios
        {
            get
            {
                if (funcionarios.Count() == 0)
                {
                    AdicionarFuncionarios();
                }
                return funcionarios;
            }
        }

        private static void AdicionarFuncionarios()
        {
            funcionarios.Add(new Funcionario(1, "Georgi", "Facello", "20100150001", "1-408-555-1953", "M", Convert.ToDateTime("1953-09-02 00:00:00.000"), "facello.georgi@acme.com"));
            funcionarios.Add(new Funcionario(2, "Bezalel", "Simmel", "20100150002", "1-408-555-1964", "F", Convert.ToDateTime("1964-06-02 00:00:00.000"), "simmel.bezalel@acme.com"));
            funcionarios.Add(new Funcionario(3, "Parto", "Bamford", "20100150003", "1-408-555-1959", "M", Convert.ToDateTime("1959-12-03 00:00:00.000"), "bamford.parto@acme.com"));
            funcionarios.Add(new Funcionario(4, "Chirstian", "Koblick", "20100150004", "1-408-555-1954", "M", Convert.ToDateTime("1954-05-01 00:00:00.000"), "koblick.chirstian@acme.com"));
            funcionarios.Add(new Funcionario(5, "Kyoichi", "Maliniak", "20100150005", "1-408-555-1955", "M", Convert.ToDateTime("1955-01-21 00:00:00.000"), "maliniak.kyoichi@acme.com"));
            funcionarios.Add(new Funcionario(6, "Anneke", "Preusig", "20100150006", "1-408-555-1953", "F", Convert.ToDateTime("1953-04-20 00:00:00.000"), "preusig.anneke@acme.com"));
            funcionarios.Add(new Funcionario(7, "Tzvetan", "Zielinski", "20100150007", "1-408-555-1957", "F", Convert.ToDateTime("1957-05-23 00:00:00.000"), "zielinski.tzvetan@acme.com"));
            funcionarios.Add(new Funcionario(8, "Saniya", "Kalloufi", "20100150008", "1-408-555-1958", "M", Convert.ToDateTime("1958-02-19 00:00:00.000"), "kalloufi.saniya@acme.com"));
            funcionarios.Add(new Funcionario(9, "Sumant", "Peac", "20100150009", "1-408-555-1952", "F", Convert.ToDateTime("1952-04-19 00:00:00.000"), "peac.sumant@acme.com"));
            funcionarios.Add(new Funcionario(10, "Duangkaew", "Piveteau", "20100150010", "1-408-555-1963", "F", Convert.ToDateTime("1963-06-01 00:00:00.000"), "piveteau.duangkaew@acme.com"));
            funcionarios.Add(new Funcionario(11, "Mary", "Sluis", "20100150011", "1-408-555-1953", "F", Convert.ToDateTime("1953-11-07 00:00:00.000"), "sluis.mary@acme.com"));
            funcionarios.Add(new Funcionario(12, "Patricio", "Bridgland", "20100150012", "1-408-555-1960", "M", Convert.ToDateTime("1960-10-04 00:00:00.000"), "bridgland.patricio@acme.com"));
            funcionarios.Add(new Funcionario(13, "Eberhardt", "Terkki", "20100150013", "1-408-555-1963", "M", Convert.ToDateTime("1963-06-07 00:00:00.000"), "terkki.eberhardt@acme.com"));
            funcionarios.Add(new Funcionario(14, "Berni", "Genin", "20100150014", "1-408-555-1956", "M", Convert.ToDateTime("1956-02-12 00:00:00.000"), "genin.berni@acme.com"));
            funcionarios.Add(new Funcionario(15, "Guoxiang", "Nooteboom", "20100150015", "1-408-555-1959", "M", Convert.ToDateTime("1959-08-19 00:00:00.000"), "nooteboom.guoxiang@acme.com"));
            funcionarios.Add(new Funcionario(16, "Kazuhito", "Cappelletti", "20100150016", "1-408-555-1961", "M", Convert.ToDateTime("1961-05-02 00:00:00.000"), "cappelletti.kazuhito@acme.com"));
            funcionarios.Add(new Funcionario(17, "Cristinel", "Bouloucos", "20100150017", "1-408-555-1958", "F", Convert.ToDateTime("1958-07-06 00:00:00.000"), "bouloucos.cristinel@acme.com"));
            funcionarios.Add(new Funcionario(18, "Kazuhide", "Peha", "20100150018", "1-408-555-1954", "F", Convert.ToDateTime("1954-06-19 00:00:00.000"), "peha.kazuhide@acme.com"));
            funcionarios.Add(new Funcionario(19, "Lillian", "Haddadi", "20100150019", "1-408-555-1953", "M", Convert.ToDateTime("1953-01-23 00:00:00.000"), "haddadi.lillian@acme.com"));
            funcionarios.Add(new Funcionario(20, "Mayuko", "Warwick", "20100150020", "1-408-555-1952", "M", Convert.ToDateTime("1952-12-24 00:00:00.000"), "warwick.mayuko@acme.com"));
            funcionarios.Add(new Funcionario(21, "Ramzi", "Erde", "20100150021", "1-408-555-1960", "M", Convert.ToDateTime("1960-02-20 00:00:00.000"), "erde.ramzi@acme.com"));
            funcionarios.Add(new Funcionario(22, "Shahaf", "Famili", "20100150022", "1-408-555-1952", "M", Convert.ToDateTime("1952-07-08 00:00:00.000"), "famili.shahaf@acme.com"));
            funcionarios.Add(new Funcionario(23, "Bojan", "Montemayor", "20100150023", "1-408-555-1953", "F", Convert.ToDateTime("1953-09-29 00:00:00.000"), "montemayor.bojan@acme.com"));
            funcionarios.Add(new Funcionario(24, "Suzette", "Pettey", "20100150024", "1-408-555-1958", "F", Convert.ToDateTime("1958-09-05 00:00:00.000"), "pettey.suzette@acme.com"));
            funcionarios.Add(new Funcionario(25, "Prasadram", "Heyers", "20100150025", "1-408-555-1958", "M", Convert.ToDateTime("1958-10-31 00:00:00.000"), "heyers.prasadram@acme.com"));
            funcionarios.Add(new Funcionario(26, "Yongqiao", "Berztiss", "20100150026", "1-408-555-1953", "M", Convert.ToDateTime("1953-04-03 00:00:00.000"), "berztiss.yongqiao@acme.com"));
            funcionarios.Add(new Funcionario(27, "Divier", "Reistad", "20100150027", "1-408-555-1962", "F", Convert.ToDateTime("1962-07-10 00:00:00.000"), "reistad.divier@acme.com"));
            funcionarios.Add(new Funcionario(28, "Domenick", "Tempesti", "20100150028", "1-408-555-1963", "M", Convert.ToDateTime("1963-11-26 00:00:00.000"), "tempesti.domenick@acme.com"));
            funcionarios.Add(new Funcionario(29, "Otmar", "Herbst", "20100150029", "1-408-555-1956", "M", Convert.ToDateTime("1956-12-13 00:00:00.000"), "herbst.otmar@acme.com"));
            funcionarios.Add(new Funcionario(30, "Elvis", "Demeyer", "20100150030", "1-408-555-1958", "M", Convert.ToDateTime("1958-07-14 00:00:00.000"), "demeyer.elvis@acme.com"));
            funcionarios.Add(new Funcionario(31, "Karsten", "Joslin", "20100150031", "1-408-555-1959", "M", Convert.ToDateTime("1959-01-27 00:00:00.000"), "joslin.karsten@acme.com"));
            funcionarios.Add(new Funcionario(32, "Jeong", "Reistad", "20100150032", "1-408-555-1960", "F", Convert.ToDateTime("1960-08-09 00:00:00.000"), "reistad.jeong@acme.com"));
            funcionarios.Add(new Funcionario(33, "Arif", "Merlo", "20100150033", "1-408-555-1956", "M", Convert.ToDateTime("1956-11-14 00:00:00.000"), "merlo.arif@acme.com"));
            funcionarios.Add(new Funcionario(34, "Bader", "Swan", "20100150034", "1-408-555-1962", "M", Convert.ToDateTime("1962-12-29 00:00:00.000"), "swan.bader@acme.com"));
            funcionarios.Add(new Funcionario(35, "Alain", "Chappelet", "20100150035", "1-408-555-1953", "M", Convert.ToDateTime("1953-02-08 00:00:00.000"), "chappelet.alain@acme.com"));
            funcionarios.Add(new Funcionario(36, "Adamantios", "Portugali", "20100150036", "1-408-555-1959", "M", Convert.ToDateTime("1959-08-10 00:00:00.000"), "portugali.adamantios@acme.com"));
            funcionarios.Add(new Funcionario(37, "Pradeep", "Makrucki", "20100150037", "1-408-555-1963", "M", Convert.ToDateTime("1963-07-22 00:00:00.000"), "makrucki.pradeep@acme.com"));
            funcionarios.Add(new Funcionario(38, "Huan", "Lortz", "20100150038", "1-408-555-1960", "M", Convert.ToDateTime("1960-07-20 00:00:00.000"), "lortz.huan@acme.com"));
            funcionarios.Add(new Funcionario(39, "Alejandro", "Brender", "20100150039", "1-408-555-1959", "M", Convert.ToDateTime("1959-10-01 00:00:00.000"), "brender.alejandro@acme.com"));
            funcionarios.Add(new Funcionario(40, "Weiyi", "Meriste", "20100150040", "1-408-555-1959", "F", Convert.ToDateTime("1959-09-13 00:00:00.000"), "meriste.weiyi@acme.com"));
            funcionarios.Add(new Funcionario(41, "Uri", "Lenart", "20100150041", "1-408-555-1959", "F", Convert.ToDateTime("1959-08-27 00:00:00.000"), "lenart.uri@acme.com"));
            funcionarios.Add(new Funcionario(42, "Magy", "Stamatiou", "20100150042", "1-408-555-1956", "F", Convert.ToDateTime("1956-02-26 00:00:00.000"), "stamatiou.magy@acme.com"));
            funcionarios.Add(new Funcionario(43, "Yishay", "Tzvieli", "20100150043", "1-408-555-1960", "M", Convert.ToDateTime("1960-09-19 00:00:00.000"), "tzvieli.yishay@acme.com"));
            funcionarios.Add(new Funcionario(44, "Mingsen", "Casley", "20100150044", "1-408-555-1961", "F", Convert.ToDateTime("1961-09-21 00:00:00.000"), "casley.mingsen@acme.com"));
            funcionarios.Add(new Funcionario(45, "Moss", "Shanbhogue", "20100150045", "1-408-555-1957", "M", Convert.ToDateTime("1957-08-14 00:00:00.000"), "shanbhogue.moss@acme.com"));
            funcionarios.Add(new Funcionario(46, "Lucien", "Rosenbaum", "20100150046", "1-408-555-1960", "M", Convert.ToDateTime("1960-07-23 00:00:00.000"), "rosenbaum.lucien@acme.com"));
            funcionarios.Add(new Funcionario(47, "Zvonko", "Nyanchama", "20100150047", "1-408-555-1952", "M", Convert.ToDateTime("1952-06-29 00:00:00.000"), "nyanchama.zvonko@acme.com"));
            funcionarios.Add(new Funcionario(48, "Florian", "Syrotiuk", "20100150048", "1-408-555-1963", "M", Convert.ToDateTime("1963-07-11 00:00:00.000"), "syrotiuk.florian@acme.com"));
            funcionarios.Add(new Funcionario(49, "Basil", "Tramer", "20100150049", "1-408-555-1961", "F", Convert.ToDateTime("1961-04-24 00:00:00.000"), "tramer.basil@acme.com"));
            funcionarios.Add(new Funcionario(50, "Yinghua", "Dredge", "20100150050", "1-408-555-1958", "M", Convert.ToDateTime("1958-05-21 00:00:00.000"), "dredge.yinghua@acme.com"));
            funcionarios.Add(new Funcionario(51, "Hidefumi", "Caine", "20100150051", "1-408-555-1953", "M", Convert.ToDateTime("1953-07-28 00:00:00.000"), "caine.hidefumi@acme.com"));
            funcionarios.Add(new Funcionario(52, "Heping", "Nitsch", "20100150052", "1-408-555-1961", "M", Convert.ToDateTime("1961-02-26 00:00:00.000"), "nitsch.heping@acme.com"));
            funcionarios.Add(new Funcionario(53, "Sanjiv", "Zschoche", "20100150053", "1-408-555-1954", "F", Convert.ToDateTime("1954-09-13 00:00:00.000"), "zschoche.sanjiv@acme.com"));
            funcionarios.Add(new Funcionario(54, "Mayumi", "Schueller", "20100150054", "1-408-555-1957", "M", Convert.ToDateTime("1957-04-04 00:00:00.000"), "schueller.mayumi@acme.com"));
            funcionarios.Add(new Funcionario(55, "Georgy", "Dredge", "20100150055", "1-408-555-1956", "M", Convert.ToDateTime("1956-06-06 00:00:00.000"), "dredge.georgy@acme.com"));
            funcionarios.Add(new Funcionario(56, "Brendon", "Bernini", "20100150056", "1-408-555-1961", "F", Convert.ToDateTime("1961-09-01 00:00:00.000"), "bernini.brendon@acme.com"));
            funcionarios.Add(new Funcionario(57, "Ebbe", "Callaway", "20100150057", "1-408-555-1954", "F", Convert.ToDateTime("1954-05-30 00:00:00.000"), "callaway.ebbe@acme.com"));
            funcionarios.Add(new Funcionario(58, "Berhard", "McFarlin", "20100150058", "1-408-555-1954", "M", Convert.ToDateTime("1954-10-01 00:00:00.000"), "mcfarlin.berhard@acme.com"));
            funcionarios.Add(new Funcionario(59, "Alejandro", "McAlpine", "20100150059", "1-408-555-1953", "F", Convert.ToDateTime("1953-09-19 00:00:00.000"), "mcalpine.alejandro@acme.com"));
            funcionarios.Add(new Funcionario(60, "Breannda", "Billingsley", "20100150060", "1-408-555-1961", "M", Convert.ToDateTime("1961-10-15 00:00:00.000"), "billingsley.breannda@acme.com"));
            funcionarios.Add(new Funcionario(61, "Tse", "Herber", "20100150061", "1-408-555-1962", "M", Convert.ToDateTime("1962-10-19 00:00:00.000"), "herber.tse@acme.com"));
            funcionarios.Add(new Funcionario(62, "Anoosh", "Peyn", "20100150062", "1-408-555-1961", "M", Convert.ToDateTime("1961-11-02 00:00:00.000"), "peyn.anoosh@acme.com"));
            funcionarios.Add(new Funcionario(63, "Gino", "Leonhardt", "20100150063", "1-408-555-1952", "F", Convert.ToDateTime("1952-08-06 00:00:00.000"), "leonhardt.gino@acme.com"));
            funcionarios.Add(new Funcionario(64, "Udi", "Jansch", "20100150064", "1-408-555-1959", "M", Convert.ToDateTime("1959-04-07 00:00:00.000"), "jansch.udi@acme.com"));
            funcionarios.Add(new Funcionario(65, "Satosi", "Awdeh", "20100150065", "1-408-555-1963", "M", Convert.ToDateTime("1963-04-14 00:00:00.000"), "awdeh.satosi@acme.com"));
            funcionarios.Add(new Funcionario(66, "Kwee", "Schusler", "20100150066", "1-408-555-1952", "M", Convert.ToDateTime("1952-11-13 00:00:00.000"), "schusler.kwee@acme.com"));
            funcionarios.Add(new Funcionario(67, "Claudi", "Stavenow", "20100150067", "1-408-555-1953", "M", Convert.ToDateTime("1953-01-07 00:00:00.000"), "stavenow.claudi@acme.com"));
            funcionarios.Add(new Funcionario(68, "Charlene", "Brattka", "20100150068", "1-408-555-1962", "M", Convert.ToDateTime("1962-11-26 00:00:00.000"), "brattka.charlene@acme.com"));
            funcionarios.Add(new Funcionario(69, "Margareta", "Bierman", "20100150069", "1-408-555-1960", "F", Convert.ToDateTime("1960-09-06 00:00:00.000"), "bierman.margareta@acme.com"));
            funcionarios.Add(new Funcionario(70, "Reuven", "Garigliano", "20100150070", "1-408-555-1955", "M", Convert.ToDateTime("1955-08-20 00:00:00.000"), "garigliano.reuven@acme.com"));
            funcionarios.Add(new Funcionario(71, "Hisao", "Lipner", "20100150071", "1-408-555-1958", "M", Convert.ToDateTime("1958-01-21 00:00:00.000"), "lipner.hisao@acme.com"));
            funcionarios.Add(new Funcionario(72, "Hironoby", "Sidou", "20100150072", "1-408-555-1952", "F", Convert.ToDateTime("1952-05-15 00:00:00.000"), "sidou.hironoby@acme.com"));
            funcionarios.Add(new Funcionario(73, "Shir", "McClurg", "20100150073", "1-408-555-1954", "M", Convert.ToDateTime("1954-02-23 00:00:00.000"), "mcclurg.shir@acme.com"));
            funcionarios.Add(new Funcionario(74, "Mokhtar", "Bernatsky", "20100150074", "1-408-555-1955", "F", Convert.ToDateTime("1955-08-28 00:00:00.000"), "bernatsky.mokhtar@acme.com"));
            funcionarios.Add(new Funcionario(75, "Gao", "Dolinsky", "20100150075", "1-408-555-1960", "F", Convert.ToDateTime("1960-03-09 00:00:00.000"), "dolinsky.gao@acme.com"));
            funcionarios.Add(new Funcionario(76, "Erez", "Ritzmann", "20100150076", "1-408-555-1952", "F", Convert.ToDateTime("1952-06-13 00:00:00.000"), "ritzmann.erez@acme.com"));
            funcionarios.Add(new Funcionario(77, "Mona", "Azuma", "20100150077", "1-408-555-1964", "M", Convert.ToDateTime("1964-04-18 00:00:00.000"), "azuma.mona@acme.com"));
            funcionarios.Add(new Funcionario(78, "Danel", "Mondadori", "20100150078", "1-408-555-1959", "F", Convert.ToDateTime("1959-12-25 00:00:00.000"), "mondadori.danel@acme.com"));
            funcionarios.Add(new Funcionario(79, "Kshitij", "Gils", "20100150079", "1-408-555-1961", "F", Convert.ToDateTime("1961-10-05 00:00:00.000"), "gils.kshitij@acme.com"));
            funcionarios.Add(new Funcionario(80, "Premal", "Baek", "20100150080", "1-408-555-1957", "M", Convert.ToDateTime("1957-12-03 00:00:00.000"), "baek.premal@acme.com"));
            funcionarios.Add(new Funcionario(81, "Zhongwei", "Rosen", "20100150081", "1-408-555-1960", "M", Convert.ToDateTime("1960-12-17 00:00:00.000"), "rosen.zhongwei@acme.com"));
            funcionarios.Add(new Funcionario(82, "Parviz", "Lortz", "20100150082", "1-408-555-1963", "M", Convert.ToDateTime("1963-09-09 00:00:00.000"), "lortz.parviz@acme.com"));
            funcionarios.Add(new Funcionario(83, "Vishv", "Zockler", "20100150083", "1-408-555-1959", "M", Convert.ToDateTime("1959-07-23 00:00:00.000"), "zockler.vishv@acme.com"));
            funcionarios.Add(new Funcionario(84, "Tuval", "Kalloufi", "20100150084", "1-408-555-1960", "M", Convert.ToDateTime("1960-05-25 00:00:00.000"), "kalloufi.tuval@acme.com"));
            funcionarios.Add(new Funcionario(85, "Kenroku", "Malabarba", "20100150085", "1-408-555-1962", "M", Convert.ToDateTime("1962-11-07 00:00:00.000"), "malabarba.kenroku@acme.com"));
            funcionarios.Add(new Funcionario(86, "Somnath", "Foote", "20100150086", "1-408-555-1962", "M", Convert.ToDateTime("1962-11-19 00:00:00.000"), "foote.somnath@acme.com"));
            funcionarios.Add(new Funcionario(87, "Xinglin", "Eugenio", "20100150087", "1-408-555-1959", "F", Convert.ToDateTime("1959-07-23 00:00:00.000"), "eugenio.xinglin@acme.com"));
            funcionarios.Add(new Funcionario(88, "Jungsoon", "Syrzycki", "20100150088", "1-408-555-1954", "F", Convert.ToDateTime("1954-02-25 00:00:00.000"), "syrzycki.jungsoon@acme.com"));
            funcionarios.Add(new Funcionario(89, "Sudharsan", "Flasterstein", "20100150089", "1-408-555-1963", "F", Convert.ToDateTime("1963-03-21 00:00:00.000"), "flasterstein.sudharsan@acme.co"));
            funcionarios.Add(new Funcionario(90, "Kendra", "Hofting", "20100150090", "1-408-555-1961", "M", Convert.ToDateTime("1961-05-30 00:00:00.000"), "hofting.kendra@acme.com"));
            funcionarios.Add(new Funcionario(91, "Amabile", "Gomatam", "20100150091", "1-408-555-1955", "M", Convert.ToDateTime("1955-10-04 00:00:00.000"), "gomatam.amabile@acme.com"));
            funcionarios.Add(new Funcionario(92, "Valdiodio", "Niizuma", "20100150092", "1-408-555-1964", "F", Convert.ToDateTime("1964-10-18 00:00:00.000"), "niizuma.valdiodio@acme.com"));
            funcionarios.Add(new Funcionario(93, "Sailaja", "Desikan", "20100150093", "1-408-555-1964", "M", Convert.ToDateTime("1964-06-11 00:00:00.000"), "desikan.sailaja@acme.com"));
            funcionarios.Add(new Funcionario(94, "Arumugam", "Ossenbruggen", "20100150094", "1-408-555-1957", "F", Convert.ToDateTime("1957-05-25 00:00:00.000"), "ossenbruggen.arumugam@acme.com"));
            funcionarios.Add(new Funcionario(95, "Hilari", "Morton", "20100150095", "1-408-555-1965", "M", Convert.ToDateTime("1965-01-03 00:00:00.000"), "morton.hilari@acme.com"));
            funcionarios.Add(new Funcionario(96, "Jayson", "Mandell", "20100150096", "1-408-555-1954", "M", Convert.ToDateTime("1954-09-16 00:00:00.000"), "mandell.jayson@acme.com"));
            funcionarios.Add(new Funcionario(97, "Remzi", "Waschkowski", "20100150097", "1-408-555-1952", "M", Convert.ToDateTime("1952-02-27 00:00:00.000"), "waschkowski.remzi@acme.com"));
            funcionarios.Add(new Funcionario(98, "Sreekrishna", "Servieres", "20100150098", "1-408-555-1961", "F", Convert.ToDateTime("1961-09-23 00:00:00.000"), "servieres.sreekrishna@acme.com"));
            funcionarios.Add(new Funcionario(99, "Valter", "Sullins", "20100150099", "1-408-555-1956", "F", Convert.ToDateTime("1956-05-25 00:00:00.000"), "sullins.valter@acme.com"));
            funcionarios.Add(new Funcionario(100, "Hironobu", "Haraldson", "20100150100", "1-408-555-1953", "F", Convert.ToDateTime("1953-04-21 00:00:00.000"), "haraldson.hironobu@acme.com"));
        }
    }
}
