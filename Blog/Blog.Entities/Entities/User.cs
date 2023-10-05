using Blog.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Entities
{
    public class User : IEntity
    {
        public string ID { get; set; }   
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool Active { get; set; }
        public Rol Rol { get; set; }


        public List<Article> Articles { get; set; }
        public List<Comment> Comments { get; set; } //bire çok ilişki için list
    }
}
