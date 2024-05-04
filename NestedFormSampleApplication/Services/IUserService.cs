using NestedFormSampleApplication.Model;

namespace NestedFormSampleApplication.Services
{
    public interface IUserService
    {
        public int Create(UserDto user);
        public UserDto Edit(int userId);
        public int Update(UserDto user);
    }
}
