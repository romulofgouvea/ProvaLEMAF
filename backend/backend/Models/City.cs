using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backendAPI.Models
{
    public class City
    {
        public int city_id { get; set; }
        public string city_name { get; set; }

        public City(int id, string name)
        {
            this.city_id = id;
            this.city_name = name;
        }
    }
}