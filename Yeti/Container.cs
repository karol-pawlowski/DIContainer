using System;
using System.Collections;
using System.Collections.Generic;

namespace Yeti
{
    public class Container
    {
        readonly IDictionary<Type, Type> _registrations = new Dictionary<Type, Type>();
        public void Register<TRegistration, TImplementation>()
        {
            _registrations.Add(typeof(TRegistration), typeof(TImplementation));
        }

        public T Resolve<T>()
        {
            Type requestedToResolve = typeof(T);
            Type type = _registrations[requestedToResolve];

            return (T)Activator.CreateInstance(type);
        }
    }
}
