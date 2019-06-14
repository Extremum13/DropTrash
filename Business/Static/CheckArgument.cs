using System;

namespace Business.Static
{
    public static class CheckArgument
    {
        public static void CheckForNull(object argument, string message)
        {
            if (argument == null)
                throw new ArgumentNullException(message);
        }
    }
}