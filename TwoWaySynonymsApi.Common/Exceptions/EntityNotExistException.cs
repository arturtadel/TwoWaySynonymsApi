using System;

namespace TwoWaySynonymsApi.Common.Exceptions
{
    public class EntityNotExistException : BaseException
    {
        public EntityNotExistException(string exceptionCode) : base(exceptionCode)
        {
        }

        public EntityNotExistException(string exceptionCode, string message) : base(exceptionCode, message)
        {
        }

        public EntityNotExistException(string exceptionCode, string message, Exception innerException) : base(exceptionCode, message, innerException)
        {
        }
    }
}
