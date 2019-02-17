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
    public class CityController : ApiController
    {
        Random rnd = new Random(); // Importação utilizada para a geração de numeros randons
        private static List<City> cities = new List<City>();

        /// <summary>
        /// Construtor: usado para carregar as configurações iniciais da classe
        /// </summary>
        public CityController()
        {
            this.fakeData();
        }

        /// <summary>
        /// Este metodo e responsavel por gerar uma lista previa dos dados de Cidades para que a API seja testada
        /// </summary>
        private void fakeData()
        {
            if (cities.Count == 0)
            {
                cities.Add(new City(130, "Chile"));
                cities.Add(new City(131, "Brazil"));
                cities.Add(new City(132, "Dubai"));
                cities.Add(new City(133, "Colômbia"));
            }
        }

        /// <summary>
        /// Este metodo e responsavel por retornar a lista completa dos dados relacionados à cidades armazenada.
        /// api/City
        /// </summary>
        public List<City> Get() => cities;

        /// <summary>
        /// Este metodo e responsavel por retornar uma lista de dados relacionados a 
        /// um Identificador(ID) da cidade especifico passado por parametro
        /// GET api/City/1
        /// </summary>
        public City Get(int id) => cities.SingleOrDefault(c => c.city_id == id);


        /// <summary>
        /// Este metodo e responsavel por cadastrar uma cidade via POST, através da URL
        /// </summary>
        public void Post(string city_name)
        {
            int city_id = rnd.Next(999);// gerando id random falso, pois está sem Banco de dados(BD) (Deve ser criado pelo BD)
            if (!string.IsNullOrEmpty(city_name))
            {
                cities.Add(new City(city_id, city_name));
            }
        }
    }
}
