using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeChallenge1.Models
{
    public class Vehicle
    {
        public Driver driver { get; set; }
        public Sensor sensor { get; set; }
        public double speed { get; set; }
        public double latt { get; set; }
        public double longt { get; set; }
    }
}