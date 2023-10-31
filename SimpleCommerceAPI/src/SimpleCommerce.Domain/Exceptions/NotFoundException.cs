using SimpleCommerce.Domain.Models;

namespace SimpleCommerce.Domain.Exceptions
{
    public class NotFoundException : BaseException
    {
        public NotFoundException(ExceptionConstantModel exceptionConstant) : base(exceptionConstant)
        {
        }
    }
}
