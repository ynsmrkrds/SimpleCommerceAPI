using SimpleCommerce.Domain.Models;

namespace SimpleCommerce.Domain.Exceptions
{
    public class ClientSideException : BaseException
    {
        public ClientSideException(ExceptionConstantModel exceptionConstant) : base(exceptionConstant)
        {
        }
    }
}
