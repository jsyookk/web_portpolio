using MyFirstProj_TreeView.DataContext;
using MyFirstProj_TreeView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProj_TreeView.Repositories
{
    public class CategoryRepository
    {

        private DatabaseContext _db;

        public CategoryRepository(DatabaseContext db)
        {
            _db = db;

        }

        public List<Category> GetAll()
        {
            return _db.Categorys.Select(x => x).ToList();

        }

        public List<Category> GetUserCategory(int userID)
        {

            return _db.Categorys.Where(x => x.UserNo == userID).ToList();

        }

        public Category GetSingle(int id)
        {
            return _db.Categorys.FirstOrDefault(x => x.CategoryID == id);

        }

        public Category Add(Category cat)
        {
            

            _db.Categorys.Add(cat);

            return cat;

        }

        public Category Update(Category cat)
        {
            Category single = GetSingle(cat.CategoryID);

            if (single == null)
            {
                return null;
            }

            _db.Categorys.Update(single);
            return single;

        }

        public Category Create(Category cat)
        {


            if (cat == null)
            {
                return null;
            }

            _db.Categorys.Add(cat);
            _db.SaveChanges();
            return cat;

        }
    }


}
