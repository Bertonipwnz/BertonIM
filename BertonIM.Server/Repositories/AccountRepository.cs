namespace BertonIM.Server.Repositories
{
	using BertonIM.Core.Interfaces;
	using BertonIM.Core.Models.Accounts;
	using BertonIM.Server.Data;
	using Microsoft.EntityFrameworkCore;

	/// <summary>
	/// Класс репозиторий для работы с учетными записями пользователей.
	/// </summary>
	public class AccountRepository : IAccountRepository
	{
		#region Private Fields

		/// <summary>
		/// Экземпляр контекста БД.
		/// </summary>
		private readonly AppDbContext _dbContext;

		#endregion Private Fields

		#region Public Constructors

		/// <summary>
		/// Создает экземпляр <see cref="AccountRepository"/>
		/// </summary>
		/// <param name="dbContext">Контекст БД.</param>
		public AccountRepository(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		#endregion Public Constructors

		#region Public Methods

		/// <summary>
		/// Получает пользователя по эмейл.
		/// </summary>
		/// <param name="email">Эмейл.</param>
		/// <returns>Модель пользователя.</returns>
		public async Task<User?> GetAccountByEmailAsync(string email)
		{
			return await _dbContext.Accounts.OfType<User>().FirstOrDefaultAsync(u => u.Email == email);
		}

		/// <summary>
		/// Добавление аккаунта.
		/// </summary>
		/// <param name="user">Модель пользователя.</param>
		public async Task AddAccountAsync(User user)
		{
			await _dbContext.Accounts.AddAsync(user);
			await _dbContext.SaveChangesAsync();
		}

		#endregion Public Methods
	}
}
