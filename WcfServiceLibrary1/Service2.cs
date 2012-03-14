using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service2 : IService2
    {
        public string GetData2(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Abdo GetData1(int value)
        {
            return new Abdo { Name = value.ToString() };
        }
    }
}
