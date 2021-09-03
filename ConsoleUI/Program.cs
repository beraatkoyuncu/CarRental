using Business.Conrerte;
using DataAccess.Conrerte.EntityFramework;
using DataAccess.Conrerte.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }

        }
    }
}
