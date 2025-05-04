namespace BertonIM.Core.Models
{
	using BertonIM.Core.Models.Base;

	/// <summary>
	/// Модель участника чата.
	/// </summary>
	public class ChatParticipant
	{
		/// <summary>
		/// Айди чата.
		/// </summary>
		public long ChatId { get; set; }

		/// <summary>
		/// Чат.
		/// </summary>
		public BaseChat Chat { get; set; }

		/// <summary>
		/// Айди пользователя.
		/// </summary>
		public long UserId { get; set; }

		/// <summary>
		/// Пользователь.
		/// </summary>
		public BaseAccount User { get; set; }
	}
}
