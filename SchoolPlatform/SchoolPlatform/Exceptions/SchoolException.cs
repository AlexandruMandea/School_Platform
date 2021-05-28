using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPlatform.Exceptions
{
    class SchoolException : ApplicationException
    {
        public SchoolException(string message)
            : base(message)
        {

        }
    }
}
