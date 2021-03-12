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
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var color = new Color { Name = "red" };
            Console.WriteLine(color.Name);
           colorManager.Add(color);


            // InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            EfCarDal efCarDal = new EfCarDal();
            CarManager carManager = new CarManager(efCarDal);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);

            }
        }
    }
}
