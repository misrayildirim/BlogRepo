using Blog.Business.Manager;
using Blog.Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.UI.Controllers
{
    public class CommentController : Controller
    {
        private ICommentManager commentManager;

        public CommentController(ICommentManager _commentManager)
        {
            this.commentManager = _commentManager;
        }
        public IActionResult Comment()
        {
            return View();

        }
        public IActionResult Add(Comment comment)
        {
            var _comment = new Comment
            {
                Content = comment.Content
            };
            commentManager.Add(_comment);

            return View();
        }
    }

}