namespace NestedFormSampleApplication.Model
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; } = default!;
        public  string Password { get; set; } = default!;
        public  string Email { get; set; } = default!;
    }
}
