using System.ComponentModel.DataAnnotations;

namespace WishList.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(maximumLength: 100, ErrorMessage = "Password must be at least 8 characters long and maximum 100.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password not match with confirmation.")]
        public string ConfirmPassword { get; set; }
    }
}
