namespace BertonIM.Core.Models.Base
{
	using BertonIM.Core.Enums;
	using System;

	/// <summary>
	/// Базовая модель сообщения.
	/// </summary>
	public abstract class BaseMessage
	{
		/// <summary>
		/// Айди сообщения.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Дата отправки.
		/// </summary>
		public DateTime SentTime { get; set; } = DateTime.UtcNow;

		/// <summary>
		/// Тип сообщения.
		/// </summary>
		public MessageType MessageType { get; set; }

		/// <summary>
		/// Айди чата.
		/// </summary>
		public long ChatId { get; set; }

		/// <summary>
		/// Чат.
		/// </summary>
		public BaseChat Chat { get; set; }

		/// <summary>
		/// Айди отправителя.
		/// </summary>
		public long SenderId { get; set; }

		/// <summary>
		/// Отправитель.
		/// </summary>
		public BaseAccount Sender { get; set; }
	}
}
