using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.Exceptions
{
    public class NotAvialableException:Exception 
    {
        public NotAvialableException()
        {
                
        }
        public NotAvialableException(string message):base(message)
        {
                
        }

    }
}
