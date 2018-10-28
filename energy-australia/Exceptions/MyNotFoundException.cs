using System;

namespace energy_australia.Exceptions
{
    public class MyNotFoundException : Exception
    {

        public MyNotFoundException()
        {
        }

        public MyNotFoundException(string message)
            : base(message)
        {
        }

        public MyNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
