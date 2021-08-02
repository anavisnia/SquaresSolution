using System;

namespace SquaresSolution.Domain.Exceptions
{
    public class CustomValidationException : Exception
    {
        public CustomValidationException(string message) : base(message)
        {

        }
    }
}
