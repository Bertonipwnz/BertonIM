namespace BertonIM.Core.Models.Chats
{
	using BertonIM.Core.Models.Base;

	/// <summary>
	/// Модель группового чата.
	/// </summary>
	public class GroupChat : BaseChat
	{
		public int MaxMembers { get; set; }
		public string Description { get; set; } = string.Empty;
	}
}
