namespace SimpleCommerce.Domain.Models
{
    public class ResponseConstantModel : BaseConstantModel
    {
        public ResponseConstantModel(bool isSuccessful, string message) : base(isSuccessful, message)
        {
        }
    }
}
