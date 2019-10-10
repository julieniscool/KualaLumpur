using Castle.Core;
using Castle.DynamicProxy;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using KualaLumpur.Ability;
using KualaLumpur.ElementUI;
using Trinity.IoC.Interceptor;

namespace KualaLumpur.IoC.Installers
{
    public class ComponentsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IInterceptor>().ImplementedBy<DefaultInterceptor>());

            container.Register(Component.For<IButton>().ImplementedBy<Button>().LifestyleTransient());
            container.Register(Component.For<IReadAbility>().ImplementedBy<Readability>().LifestyleTransient());
            container.Register(Component.For<IExistability>().ImplementedBy<Existability>().LifestyleTransient());

            container.Register(Component.For<IClickability>().ImplementedBy<Clickability>().LifestyleTransient()
                .Interceptors(InterceptorReference.ForType<DefaultInterceptor>()).Last
                );
            
        }
    }
}
