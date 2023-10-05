using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Entities
{
    public class Article : IEntity
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
        public bool Publish { get; set; }


        public User User { get; set; }
        public List<Comment> Comments { get; set; }

        public Category cateogry { get; set; }

      
    }
}
