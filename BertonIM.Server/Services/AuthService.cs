namespace BertonIM.Server.Services
{
    using BertonIM.Contracts.Auth.Interfaces;
    using BertonIM.Core.Auth.Requests;
    using BertonIM.Core.Auth.Responses;
	using BertonIM.Core.Interfaces;
	using BertonIM.Core.Models.Accounts;
	using System.Threading.Tasks;

	/// <summary>
	/// Сервис аутенфикации.
	/// </summary>
    public class AuthService : IAuthService
	{
		#region Private Fields

		/// <summary>
		/// Хелпер JWT.
		/// </summary>
		private readonly JwtHelper _jwtHelper;

		/// <summary>
		/// Экземпляр репозитория по работе с аккаунтами.
		/// </summary>
		private readonly IAccountRepository _accaountRepository;

		#endregion Private Fields

		#region Public Constructors

		/// <summary>
		/// Создает экземпляр <see cref="AuthService"/>
		/// </summary>
		/// <param name="repository">Репозиторий аккаунтов.</param>
		/// <param name="jwtHelper">JWT хелпер.</param>
		public AuthService(IAccountRepository repository,JwtHelper jwtHelper)
		{
			_accaountRepository = repository;
			_jwtHelper = jwtHelper;
		}

		#endregion Public Constructors

		#region Public Methods

		/// <summary>
		/// Логин.
		/// </summary>
		/// <param name="request">Запрос на логин.</param>
		/// <returns>Ответ аутенфикации.</returns>
		public async Task<AuthResponse> LoginAsync(LoginRequest request)
		{
			var user = await _accaountRepository.GetAccountByEmailAsync(request.Login);
			if (user == null || !VerifyPassword(request.Password, user.PasswordHash))
				return new AuthResponse { Error = "Invalid credentials" };

			var token = _jwtHelper.GenerateJwtToken(user);
			return new AuthResponse { Token = token, Account = user };
		}

		/// <summary>
		/// Регистрация.
		/// </summary>
		/// <param name="request">Запрос на регистрацию.</param>
		/// <returns>Ответ аутенфикации.</returns>
		public async Task<AuthResponse> RegisterAsync(RegisterRequest request)
		{
			var user = new User
			{
				Username = request.UserName,
				Email = request.Email,
				PasswordHash = HashPassword(request.Password)
			};

			await _accaountRepository.AddAccountAsync(user);
			return new AuthResponse { Account = user };
		}

		#endregion Public Methods

		#region Private Methods

		/// <summary>
		/// Хеширует пароль.
		/// </summary>
		/// <param name="password">Пароль.</param>
		/// <returns>hash строка.</returns>
		private string HashPassword(string password)
		{
			return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 12);
		}

		/// <summary>
		/// Верифицирует пароль.
		/// </summary>
		/// <param name="password">Пароль.</param>
		/// <param name="storedHash">Hash строка.</param>
		/// <returns>true - пройдена.</returns>
		private bool VerifyPassword(string password, string storedHash)
		{
			return BCrypt.Net.BCrypt.Verify(password, storedHash);
		}

		#endregion Private Methods
	}
}
