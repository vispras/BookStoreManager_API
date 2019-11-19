using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetNewBookList_API.Models
{
    public class GetBookList
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}