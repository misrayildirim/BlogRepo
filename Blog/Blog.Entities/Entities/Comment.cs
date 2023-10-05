using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Entities
{
    public class Comment : IEntity
    {
        public string ID { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }

        public User User { get; set; }
        public Article Article { get; set; }
    }
}
