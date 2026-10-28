using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.SE1.Models
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int pages { get; set; }
        public int PublishedYear { get; set; }
        public bool IsInStock { get; set; }

        public int CategoryId { get; set; }
        public Categories Categories{ get; set; }



    }
}
