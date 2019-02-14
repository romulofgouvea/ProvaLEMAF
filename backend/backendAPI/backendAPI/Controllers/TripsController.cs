using backendAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace backendAPI.Controllers
{
    public class TripsController : ApiController
    {
        private static List<Trip> trips = new List<Trip>();

        public TripsController()
        {
            this.fakeData();
        }

        public List<Trip> Get() => trips;

        public List<Trip> Get(int trip_city) => trips.Where(x => x.trip_city == trip_city).ToList();

        private void fakeData()
        {
            if (trips.Count == 0)
            {
                trips.Add(new Trip(130, 1, "http://www.smartrisair.com.br/public/assets/node_modules/semantic-ui/examples/assets/images/wireframe/image.png",
                "Local 1", "Desc Local 1", "€", 4, "02/14/2019", 1, 1, 100));

                trips.Add(new Trip(132, 2, "http://www.smartrisair.com.br/public/assets/node_modules/semantic-ui/examples/assets/images/wireframe/image.png",
                "Local 2", "Desc Local 2", "€", 5, "02/14/2019", 1, 1, 800));

                trips.Add(new Trip(132, 3, "http://www.smartrisair.com.br/public/assets/node_modules/semantic-ui/examples/assets/images/wireframe/image.png",
                 "Local 3", "Desc Local 3", "€", 4.5, "02/14/2019", 1, 1, 400));

                trips.Add(new Trip(131, 4, "http://www.smartrisair.com.br/public/assets/node_modules/semantic-ui/examples/assets/images/wireframe/image.png",
                "Local 4", "Desc Local 4", "€", 3, "02/14/2019", 1, 1, 200));

                trips.Add(new Trip(130, 5, "http://www.smartrisair.com.br/public/assets/node_modules/semantic-ui/examples/assets/images/wireframe/image.png",
                "Local 5", "Desc Local 5", "€", 3, "02/14/2019", 3, 1, 1800));
            }
        }

        }
}
