namespace BertonIM.Core.Models.Chats
{
	using BertonIM.Core.Models.Accounts;
	using BertonIM.Core.Models.Base;
	
	/// <summary>
	/// Модель личного чата.
	/// </summary>
	public class PrivateChat : BaseChat
	{
		/// <summary>
		/// Айди участника 1.
		/// </summary>
		public long Participant1Id { get; set; }

		/// <summary>
		/// Участник 1.
		/// </summary>
		public User Participant1 { get; set; }

		/// <summary>
		/// Айди участника 2.
		/// </summary>
		public long Participant2Id { get; set; }

		/// <summary>
		/// Участник 2.
		/// </summary>
		public User Participant2 { get; set; }
	}
}
