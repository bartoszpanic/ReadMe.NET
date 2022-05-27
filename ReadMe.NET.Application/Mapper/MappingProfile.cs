using AutoMapper;
using ReadMe.NET.Application.Models;
using ReadMe.NET.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMe.NET.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Author, AuthorDto>().ReverseMap();
        }
    }
}
