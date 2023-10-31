using SimpleCommerce.Domain.Models;

namespace SimpleCommerce.Domain.Exceptions
{
    public abstract class BaseException : Exception
    {
        protected BaseException(ExceptionConstantModel exceptionConstant) : base(exceptionConstant.Message)
        {
        }
    }
}
