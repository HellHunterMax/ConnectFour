using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.Exceptions
{
    class InvalidPlacementException : Exception
    {
        public InvalidPlacementException()
        {
        }

        public InvalidPlacementException(string message) : base(message)
        {
        }

        public InvalidPlacementException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
