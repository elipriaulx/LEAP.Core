using System;

namespace LEAP.Core.Exceptions
{
    public class LeapException : Exception
    {
        public LeapException()
        {

        }

        public LeapException(string message) : base(message)
        {

        }

        public LeapException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}