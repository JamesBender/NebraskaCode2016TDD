using Common;
using Ninject.Modules;

namespace MyNinjectModules
{
    public class SimpleLoggingModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoggingSink>().To<DistributedLoggingSync>();
            Bind<IDomComponent>().To<Logger>();
            Bind<SimpleBusinessEngine>().ToSelf();
        }
    }    
}
