using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backendAPI.Models
{
    public class Trip
    {
        public int trip_city { get; set; }
        public int trip_id { get; set; }
        public string trip_url_image { get; set; }
        public string trip_name { get; set; }
        public string trip_desc { get; set; }
        public string trip_coin { get; set; }
        public double trip_rate { get; set; }
        public string trip_date { get; set; }
        public int trip_class { get; set; }
        public int trip_guest { get; set; }
        public int trip_cost { get; set; }

        public Trip(int id_city, int id, string url_img, string name,
            string desc, string coin, double rate, string date, int typeClass, int guest, int cost)
        {
            this.trip_city = id_city;
            this.trip_id = id;
            this.trip_url_image = url_img;
            this.trip_name = name;
            this.trip_desc = desc;
            this.trip_coin = coin;
            this.trip_rate = rate;
            this.trip_date = date;
            this.trip_class = typeClass;
            this.trip_guest = guest;
            this.trip_cost = cost;
        }
    }
}