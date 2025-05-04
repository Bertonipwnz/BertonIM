namespace BertonIM.Core.Models.Chats
{
	using BertonIM.Core.Models.Accounts;
	using BertonIM.Core.Models.Base;
	
	/// <summary>
	/// Модель личного чата.
	/// </summary>
	public class PrivateChat : BaseChat
	{
		public long ParticipantId { get; set; }
		public User Participant { get; set; }
	}
}
