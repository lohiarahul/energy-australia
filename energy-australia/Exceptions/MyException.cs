using System;

namespace energy_australia.Exceptions
{
    public class MyException : Exception
    {
        public MyException(string message)
     : base(message)
        {
        }

        public MyException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
