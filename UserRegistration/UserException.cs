using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    class UserException:Exception
    {
        public UserException()
        {

        }
        public UserException(string message)
        : base(message)
        {
        }
    }
}
