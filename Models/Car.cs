using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Closing.Models
{
    public class Car
    {
        public Car()
        {
            ProductionDate = DateTime.Now;
        }
        public DateTime ProductionDate { get; set; }
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DoorCount { get; set; }
    }
}
