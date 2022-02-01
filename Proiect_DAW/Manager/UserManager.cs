using System;
namespace Proiect_DAW.Manager
{
    public class UserManager
    {
        private readonly UserRepository _userRepository;

        public Boolean Login(String password, String username)
        {
            // find user
            var user = _userRepository.GetUserByPasswordAndUsername(password, username);
            if (user == null)
                return false;
            else
                return true;

        }
    }
   
}
