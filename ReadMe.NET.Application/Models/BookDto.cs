using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMe.NET.Application.Models
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public AuthorDto Author { get; set; }
    }
}
