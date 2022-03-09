using System;
using System.Collections.Generic;
using WebAPI.Repository.Entities;
using BLL.Models;
using AutoMapper;

namespace BLL
{
    public class UserBLL
    {
        private DAL.UserDAL _user;
        private Mapper _UserMapper;

        public UserBLL()
        {
            _user = new DAL.UserDAL();
            var _configUser = new MapperConfiguration(cfg => cfg.CreateMap<User, UserModel>().ReverseMap());
            _UserMapper = new Mapper(_configUser);
        }

        public List<UserModel> GetAllUser()
        {
            List<User> usesfromdb = _user.GetAllUser();

            List<UserModel> userModels = _UserMapper.Map<List<User>, List<UserModel>>(usesfromdb);

            return userModels;
        }
    }
}
