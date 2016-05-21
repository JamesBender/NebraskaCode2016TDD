using System;
using Common;
using Ninject.Modules;

namespace MyNinjectModules
{
    public class PropertyInjectionLoggingModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoggingSink>().To<DistributedLoggingSync>();
            Bind<EngineWithTwoLoggers>().ToSelf();
            
            Bind<IDomComponent>().To<OffLineLoggingComponent>();
            
            Bind<IDomComponent>().To<SpecialLoggingComponent>().WhenMemberHas<SpecialLogger>();

        }
    }
}