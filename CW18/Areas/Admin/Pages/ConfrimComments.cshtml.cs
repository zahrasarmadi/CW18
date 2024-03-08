using CW18.Database;
using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Areas.AdminArea.Pages
{
    public class ConfrimCommentsModel : PageModel
    {
        AdminRepository adminRipository = new AdminRepository();

        CommentRepository commentRepository = new CommentRepository();

        [BindProperty]
        public List<Comment> Comments { get; set; } = new List<Comment>();

        [BindProperty]
        public Admin OnlineAdmin { get; set; } = StaticDatabase.Admin;

        public void OnGet()
        {
            Comments = commentRepository.GetCommentsLit();
            if (OnlineAdmin == null)
            {
                TempData["False"] = "False";
            }
        }

        public IActionResult OnGetConfrim(int id)
        {
            adminRipository.ConfrimComment(id);
            return RedirectToAction("OnGet");
        }
    }
}
