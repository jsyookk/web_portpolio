using MyFirstProj_TreeView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProj_TreeView.Services
{
    public class UserMapper
    {
        public User MapToEntity(User entity)
        {
            return new User()
            {
                UserNo = entity.UserNo,
                UserId = entity.UserId,
                UserName = entity.UserName,
                UserPassword = entity.UserPassword
               
            };

        }

    }
}
