using BookStoreApp.API.Models;

namespace BookStoreApp.API.DTOs.AuthorDtos
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Bio { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
