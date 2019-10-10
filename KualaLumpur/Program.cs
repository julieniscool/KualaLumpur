using Castle.Facilities.TypedFactory;
using Castle.Windsor;
using Castle.Windsor.Installer;
using KualaLumpur.ElementUI;
using System;
using System.Reflection;

namespace KualaLumpur
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = ConfigureIoC();
            var button = factory.Create<IButton>("//input[@name='submit']");
            button.DoubleClick();
            button.Click();
            Console.ReadLine();
        }

        static IComponentResolver ConfigureIoC()
        {
            var container = new WindsorContainer();
            container.Kernel.AddFacility<TypedFactoryFacility>();
            container.Install(FromAssembly.Instance(Assembly.GetExecutingAssembly()));
            return container.Resolve<IComponentResolver>();
        }
    }
}
