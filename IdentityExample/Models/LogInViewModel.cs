

using System.ComponentModel.DataAnnotations;

namespace IdentityExample.Models
{
    public class LogInViewModel
    {
		[Required]
		[Display(Name = "Login")]
		public string Login { get; set; }

		[Required]
		[Display(Name = "Hasło")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Display(Name = "Nie wylogowuj mnie")]
		public bool RememberMe { get; set; }
	}
}
