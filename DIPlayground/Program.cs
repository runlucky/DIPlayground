using System;
using System.Diagnostics;
using MicroResolver;

namespace DIPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            var resolver = ObjectResolver.Create();

            resolver.Register<ILogger, Logger>();
            resolver.Register<IUser, ConstructorUser>();

            resolver.Compile();

            var user = resolver.Resolve<IUser>();
            Debug.WriteLine(user.GetName());
        }
    }
}
