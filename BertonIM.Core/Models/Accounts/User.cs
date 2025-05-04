namespace BertonIM.Core.Models.Accounts
{
    using BertonIM.Core.Models.Base;

    /// <summary>
    /// Аккаунт пользователя.
    /// </summary>
    public class User : BaseAccount
    {
		public string Email { get; set; }
		public string Phone { get; set; }

		public string PasswordHash { get; set; } = string.Empty;
	}
}
