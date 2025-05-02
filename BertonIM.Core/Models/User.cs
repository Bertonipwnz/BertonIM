namespace BertonIM.Core.Models
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class User
	{
		public long Id { get; set; }

		public string Username { get; set; } = string.Empty;

		public string Email { get; set; } = string.Empty;

		public string AvatarUrl { get; set; } = string.Empty;
	}
}
