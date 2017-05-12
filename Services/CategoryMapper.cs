using MyFirstProj_TreeView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProj_TreeView.Services
{
    public class CategoryMapper
    {

        public Category MapToEntity(Category entity)
        {
            return new Category()
            {
             
                CategoryName = entity.CategoryName,
                ParentId = entity.ParentId,
                UserNo = entity.UserNo,
                CategoryID = entity.CategoryID,
                OrderNum = entity.OrderNum

            };
        }
    }
}
