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

		public DateTime SentTime { get; set; } = DateTime.UtcNow;
		public MessageType MessageType { get; set; }

		public long ChatId { get; set; }
		public BaseChat Chat { get; set; }

		public long SenderId { get; set; }
		public BaseAccount Sender { get; set; }
	}
}
