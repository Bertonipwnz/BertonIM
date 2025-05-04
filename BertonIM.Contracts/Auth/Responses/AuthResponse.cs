namespace BertonIM.Core.Auth.Responses
{
	using BertonIM.Core.Models.Accounts;

	/// <summary>
	/// Модель ответа авторизации.
	/// </summary>
	public class AuthResponse
	{
		public bool IsSuccess { get; set; } = false;

		public string Token { get; set; } = string.Empty;

		public string Error { get; set; }

		public User User { get; set; }
	}
}
