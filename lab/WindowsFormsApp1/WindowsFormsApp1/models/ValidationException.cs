using System;

namespace model.validator
{
    [Serializable]
    public class ValidationException : ArgumentException
    {
        public ValidationException(String message) : base(message)
        {
            
        }
    }
}