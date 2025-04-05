using System;

namespace MyOperations
{
    public class MyCustomException : Exception
    {
        public int ErrorCode { get; set; }

        public MyCustomException(int errorCode, string message)
            : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
