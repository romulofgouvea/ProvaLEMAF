using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backendAPI.Models
{
    /// <summary>
    /// Classe responsavel por abstrair caracteristicas relacionadas ao objeto City(cidade)
    /// </summary>
    public class City
    {
        public int city_id { get; set; }
        public string city_name { get; set; }

        /// <summary>
        /// Construtor responsável por objetos do tipo City contento os parametros id e name.
        /// </summary>
        ///<param name="id">Identificador unico de cada cidade</param>
        ///<param name="name">Nome referente a cada cidade</param>
        public City(int id, string name)
        {
            this.city_id = id;
            this.city_name = name;
        }
    }
}