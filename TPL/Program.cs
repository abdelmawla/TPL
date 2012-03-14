using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace TPL
{
    class Program
    {

        static void Main(string[] args)
        {
            Object x = 6.5;
            var y = x.GetType().Name;
            Console.WriteLine(y);
        }
    }
}
