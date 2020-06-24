using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesUI.Models;

namespace RazorPagesUI.Pages
{
    public class AddPersonInfo : PageModel
    {

        [BindProperty]
        public PersonInfoModel PersonInfo { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("/Index", new { PersonInfo.FirstName });
        }
    }
}