using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Logger;
namespace LoginRegisterProject.Pages
{
    public class LoginRegisterModel : PageModel
    {

        private readonly IAuthApi _authApi;

        [BindProperty]
        public EmployeeInput LoginInput { get; set; }
        [BindProperty]
        public EmployeeRegistration RegisterInput { get; set; }

        public LoginRegisterModel(IAuthApi authApi)
        {
            _authApi = authApi;
            Logger.Logger.Log($"Start App", Logger.Logger.LogType.Message);
        }

        public async Task<IActionResult> OnPostLoginAsync()
        {

            try
            {
                var userDetails = await _authApi.LoginAsync(LoginInput);
                Logger.Logger.Log($"Name : {userDetails.Name}", Logger.Logger.LogType.Message);
                if (userDetails != null)
                {
                    HttpContext.Session.SetString("UserName", userDetails.Name);
                    HttpContext.Session.SetString("UserEN", userDetails.EN);
                    return RedirectToPage("/PersonalSum"); // or some other page
          
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return Page();
            }
        }

        public async Task<IActionResult> OnPostRegisterAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                var result = await _authApi.RegisterAsync(RegisterInput);
                // Handle successful registration, e.g., redirecting to login or confirmation page
                return RedirectToPage("/SuccessRegistration");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return Page();
            }
        }
    }
}
