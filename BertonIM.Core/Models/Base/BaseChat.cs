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

		public string Title { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public ChatType ChatType { get; set; }

		public long OwnerId { get; set; }
		public BaseAccount Owner { get; set; }

		public List<BaseMessage> Messages { get; set; } = new();
	}
}
