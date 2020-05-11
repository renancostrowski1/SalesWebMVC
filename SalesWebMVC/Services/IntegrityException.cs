using System;

namespace SalesWebMVC.Services
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(String message) : base(message)
        {

        }
    }
}
