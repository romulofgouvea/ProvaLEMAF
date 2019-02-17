using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backendAPI.Models
{
    /// <summary>
    /// Classe responsavel por abstrair caracteristicas relacionadas a uma viagem
    /// </summary>
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

        /// <summary>
        /// Construtor Trip contém os seguintes parametros para a definição do objeto viagem
        /// </summary>
        /// <param name="id_city"> Identificador da cidade relacionado a viagem </param>
        /// <param name="id"> Identificador unico da viagem  </param>
        /// <param name="url_img"> URL apontando diretamente para uma imagem sendo no servidor ou externa </param>
        /// <param name="name"> nome da viagem </param>
        /// <param name="desc"> Descrição da viagem </param>
        /// <param name="coin"> tipo de moeda que está sendo oferecida a viagem </param>
        /// <param name="rate"> avaliações relacionadas a viagem </param>
        /// <param name="date">  data da viagem </param>
        /// <param name="typeClass"> Tipo de classe que é oferecida na viagem </param>
        /// <param name="guest">  quantidade de pessoas que é oferecido na viagem </param>
        /// <param name="cost"> custo da viagem </param>
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