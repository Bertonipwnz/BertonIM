namespace BertonIM.Core.Models.Base
{
	using BertonIM.Core.Enums;
	using System.Collections.Generic;
	using System;

	/// <summary>
	/// Базовая модель чата.
	/// </summary>
	public abstract class BaseChat
	{
		/// <summary>
		/// Айди чата.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Заголовок.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Дата создания.
		/// </summary>
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

		/// <summary>
		/// Тип чата.
		/// </summary>
		public ChatType ChatType { get; set; }

		/// <summary>
		/// Айди владельца.
		/// </summary>
		public long OwnerId { get; set; }

		/// <summary>
		/// Владелец.
		/// </summary>
		public BaseAccount Owner { get; set; }

		/// <summary>
		/// Список сообщений.
		/// </summary>
		public List<BaseMessage> Messages { get; set; } = new();

		/// <summary>
		/// Список участников.
		/// </summary>
		public List<ChatParticipant> Participants { get; set; } = new();
	}
}
