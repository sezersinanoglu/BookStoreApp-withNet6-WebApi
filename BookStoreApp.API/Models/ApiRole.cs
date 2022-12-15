using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.API.Models
{
    public class ApiRole:IdentityRole
    {
        public string RoleId { get; set; }
        public string UserId { get; set; }
    }
}
