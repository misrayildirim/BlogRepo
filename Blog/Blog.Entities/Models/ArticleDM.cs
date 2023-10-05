using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Models
{
    public class ArticleDM
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CategoryID { get; set; }
    }
}
