using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPC.Pages_Users;

namespace RPC.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly RazorPagesUserContext _context;

        public IndexModel(ILogger<IndexModel> logger, RazorPagesUserContext context)
        {
            _logger = logger;
            _context = context;
        }
        public void OnGet()
        {
        }

    }
}