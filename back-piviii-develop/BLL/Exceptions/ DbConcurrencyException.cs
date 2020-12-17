using System;

namespace back_piviii.BLL.Exceptions
{
    public class  DbConcurrencyException: ApplicationException
    {
        public DbConcurrencyException(string message) : base(message)
        {
        }
    }

}