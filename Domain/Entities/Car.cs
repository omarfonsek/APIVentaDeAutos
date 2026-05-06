using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIVentaDeAutos.Domain.Entities
{
    public class Car
    {
        public string Id { get; set; }
        public string LicensePlate { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public double Kilometers { get; set; }
        public string State { get; set; }

    }
}
