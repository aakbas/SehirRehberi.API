using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public int CityId { get; set; }

        public float Transportation { get; set; }

        public float Food { get; set; }

        public float View { get; set; }

        public float Pricing { get; set; }

        
    }
}
