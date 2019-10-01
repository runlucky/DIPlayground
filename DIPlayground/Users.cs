using System;
using System.Collections.Generic;
using System.Text;
using MicroResolver;

namespace DIPlayground
{
    interface IUser
    {
        public string Name { get; }
    }

    class ConstructorUser : IUser
    {
        private ILogger logger;

        [Inject]
        public ConstructorUser(ILogger logger)
        {
            this.logger = logger;
        }

        public string Name => throw new NotImplementedException();
    }

    //class PropertyUser : IUser
    //{

    //}

    //class MethodUser:IUser
    //{

    //}

    //class FieldUser: IUser
    //{

    //}
}
