namespace BertonIM.Core.Models.Messages
{
	using BertonIM.Core.Models.Base;

	/// <summary>
	/// Модель текстового сообщения.
	/// </summary>
	public class TextMessage : BaseMessage
	{
		/// <summary>
		/// Контент сообщения.
		/// </summary>
		public string Content { get; set; } = string.Empty;
	}
}
