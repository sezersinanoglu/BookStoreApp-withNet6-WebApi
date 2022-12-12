using System.Reflection.Metadata.Ecma335;

namespace BookStoreApp.API.DTOs.AuthorDtos
{
    public class AuthorReadOnlyDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
    }
}
