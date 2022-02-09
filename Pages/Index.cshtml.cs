using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPC.Pages_Users;
using RPC.Models;

namespace RPC.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly RazorPagesUserContext _context;

        public bool isLogged;

        public IndexModel(ILogger<IndexModel> logger, RazorPagesUserContext context)
        {
            _logger = logger;
            _context = context;
            isLogged = true;
        }
        public void OnGet()
        {
        }

        [BindProperty]
        public User UserRPC { get; set; }

        public void OnPost()
        {
            var dataBaseUser = _context.User.FirstOrDefault(u => u.UserName == UserRPC.UserName && u.Password == UserRPC.Password);

            if (dataBaseUser != null)
            {
                Response.Redirect("/Users/Main");
            }
            else
            {
                isLogged = false;
                Page();
            }
        }
    }
}