using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public class Cars
    {
        public static int countCicle { get; set; }
        public int NumberCar { get; set; }
        public string GoDriving()
        {
            return $"мы едем на {countCicle} колесах";
        }
        public int ReturnCountCicle()
        {
            return countCicle;
        }
        public override string ToString()
        {
            return $"Номер машины {NumberCar}, у которой {ReturnCountCicle()} колеса";
        }
    }


  

 
}
