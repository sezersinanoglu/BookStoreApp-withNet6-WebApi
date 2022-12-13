using AutoMapper;
using BookStoreApp.API.DTOs.AuthorDtos;
using BookStoreApp.API.DTOs.BookDtos;
using BookStoreApp.API.Models;

namespace BookStoreApp.API.Configuration
{
    public class MapperConfig:Profile
    {
        public MapperConfig() 
        { 
            //AuthorDto Map Config Settings
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();

            //BookDto Map Config Settings
            CreateMap<BookDto, Book>().ReverseMap();
            CreateMap<BookReadOnlyDto, Book>().ReverseMap();
            CreateMap<BookCreateDto, Book>().ReverseMap();
            CreateMap<BookUpdateDto, Book>().ReverseMap();
        }
    }
}
