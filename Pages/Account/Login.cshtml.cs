using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperMarketWEB.Data;
using SuperMarketWEB.Models;

namespace SuperMarketWEB.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SupermarketContext _context;
        public LoginModel(SupermarketContext context)
        {
            _context = context;
        }

        [BindProperty]

        public User User { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            Console.WriteLine("User:" + User.Email + "Password : " + User.Password);
        }
    }
}
