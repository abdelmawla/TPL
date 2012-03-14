using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace TPL.WCF
{
    public class ServiceHost<T>: ServiceHost
    {
        public ServiceHost() : base(typeof(T))
        { }

        public ServiceHost(params string[] baseAddresses)
            : base(typeof(T), baseAddresses.Select(address => new Uri(address)).ToArray()) 
        { }
    }
}
