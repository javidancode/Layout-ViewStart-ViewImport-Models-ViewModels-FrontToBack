using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layout_Models.Models
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }

        public string AuthorName { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
