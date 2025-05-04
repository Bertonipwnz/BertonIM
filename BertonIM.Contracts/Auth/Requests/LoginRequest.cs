﻿namespace BertonIM.Core.Auth.Requests
{
	/// <summary>
	/// Модель запроса логина в аккаунт.
	/// </summary>
	public class LoginRequest
	{
		/// <summary>
		/// Логин.
		/// </summary>
		public string Login { get; set; } = string.Empty;

		/// <summary>
		/// Пароль.
		/// </summary>
		public string Password { get; set; } = string.Empty;
	}
}
