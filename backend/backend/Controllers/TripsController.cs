using backendAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace backendAPI.Controllers
{
    /// <summary>
    /// Controlador responsavel pelas requisições de viagens
    /// </summary>
    public class TripsController : ApiController
    {
        private static List<Trip> trips = new List<Trip>();

        /// <summary>
        /// Construtor: usado para carregar as configurações iniciais da classe
        /// </summary>
        public TripsController()
        {
            this.fakeData();
        }

        /// <summary>
        /// Este metodo e responsavel por retornar a lista completa dos dados relacionados à viagens armazenada.
        /// /api/Trip
        /// </summary>
        public List<Trip> Get() => trips;

        /// <summary>
        /// Este metodo e responsavel por retornar uma lista de dados relacionados a 
        /// um Identificador(ID) da cidade especifico passado por parametro, 
        /// o metodo retorna uma Lista de dados relacionados com o ID passado.
        /// /api/Trip?trip_city=132
        /// </summary>
        public List<Trip> Get(int trip_city, string trip_date) => trips.Where(x => (x.trip_city == trip_city) && DateTime.Parse(x.trip_date)  >= DateTime.Parse(trip_date) ).ToList();


        /// <summary>
        /// Este metodo e responsavel por gerar uma lista previa dos dados de Viagens para que a API seja testada
        /// </summary>
        private void fakeData()
        {
            if (trips.Count == 0)
            {
                trips.Add(new Trip(130, 1, "https://www.guiadasemana.com.br/contentFiles/image/2018/01/FEA/galeria/56263_w840h525_1515073001chile.jpg",
                "Patagônia Chilena", "O Chile é um país incrível, que possui diversas paisagens de tirar o fôlego (lagos, vulcões e geleiras estão entre os destaques). No inverno não é diferente: seus roteiros ficam ainda melhores, o que possibilita que o viajante realize atividades típicas do frio e conheça lugares ainda mais bonitos com a neve. Para queles que procuram encontrar temperaturas mais amenas e ver a neve, a dica é viajar entre os meses de junho e setembro, quando as temperaturas variam entre 10ºC e 5ºC.", "€", 4, "2019/03/15", 1, 2, 100));

                trips.Add(new Trip(132, 2, "https://thumbcdn-0.hotelurbano.net/tAGbO879mRHyqECMmWuSdO4L33U=/fit-in/x562/filters:strip_icc():max_bytes(102400)/http%3A//s3.amazonaws.com/legado-prod/prod/ofertas/imagens/2018/04/12/09/15/dubai_001__64_.jpg",
                "Gran Stella Maris Resort Convention", "Dubai é a maior cidade dos Emirados Árabes Unidos, Tudo é majestoso, Sua localização é estratégica, É um dos principais destinos turísticos dos últimos 10 anos, Terá o maior aeroporto do mundo, O verão é bem quente, E chove pouco durante todo o ano, O clima de Dubai é bem quente e procurado por viajantes fora do período de verão. Se as altas temperaturas não te incomodam, não há restrições de temporada para você.", 
                "€", 5, "2019/04/05", 1, 2, 200));

                trips.Add(new Trip(133, 3, "https://www.fuiviagens.com.br/fui-viagens/objects/images/2017-06/10202.jpg",
                "Cartagena", "Cartagena das Índias, na Colômbia, é um daqueles destinos que a gente ama visitar: cidade histórica que mescla lugares charmosos com um destino de praia incrível. E não é qualquer praia não: estamos falando de um mar do Caribe, com água cor turquesa e cristalina, formando um azul sem igual. Rodeado por areias branquinhas, a cidade possui boas opções de passeios, que variam desde conhecer praias próximas a desvendar os segredos e histórias da cidade.", "€", 5, "2019/04/05", 1, 2, 300));

                trips.Add(new Trip(132, 4, "https://nit.pt/wp-content/uploads/2018/04/64b40dcbed5c920035b4ec2f9bf535c3.jpg",
                 "Burj Khalifa", "Dubai é a maior cidade e emirado de mesmo nome dos Emirados Árabes Unidos. O Emirado de Dubai está localizado na costa do Golfo Pérsico, sendo um dos sete emirados que compõem o país. Dubai é o emirado mais populoso entre os sete emirados, com aproximadamente 2 262 000 habitantes.", 
                 "€", 4.5, "2019/02/14", 1, 1, 800));

                trips.Add(new Trip(131, 5, "https://lh6.googleusercontent.com/-PrXDPkSldrE/WT2TBBrXLuI/AAAAAAAAAKU/_WYPEHZOi8ckqZi8dDdRSrCeI6FpZ1x9ACLIBGAYYCw/w360-h238-k-no/",
                "Rio de Janeiro", "O Rio de Janeiro é uma grande cidade brasileira à beira-mar, famosa pelas praias de Copacabana e Ipanema, pela estátua de 38 metros de altura do Cristo Redentor, no topo do Corcovado, e pelo Pão de Açúcar, um pico de granito com teleféricos até seu cume. A cidade também é conhecida pelas grandes favelas. O empolgante Carnaval, com carros alegóricos", "€", 3, "2019/01/02", 1, 1, 500));

                trips.Add(new Trip(130, 6, "https://www.almadeviajante.com/wp-content/uploads/torres-del-paine-chile.jpg",
                "Cordilheira dos Andes", "Com uma forma esguia ao longo da costa oeste da América do Sul, banhada pelo Oceano Pacífico, o Chile é um país com paisagens extremas e diversificadas. Do seco e inóspito Deserto de Atacama, no Norte do país, a Puerto Natales, Punta Arenas e toda a Patagónia chilena – incluindo os famosos cruzeiros pelos fiordes da região -, a Sul, passando pela cosmopolita Santiago do Chile, a capital, pela cordilheira dos Andes ou pela misteriosa ilha de Páscoa, as viagens ao Chile nada têm de monótono.", "€", 3, "2019/08/08", 3, 1, 200));
            }
        }

    }
}
