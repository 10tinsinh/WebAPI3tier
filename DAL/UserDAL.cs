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
            var user = new MyDbContext();
            return user.Users.ToList();
        }
    }
}
