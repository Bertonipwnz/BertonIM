namespace BertonIM.Contracts.Auth.Interfaces
{
	using BertonIM.Core.Auth.Requests;
	using BertonIM.Core.Auth.Responses;
	using System.Threading.Tasks;

	/// <summary>
	/// Интерфейс аутенфикации.
	/// </summary>
	public interface IAuthService
	{
		/// <summary>
		/// Регистрация.
		/// </summary>
		/// <param name="request">Запрос на регистрацию.</param>
		/// <returns>Ответ.</returns>
		Task<AuthResponse> RegisterAsync(RegisterRequest request);

		/// <summary>
		/// Вход по логину.
		/// </summary>
		/// <param name="request">Запрос на логин.</param>
		/// <returns>Ответ.</returns>
		Task<AuthResponse> LoginAsync(LoginRequest request);
	}
}
