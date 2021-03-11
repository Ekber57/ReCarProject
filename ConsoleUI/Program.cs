using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            CarManager carManager = new CarManager(inMemoryCarDal);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0}   -  {1}",car.BrandId,car.Description);
            }
        }
    }
}
