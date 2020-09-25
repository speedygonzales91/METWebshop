using METWebShop.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace METWebShop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IUserManager _userManager;

        public int Balance { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IUserManager userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public void OnGet()
        {
            var user = this.User.Identity.Name;

            _userManager.AddBalanceToUser(user,12000);
            Balance = _userManager.GetBalanceOfUser(user);
        }
    }
}
