using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
            Console.Write("Hola Mundo Sobre Linea");
        }
        public void OnGet()
        {
        }

    }
}