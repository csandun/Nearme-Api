﻿using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationFinder.Api.Models
{
    public class Location
    {
        public string MarkId { get; set; }
        public GeoCoordinate Point { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }
        public string MobileNumber { get; set; }


    }
}
