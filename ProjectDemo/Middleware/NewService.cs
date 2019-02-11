using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo.Middleware
{
    public class NewService : Service
    {
        public NewService() : base()
        {

        }
        public override string message()
        {
            String message = base.message();
            message += " - My new Method";
            return message;
        }
    }
}
