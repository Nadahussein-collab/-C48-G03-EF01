using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.SE1.Models
{
    internal class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        //NavigationProperty (1:M)
        public List<Book> Books { get; set; } = new List<Book>();


    }
}
