using System;
using System.Web.Http.Dependencies;
using Ninject;
using Ninject.Syntax;

namespace Redakcija.Web.App_Start
{
    public class NinjectDependencyScope : IDependencyScope
    {
        IResolutionRoot m_Resolver;

        public NinjectDependencyScope(IResolutionRoot resolver)
        {
            this.m_Resolver = resolver;
        }

        public object GetService(Type serviceType)
        {
            if (m_Resolver == null)
                throw new ObjectDisposedException("this", "This scope has been disposed");

            return m_Resolver.TryGet(serviceType);
        }

        public System.Collections.Generic.IEnumerable<object> GetServices(Type serviceType)
        {
            if (m_Resolver == null)
                throw new ObjectDisposedException("this", "This scope has been disposed");

            return m_Resolver.GetAll(serviceType);
        }

        public void Dispose()
        {
            IDisposable disposable = m_Resolver as IDisposable;
            if (disposable != null)
                disposable.Dispose();

            m_Resolver = null;
        } 
    }

    public class NinjectDependencyResolver : NinjectDependencyScope, IDependencyResolver
    {
        IKernel kernel;

        public NinjectDependencyResolver(IKernel kernel)
            : base(kernel)
        {
            this.kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectDependencyScope(kernel.BeginBlock());
        }
    }
}