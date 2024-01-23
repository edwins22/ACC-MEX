using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App_ACC_MEX.Pages.Shared
{
    public class MisionModel : PageModel
    {
        private readonly ILogger<MisionModel> _logger;

        public MisionModel(ILogger<MisionModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}