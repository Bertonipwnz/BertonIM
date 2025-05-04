namespace BertonIM.Core.Auth.Responses
{
	using BertonIM.Core.Models.Base;

	/// <summary>
	/// Модель ответа авторизации.
	/// </summary>
	public class AuthResponse
	{
		/// <summary>
		/// Успешно ли?
		/// </summary>
		public bool IsSuccess { get; set; } = false;

		/// <summary>
		/// JWT токен.
		/// </summary>
		public string Token { get; set; } = string.Empty;

		/// <summary>
		/// Сообщение ошибки.
		/// </summary>
		public string Error { get; set; }

		/// <summary>
		/// Выбранный аккаунт.
		/// </summary>
		public BaseAccount Account { get; set; }
	}
}
