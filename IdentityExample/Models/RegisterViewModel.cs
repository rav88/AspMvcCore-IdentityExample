using System.ComponentModel.DataAnnotations;

namespace IdentityExample.Models
{
    public class RegisterViewModel
    {
		[Required]
		public string Login { get; set; }

		[Required]
		[DataType(DataType.Password)]
	    public string Password { get; set; }

	    [DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Hasła muszą być identyczne")]
	    public string RetypePassword { get; set; }

		[Required]
		[EmailAddress]
	    public string Email { get; set; }
    }
}
