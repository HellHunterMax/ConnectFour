using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.Exceptions
{
    public class GameEndException : Exception
    {
        public GameEndException()
        {
        }

        public GameEndException(string message) : base(message)
        {
        }

        public GameEndException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
