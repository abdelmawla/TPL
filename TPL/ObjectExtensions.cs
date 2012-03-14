using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPL
{
    public static class ObjectExtensions
    {
        public static Type GetType(this Object obj) {
            return typeof(int);
        }
    }
}
