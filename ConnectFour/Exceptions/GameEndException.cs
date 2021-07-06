using System;

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
