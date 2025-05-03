namespace BertonIM.Core.Models.Base
{
    /// <summary>
    /// Базовая модель аккаунта.
    /// </summary>
    public abstract class BaseAccount
    {
        /// <summary>
        /// Айди аккаунта.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Эмейл.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Имя пользователя.
        /// </summary>
		public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Url аватара.
        /// </summary>
		public string AvatarUrl { get; set; } = string.Empty;
	}
}
