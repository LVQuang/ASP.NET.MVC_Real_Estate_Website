using Real_Estate_Website.DTO.Request;
using Real_Estate_Website.Identity;
using System.Web.Helpers;

namespace Real_Estate_Website.Mapper
{
    public class UserMapper
    {
        public AppUser RegisterToAppUser(Register registerRequest)
        {
            return new AppUser()
            {
                UserName = registerRequest.UserName,
                Email = registerRequest.Email,
                PasswordHash = Crypto.HashPassword(registerRequest.Password),
                City = registerRequest.City,
                Address = registerRequest.Address,
                PhoneNumber = registerRequest.PhoneNumber,
                Birtday = registerRequest.DateOfBirth,
            };
        }
    }
}