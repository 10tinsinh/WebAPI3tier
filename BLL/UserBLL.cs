using System;
using System.Collections.Generic;
using WebAPI.Repository.Entities;
using BLL.Models;
using AutoMapper;
using System.Linq;

namespace BLL
{
    public class UserBLL
    {
        private DAL.UserDAL _user;
     

        public UserBLL()
        {
            _user = new DAL.UserDAL();
        
        }

       

        public List<UserModel> GetAll()
        {
            var user = _user.GetAllUser().Select(u => new UserModel
            {
                Id = u.Id,
                Username = u.Username,
                Password = u.Password,
                Fullname = u.Fullname,
                UserStatus = u.UserStatus,
                Email = u.Email

            });
            return user.ToList();
           
        }
    }
}
