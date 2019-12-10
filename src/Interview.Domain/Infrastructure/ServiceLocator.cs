using System;
using System.Collections.Generic;

namespace Interview.Domain.Infrastructure
{
    public class ServiceLocator
    {
        private static Dictionary<Type, object> _services;

        public ServiceLocator()
        {
            _services = new Dictionary<Type, object>
            {
                {typeof(Logger), new Logger()}
            };
        }

        public static T LocateService<T>() where T : class
        {
            return _services[typeof(T)] as T;
        }
    }
}
