using Farm.Dto;
using Farm.Models;

namespace Farm
{
    public interface IUserRepository
    {
        UserDTO GetUser(User userModel);
    }
}
