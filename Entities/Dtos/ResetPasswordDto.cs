using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ResetPasswordDto
    {
        public String? UserName { get; init; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required.")]
        public String? Password { get; init; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm Password is required.")]

        [Compare("Password", ErrorMessage = "Passwords must be match.")]

        public String? ConfirmPassword { get; init; }
    }
}