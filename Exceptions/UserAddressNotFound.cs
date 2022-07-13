using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewOrdersApi.Exceptions
{
    public class UserAddressNotFound : Exception
    {
        public UserAddressNotFound(string message) : base(message)
        {
        }

        

    }
}
