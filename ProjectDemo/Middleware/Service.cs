using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo.Middleware
{
    public class Service : IService
    {
        public virtual string message()
        {
            return "Dependency injection";
        }
    }
}
