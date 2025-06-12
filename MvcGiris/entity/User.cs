using MvcGiris.entity.enums;

namespace MvcGiris.entity
{
    public class User : BaseEntity
    {        
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public byte? Age { get; set; }
        public ERole Role { get; set; }
    }

}
