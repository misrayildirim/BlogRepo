using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Entities
{
    public class Category : IEntity
    {
        public string ID { get ; set; }
        public string Name { get; set; }

        public List<Subcategory>? Subcategory { get; set; }

        public List<Article> Articles { get; set; }




    }
}
