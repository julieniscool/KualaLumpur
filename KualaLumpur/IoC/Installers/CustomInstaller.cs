using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using KualaLumpur.Ability;

namespace KualaLumpur.IoC.Installers
{
    public class CustomInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(Component.For<IClickability>().ImplementedBy<CustomClickability>().LifestyleTransient().IsDefault());
        }
    }
}
