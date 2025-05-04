namespace BertonIM.Core.Interfaces
{
	using BertonIM.Core.Models.Accounts;
	using System.Threading.Tasks;

	/// <summary>
	/// Интерфейс по работе с данными аккаунтов в хранилище.
	/// Предоставляет базовые операции для управления учетными записями пользователей.
	/// </summary>
	public interface IAccountRepository
	{
		/// <summary>
		/// Возвращает учетную запись пользователя по адресу электронной почты.
		/// </summary>
		/// <param name="email">Электронная почта пользователя</param>
		/// <returns>
		/// Объект <see cref="User"/>, если запись найдена; 
		/// <c>null</c>, если пользователь с указанной почтой не существует.
		/// </returns>
		Task<User?> GetAccountByEmailAsync(string email);

		/// <summary>
		/// Добавляет новую учетную запись пользователя в хранилище.
		/// </summary>
		/// <param name="user">Объект пользователя для сохранения</param>
		Task AddAccountAsync(User user);
	}
}
