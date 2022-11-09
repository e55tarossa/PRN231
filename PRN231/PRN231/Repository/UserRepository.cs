using PRN231.Data;
using PRN231.Interfaces;
using PRN231.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRN231.Repository
{
    public class UserRepository : IUserRepository
    {
        /*private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateUser(User user)
        {
            _context.Add(user);
            return Save();
        }

        public bool DeleteUser(User user)
        {
            _context.Remove(user);
            return Save();
        }

        public User GetUser(Guid id)
        {
            return _context.Users.Where(u => u.Id == id).FirstOrDefault();
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateUser(User user)
        {
            _context.Update(user);
            return Save();
        }

        public bool UserExists(Guid id)
        {
            return _context.Users.Any(u => u.Id == id);
        }*/
    }
}
