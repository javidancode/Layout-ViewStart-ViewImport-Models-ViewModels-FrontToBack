using Layout_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layout_Models.ViewModels
{
    public class HomeVM
    {
        public List<Book> Books { get; set; }

        public Car Car{ get; set; }
    }
}
