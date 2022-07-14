using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck3_Refactoring
{
    internal class MyLogicClass
    {
        private readonly MyDataClass myDataClass;
        public MyLogicClass(MyDataClass dataClass)
        {
            myDataClass = dataClass;
        }

        public List<Vehicle> GetAllCarsAsVehicles()
        {
            // Change this to a linq Select
            var vehicles = new List<Vehicle>();
            foreach(var car in myDataClass.Get())
            {
                var v = new Vehicle
                {
                    Brand = car.BrandName,
                    Color = car.ColorName,
                    ENGINE = car.EngineType,
                    Model_name = car.ModelName
                };

                vehicles.Add(v);
            }

            return vehicles;
        }

        public List<Car> GetAllHybridCars()
        {
            // Change this to use a linq Where and ToList
            var cars = myDataClass.Get();
            var hybridCars = new List<Car>();

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].EngineType.ToLower() == "hybrid")
                {
                    hybridCars.Add(cars[i]);
                }
            }

            return hybridCars;
        }

        public int AddVehicle(Car car)
        {
            return myDataClass.GiveCar(car);
        }
    }
}
