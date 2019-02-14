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
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CityController : ApiController
    {
        //[HttpGet]
        //public List<City> getCity()
        //{
        //    return cities;
        //}

        // OR

        Random rnd = new Random();
        private static List<City> cities = new List<City>();

        public CityController()
        {
            this.fakeData();
        }
        private void fakeData()
        {
            if (cities.Count == 0)
            {
                cities.Add(new City(130, "Lavras"));
                cities.Add(new City(131, "São Paulo"));
                cities.Add(new City(132, "Dubai"));
                cities.Add(new City(133, "Rio de Janeiro"));
            }
        }

        // api/City
        public List<City> Get() => cities;

        //// GET api/City/1
        public City Get(int id) => cities.SingleOrDefault(c => c.city_id == id);
   

        //criar o post com o form
        public void Post(string city_name)
        {
            int city_id = rnd.Next(999);// gerando fake id random(porque está sem BD)
            if (!string.IsNullOrEmpty(city_name))
            {
                cities.Add(new City(city_id,city_name));
            }
        }
    }
}
