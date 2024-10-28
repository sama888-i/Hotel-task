using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.Exceptions
{
    public class NullReferanceExcepption:Exception 
    {
        public NullReferanceExcepption(string msg):base(msg)
        {
                
        }
        public NullReferanceExcepption()
        {
                
        }
    }
}
