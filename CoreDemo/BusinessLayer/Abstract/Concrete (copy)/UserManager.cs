using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract.Concrete
{
    public class UserManager : IUserService
    {

        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {

            _userDal = userDal;
        }


        public void UserAdd(User user)
        {
            _userDal.Insert(user);
        }
    }
}

