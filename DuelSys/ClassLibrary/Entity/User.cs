using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary
{
    public class User
    {
		public int Id
		{
			get; set;
		}
		[Required(ErrorMessage = "Please type a valid email")]
		[DataType(DataType.EmailAddress)]
		[EmailAddress(ErrorMessage = "This isn't a valid Email")]
		public string Email
		{
			get; set;
		}
		[Required(ErrorMessage = "Please type a password in the space")]
		[StringLength(255, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string Password
		{
			get; set;
		}
		[Required]
		public string FullName
		{
			get;set;
		}

		public UserRoleEnum Role
		{
			get;set;
		}

		public User()
		{
			
		}

		public User(  string email, string password, string fullName, UserRoleEnum role)
		{
			this.Email = email;
			this.Password = password;
			this.FullName = fullName;
			this.Role = role;
		}

		public string ToString()
		{
			return null;
		}
	}
}
