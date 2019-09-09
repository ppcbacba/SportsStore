using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type ServiceType)
        {
            return kernel.TryGet(ServiceType);
        }

        public IEnumerable<object> GetServices(Type ServiceType)
        {
            return kernel.GetAll(ServiceType);
        }

        private void AddBindings()
        {

        }
    }
    
}