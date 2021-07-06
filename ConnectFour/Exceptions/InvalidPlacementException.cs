using System;

namespace ConnectFour.Exceptions
{
    public class InvalidPlacementException : Exception
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
