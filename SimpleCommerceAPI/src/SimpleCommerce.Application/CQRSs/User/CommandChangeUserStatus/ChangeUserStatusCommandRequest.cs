using MediatR;

namespace SimpleCommerce.Application.CQRSs.User.CommandChangeUserStatus
{
    public class ChangeUserStatusCommandRequest : IRequest<ChangeUserStatusCommandResponse>
    {
        public string UserId { get; set; }

        public bool IsActive { get; set; }

        public ChangeUserStatusCommandRequest(string userId, bool isActive)
        {
            UserId = userId;
            IsActive = isActive;
        }
    }
}
