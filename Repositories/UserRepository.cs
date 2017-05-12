using MyFirstProj_TreeView.DataContext;
using MyFirstProj_TreeView.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstProj_TreeView.Repositories
{
    public class UserRepository
    {
        private DatabaseContext _db;

        public UserRepository(DatabaseContext db)
        {
            _db = db;
                
        }

        public List<User> GetAll()
        {
            return _db.Users.Select(x => x).ToList();

        }

        public User GetSingle(int id)
        {
            return _db.Users.FirstOrDefault(x => x.UserNo == id);

        }

        public User Add(User user)
        {


            _db.Users.Add(user);

            return user;

        }

        public User Update(User user)
        {
            User single = GetSingle(user.UserNo);

            if(single == null)
            {
                return null;
            }

            _db.Users.Update(single);
            return single;

        }

        public User Create(User user)
        {
           

            if (user == null)
            {
                return null;
            }

            _db.Users.Add(user);
            _db.SaveChanges();
            return user;

        }
    }

  

}
