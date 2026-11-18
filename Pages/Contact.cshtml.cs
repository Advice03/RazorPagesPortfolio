using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesPortfolio.Pages;

public class ContactModel : PageModel
{
    [BindProperty]
    public ContactInput Input { get; set; } = new();

    public string SuccessMessage { get; private set; } = "";

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Demonstration only: no email is sent and no message is persisted.
        SuccessMessage = $"Thank you, {Input.Name}. Your sample message passed validation.";
        ModelState.Clear();
        Input = new ContactInput();

        return Page();
    }

    public class ContactInput
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(80, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 80 characters.")]
        [Display(Name = "Full name")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        [Display(Name = "Email address")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Please enter a subject.")]
        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Subject")]
        public string Subject { get; set; } = "";

        [Required(ErrorMessage = "Please enter a message.")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Message must be between 10 and 1000 characters.")]
        [Display(Name = "Message")]
        public string Message { get; set; } = "";
    }
}
