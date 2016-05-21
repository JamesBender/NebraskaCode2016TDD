using System;
using Common;
using Ninject.Modules;

namespace MyNinjectModules
{
    public class CtorAndMethodModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoggingSink>().ToMethod(x => GetLogger());
            Bind<IDomComponent>().ToConstructor(x => new CtorAndMethodComponent("Build with Ninject"));

        }

        private ILoggingSink GetLogger()
        {
            return new DistributedLoggingSync();
        }
    }        
}