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
        private readonly ILogger _logger;

        [Inject]
        public ConstructorUser(ILogger logger) => _logger = logger;

        public string GetName()
        {
            _logger.Log("Constructor User");
            return "Constructor User";
        }
    }

    class PropertyUser : IUser
    {
        [Inject]
        public ILogger Logger { private get; set; }
        public string GetName()
        {
            Logger.Log("Property User");
            return "Property User";
        }
    }

    class MethodUser : IUser
    {
        private ILogger _logger;

        [Inject]
        public void SetLogger(ILogger logger) => _logger = logger;
        public string GetName()
        {
            _logger.Log("Method User");
            return "Method User";
        }
    }

    class PublicFieldUser : IUser
    {
        [Inject]
        public ILogger Logger;
        public string GetName()
        {
            Logger.Log("Public Field User");
            return "Public Field User";
        }
    }

    class PrivateFieldUser : IUser
    {
        [Inject]
        private ILogger _logger;
        public string GetName()
        {
            _logger.Log("Private Field User");
            return "Private Field User";
        }
    }
}
