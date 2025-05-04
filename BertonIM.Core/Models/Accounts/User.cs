namespace BertonIM.Core.Models.Accounts
{
	using BertonIM.Core.Models.Base;

	/// <summary>
	/// Аккаунт пользователя.
	/// </summary>
	public class User : BaseAccount
	{
		/// <summary>
		/// Эмейл.
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Телефон.
		/// </summary>
		public string Phone { get; set; }

		/// <summary>
		/// Хеш пароля.
		/// </summary>
		public string PasswordHash { get; set; } = string.Empty;
	}
}
