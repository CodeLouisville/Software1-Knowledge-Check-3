using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck3_Refactoring
{
    internal class MyDataClass
    {
        private readonly List<Car> cars;

        public MyDataClass()
        {
            cars = new List<Car>
            {
                new Car
                {
                    BrandName = "Ford",
                    ColorName = "Blue",
                    EngineType = "Hybrid",
                    ModelName = "Fusion"
                },
                new Car
                {
                    BrandName = "Ford",
                    ColorName = "Red",
                    EngineType = "Inline 4",
                    ModelName = "Focus"
                }
            };
        }

        public List<Car> Get()
        {
            return cars;
        }

        public int GiveCar(Car car)
        {
            cars.Add(car);
            return cars.Count;
        }
    }
}
