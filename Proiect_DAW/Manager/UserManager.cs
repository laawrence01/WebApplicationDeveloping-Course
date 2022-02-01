using System;
namespace Proiect_DAW.Manager
{
    public class UserManager
    {
<<<<<<< HEAD
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
   
=======
        public UserManager()
        {
        }
    }
>>>>>>> dba15c559dc9354eaf9710eac16e6fed232a00ca
}
