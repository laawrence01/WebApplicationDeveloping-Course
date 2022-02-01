using Microsoft.EntityFrameworkCore;
using Proiect_DAW.data;
using Proiect_DAW.Models;
using System.Linq;

public class UserRepository
{
    protected readonly Proiect_DAWContext _context;
    protected readonly DbSet<User> _table;

    public UserRepository(Proiect_DAWContext context)
    {
        _context = context;
        _table = context.Set<User>();
    }


    public User GetUserByPasswordAndUsername(string password, string username)
    {
        return _table.Where(x => x.Password == password  && x.Username == username).FirstOrDefault();
    }

    public User GetByUsername(string username)
    {
        return _table.Where(x => x.Username == username).FirstOrDefault();
    }

}
