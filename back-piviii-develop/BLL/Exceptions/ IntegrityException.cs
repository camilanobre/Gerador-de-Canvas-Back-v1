using System;

namespace back_piviii.BLL.Exceptions
{
    public class  IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }

}