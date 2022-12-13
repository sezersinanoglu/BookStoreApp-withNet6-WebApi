﻿namespace BookStoreApp.API.DTOs.BookDtos
{
    public class BookUpdateDto:BaseDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int? Year { get; set; }
        public string Isbn { get; set; } = null!;
        public string? Summary { get; set; }
        public string? Image { get; set; }
        public decimal? Price { get; set; }
        public int? AuthorId { get; set; }
    }
}
