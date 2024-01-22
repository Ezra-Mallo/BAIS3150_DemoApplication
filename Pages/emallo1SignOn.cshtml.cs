using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;


namespace BAIS3150_DemoApplication.Pages
{
    public class emallo1SignOnModel : PageModel
    {

        public string Message { get; set; } = string.Empty;

        [BindProperty]
        [Required(ErrorMessage ="User ID is required")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "User ID must be exactly 8 characters")]
        [RegularExpression(@"^[A-Z]{4}\d{4}$", ErrorMessage = "User ID must be in the format 'BAIS9999'")] 
        public string UserID { get; set; } = string.Empty;


        [BindProperty]
        [Required(ErrorMessage = "Password must be at least 6 characters")]
        [StringLength((int.MaxValue), MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters")]
        public string Password { get; set; } = string.Empty;

        public void OnGet()
        {
            
        }
        public void OnPost()
        {

        }
    }
}
