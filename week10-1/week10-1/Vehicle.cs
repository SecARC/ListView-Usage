using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week10_1
{
    public class Vehicle
    {
        public string Car { get; set; }
        public double MPG { get; set; }
        public int Cylinders { get; set; }
        public double Displacement { get; set; }
        public int Horsepower { get; set; }
        public int Weight { get; set; }
        public double Acceleration { get; set; }
        public int Model { get; set; }
        public string Origin { get; set; }
        public string Brand { get; set; }

        public Vehicle(string line)
        {
            string[] arr = line.Split(',');
            if(arr.Length == 10)
            {
                Car = Convert.ToString(arr[0]);
                MPG = Convert.ToDouble(arr[1]);
                Cylinders = Convert.ToInt32(arr[2]);
                Displacement = Convert.ToDouble(arr[3]);
                Horsepower = Convert.ToInt32(arr[4]);
                Weight = Convert.ToInt32(arr[5]);
                Acceleration = Convert.ToDouble(arr[6]);
                Model = Convert.ToInt32(arr[7]);
                Origin = Convert.ToString(arr[8]);
                Brand = Convert.ToString(arr[9]);

            }
            else
            {
                throw new FormatException("Line does not contains all car information");
            }
        }
    }
}
