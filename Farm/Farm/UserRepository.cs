using Farm.Dto;
using Farm.Models;

namespace Farm
{
    public class UserRepository : IUserRepository
    {
        private readonly List<UserDTO> users = new List<UserDTO>();
        public UserRepository()
        {

            users.Add(new UserDTO { Email = "rodpaddock@gmail.com", Password = "rod123", Role = "admin" });
            users.Add(new UserDTO { Email = "rexwills@hotmail.com", Password = "rex321", Role = "anon" });
            users.Add(new UserDTO { Email = "second@gmail.com", Password = "pad", Role = "anon" });

        }

        public UserDTO GetUser(User userModel)
        {
            return users.Where(x => x.Email.ToLower() == userModel.Email.ToLower()
               && x.Password == userModel.Password).FirstOrDefault();
        }
    }
}
