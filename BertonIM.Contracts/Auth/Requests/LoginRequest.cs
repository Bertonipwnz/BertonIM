namespace BertonIM.Core.Auth.Requests
{
	/// <summary>
	/// Модель запроса логина в аккаунт.
	/// </summary>
	public class LoginRequest
	{
		public string Login { get; set; } = string.Empty;

		public string Password { get; set; } = string.Empty;
	}
}
