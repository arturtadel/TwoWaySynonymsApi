using System;

namespace TwoWaySynonymsApi.Common.Exceptions
{
    public class BaseException : Exception
    {
        public BaseException(string exceptionCode) : base()
        {
            ExceptionCode = exceptionCode;
        }
        public BaseException(string exceptionCode, string message) : base(message)
        {
            ExceptionCode = exceptionCode;
        }

        public BaseException(string exceptionCode, string message, Exception innerException) : base(message,
            innerException)
        {
            ExceptionCode = exceptionCode;
        }

        public string ExceptionCode { get; private set; }
    }
}
