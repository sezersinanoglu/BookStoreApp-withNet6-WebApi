using AutoMapper;
using BookStoreApp.API.DTOs.AuthorDtos;
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
        }
    }
}
