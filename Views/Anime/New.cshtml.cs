using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZAnime.Views
{
    public class New : PageModel
    {
        private readonly ILogger<New> _logger;

        public New(ILogger<New> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}