using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace BAIS3150_DemoApplication.Pages
{
    public class emallo1StudentModel : PageModel
    {
        public string Message { get; set; } = string.Empty;

        [BindProperty]
        public string FirstName { get; set; } = string.Empty;

        [BindProperty]
        public string LastName { get; set; } = string.Empty;

        [BindProperty]
        public string Email { get; set; } = string.Empty;

        [BindProperty]
        public string Program { get; set; } = string.Empty;

        [BindProperty]
        public string UserID { get; set; } = string.Empty;

        [BindProperty]
        public string Password { get; set; } = string.Empty;

        [BindProperty]
        public string ConfirmPassword { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public void OnPost()
        {
            //validate - Server
            const string emailRegex = @"\w+@\w+(\.\w+)+";
            const string userIDRegex = @"^[A-Z]{4}\d{4}";

            if (FirstName == null || FirstName.Length < 1)
            {
                ModelState.AddModelError("FirstName", "First Name is required.");
            }

            if (LastName == null || LastName.Length < 1)
            {
                ModelState.AddModelError("LastName", "Last Name is required.");
            }

            if (Email == null || !(System.Text.RegularExpressions.Regex.IsMatch(Email, emailRegex)))
            {
                ModelState.AddModelError("Email", "Email is required and must be in the format abc@xyz.com.");
            }

            if (Program == null || Program.Length < 1)
            {
                ModelState.AddModelError("Program", "Select a progam.");
            }

            if (UserID == null || !(UserID.Length == 8) || !(System.Text.RegularExpressions.Regex.IsMatch(UserID, userIDRegex)))
            {
                ModelState.AddModelError("UserID", "User ID is required and must be in the format ABCD1234.");
            }

            if ((Password == null || Password.Length < 6))
            {
                ModelState.AddModelError("Password", "Password must be at least 6 characeres.");
            }


            if (ConfirmPassword == null || ConfirmPassword.Length < 6)
            {
                ModelState.AddModelError("ConfirmPassword", "Confirm Password must be at least 6 characeres.");
            }

            if (Password != ConfirmPassword)
            {
                ModelState.AddModelError("Password", "Password and Confirm Password must match.");
            }




            //check ModelState
            if (ModelState.IsValid)
            {
                Message = "*** OnPost *** - Valid";
            }
            else
            {
                Message = "*** OnPost *** - Not Valid";
            }


        }
    }
}
