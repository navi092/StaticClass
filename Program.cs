using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars.countCicle = 4;
            Cars[] cars = new Cars[4];
            for (int i = 0; i < 4; i++)
            {
                cars[i] = new Cars() { NumberCar = i };
            }
            // для каждого экземпляра Cars существует только один обьект класса countCicle и он один для всех одинаковый
            foreach (Cars item in cars)
            {
                Console.WriteLine(item.ToString());
            }

            // Есть класс Human он статический, т е челокек может быть только один! 
            // Представим, что у человека есть собственный автопарк. 

            Human.Cars = cars;
            for (int i = 0; i < Human.Cars.Count(); i++)
            {
                Console.WriteLine("Human. " + Human.Cars[i].ToString());
            }

            Console.ReadKey();
        }
    }
}
