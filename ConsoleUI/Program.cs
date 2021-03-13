using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManger = new BrandManager(new EfBrandDal());
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var carDetail in carManager.GetCarDetails())
            {
                Console.WriteLine(carDetail.Modelname + " " + carDetail.CarName + " " + carDetail.Color);

            }


            //ColorTest()
            // CarTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var color = new Color { Name = "858rtyr" };
            Console.WriteLine(color.Name);
            colorManager.Add(color);
        }

        private static void CarTest()
        {
            EfCarDal efCarDal = new EfCarDal();
            efCarDal.Add(new Car { 
            BrandId = 3,
            ColorId = 1,
            DailyPrice = 15,
            Description = "test",
            ModelYear = new DateTime(1999,5,5)
            });


            CarManager carManager = new CarManager(efCarDal);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);

            }
        }
    }
}
