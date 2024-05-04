using Microsoft.AspNetCore.Http.HttpResults;
using NestedFormSampleApplication.Model;

namespace NestedFormSampleApplication.Services
{
    /// <summary>
    /// **************************Important note***********************
    /// This is a code sample, in here you can connect to API Service
    /// Or Save Data in DbContext
    /// For sample I use List
    /// </summary>
    public class UserService : IUserService
    {
        public IList<UserDto> _Users;

        public UserService()
        {
            _Users = new List<UserDto>();
            _Users.Add(new UserDto
            {
                Id = 1,
                UserName = "test",
                Password = "12334",
                Email = "test@gmail.com"
            });

        }
        public int Create(UserDto user)
        {
            Random rnd = new Random(1);
            user.Id=rnd.Next(2, 100);
            _Users.Add(user);
            return user.Id;
        }

        public UserDto Edit(int userId)
        {
            var result= _Users.Where(x => x.Id == userId).FirstOrDefault();
            if (result==null)
            {
                //error not found
            }
            return result;
        }

        public int Update(UserDto user)
        {
            var result = _Users.Where(x => x.Id == user.Id).FirstOrDefault();
            if (result != null)
            {
                result.UserName= user.UserName;
                result.Password = user.Password;
                result.Email = user.Email;               
            }
            return user.Id;
        }
    }
}
