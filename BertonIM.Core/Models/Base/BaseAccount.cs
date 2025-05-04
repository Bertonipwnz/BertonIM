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

		public string Username { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public AccountType AccountType { get; set; }

		public List<BaseChat> Chats { get; set; } = new();
	}
}
