using System;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using UnityContainerDemo.Interfaces;
using UnityContainerDemo.ManufacturerKeys;
using UnityContainerDemo.Manufacturers;

namespace UnityContainerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer()
                .RegisterType<ICar, BMW>(new HierarchicalLifetimeManager());

            var childContainer = container.CreateChildContainer();

            //container.RegisterType<ICar, BMW>();
            //container.RegisterType<ICarKey, BMWKey>();
            //container.RegisterType<ICar, Audi>("LuxuryCar");
            //container.RegisterType<ICar, Ford>();
            //container.RegisterType<Driver>(new InjectionConstructor(container.Resolve<ICar>()));

            //container.RegisterType<Driver>(new InjectionConstructor(new object[] {new Audi(), "Steve"}));

            //ICar bmw = container.Resolve<ICar>();
            //ICar audi = new Audi();
            //container.RegisterInstance<ICar>(audi);

            //container.RegisterType<Driver>("LuxuryCarDriver", 
            //     new InjectionConstructor(container.Resolve<ICar>("LuxuryCar")));


            //Driver driver = container.Resolve<Driver>();
            //driver.RunCar();

            //Driver drv = container.Resolve<Driver>();
            //drv.RunCar();

            Driver driver1 = container.Resolve<Driver>();
            driver1.RunCar();
            
            Driver driver2 = container.Resolve<Driver>();
            driver2.RunCar();

            Driver driver3 = childContainer.Resolve<Driver>();
            driver3.RunCar();
            
            Driver driver4 = childContainer.Resolve<Driver>();
            driver4.RunCar();

        }
    }
}
