using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.SE1.Models
{
    internal class Author
    {
        public int AuthorId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Navigation Property (M:M with Books)
        public List<Book> Books { get; set; } = new List<Book>();

    }
}
