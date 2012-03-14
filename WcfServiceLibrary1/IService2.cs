using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCFProject
{
    [ServiceContract]
    public interface IService2 : IService1
    {
        [OperationContract]
        string GetData2(int value);
    }
}
