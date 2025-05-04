namespace BertonIM.Core.Auth.Requests
{
	/// <summary>
	/// Модель запроса регистрации.
	/// </summary>
	public class RegisterRequest
	{
		/// <summary>
		/// Имя пользователя.
		/// </summary>
		public string UserName { get; set; } = string.Empty;

		/// <summary>
		/// Эмейл.
		/// </summary>
		public string Email { get; set; } = string.Empty;

		/// <summary>
		/// Пароль.
		/// </summary>
		public string Password { get; set; } = string.Empty;
	}
}
