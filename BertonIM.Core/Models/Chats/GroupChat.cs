namespace BertonIM.Core.Models.Chats
{
	using BertonIM.Core.Models.Base;

	/// <summary>
	/// Модель группового чата.
	/// </summary>
	public class GroupChat : BaseChat
	{
		/// <summary>
		/// Максимальное количество участников.
		/// </summary>
		public int MaxMembers { get; set; }

		/// <summary>
		/// Описание.
		/// </summary>
		public string Description { get; set; } = string.Empty;
	}
}
