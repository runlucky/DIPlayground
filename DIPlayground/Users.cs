using System;
using System.Collections.Generic;
using System.Text;
using MicroResolver;

namespace DIPlayground
{
    interface IUser
    {
        string GetName();
    }

    class ConstructorUser : IUser
    {
        private ILogger logger;

        [Inject]
        public ConstructorUser(ILogger logger)
        {
            this.logger = logger;
        }

        public string GetName()
        {
            logger.Log("Constructor");
            return "Constructror";
        }
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
