using System;
using Unity;
using UnityContainerDemo.Interfaces;

namespace UnityContainerDemo
{
    public class Driver
    {
        private ICar _car = null;
        private ICarKey _key = null;
        private string _name = string.Empty;

        
        public Driver(ICar car)
        {
            _car = car;
        }

        //[InjectionConstructor]
        //public Driver(ICar car, ICarKey key)
        //{
        //    _car = car;
        //    _key = key;
        //}

        //[InjectionConstructor]
        //public Driver(ICar car, string driverName)
        //{
        //    _car = car;
        //    _name = driverName;
        //}

        //public Driver(string name)
        //{

        //}

        public void RunCar()
        {
            //Console.WriteLine($"Running {_car.GetType().Name} with {_key.GetType().Name} - {_car.Run()} mile ");
            //Console.WriteLine($"{_name} is running {_car.GetType().Name} - {_car.Run()} mile ");
            Console.WriteLine($"Running - {_car.Run()} mile ");
        }
    }
}