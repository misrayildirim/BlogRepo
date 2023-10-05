using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Entities
{
    public class Subcategory : IEntity
    {
        public string ID { get ; set ; }
        public string Name { get; set; }
        public string Description { get; set; }


        public string CategoryID { get; set; }
        public Category Category { get; set; }

        public List<Article> Articles { get; set; }
    }
}
