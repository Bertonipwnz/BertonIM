namespace BertonIM.Core.Models.Base
{
	using BertonIM.Core.Enums;
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Базовая модель аккаунта.
	/// </summary>
	public abstract class BaseAccount
	{
		/// <summary>
		/// Айди аккаунта.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Имя пользователя.
		/// </summary>
		public string Username { get; set; }

		/// <summary>
		/// Дата создания.
		/// </summary>
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

		/// <summary>
		/// Тип аккаунта.
		/// </summary>
		public AccountType AccountType { get; set; }

		/// <summary>
		/// Чаты.
		/// </summary>
		public List<BaseChat> Chats { get; set; } = new();
	}
}
