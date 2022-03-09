using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using WebAPI.Repository.Entities;
using WebAPI.Repository;

namespace DAL
{
    public class UserDAL
    {
        public List<User> GetAllUser()
        {
            var db = new MyDbContext();
            var User = db.Users.Select(us => new User 
            {
                Id = us.Id,
                Username = us.Username,
                Password = us.Password,
                Fullname = us.Fullname,
                UserStatus = us.UserStatus,
                Email = us.Email

            });
            return User.ToList();
        }
    }
}
