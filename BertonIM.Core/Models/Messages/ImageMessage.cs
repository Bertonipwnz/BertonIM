namespace BertonIM.Core.Models.Messages
{
	using BertonIM.Core.Models.Base;
	
	/// <summary>
	/// Модель сообщения изображения.
	/// </summary>
	public class ImageMessage : BaseMessage
	{
		public string ImageUrl { get; set; }
	}
}
