namespace BertonIM.Server.Services
{
    using BertonIM.Contracts.Auth.Interfaces;
    using BertonIM.Core.Auth.Requests;
    using BertonIM.Core.Auth.Responses;
	using BertonIM.Core.Interfaces;
	using BertonIM.Core.Models.Accounts;
	using System.Threading.Tasks;

    public class AuthService : IAuthService
	{
		private readonly JwtHelper _jwtHelper;
		private readonly IAccountRepository _userRepository;

		public AuthService(IAccountRepository repository,JwtHelper jwtHelper)
		{
			_userRepository = repository;
			_jwtHelper = jwtHelper;
		}

		public async Task<AuthResponse> LoginAsync(LoginRequest request)
		{
			var user = await _userRepository.GetAccountByEmailAsync(request.Login);
			if (user == null || !VerifyPassword(request.Password, user.PasswordHash))
				return new AuthResponse { Error = "Invalid credentials" };

			var token = _jwtHelper.GenerateJwtToken(user);
			return new AuthResponse { Token = token, Account = user };
		}

		public async Task<AuthResponse> RegisterAsync(RegisterRequest request)
		{
			var user = new User
			{
				Username = request.UserName,
				Email = request.Email,
				PasswordHash = HashPassword(request.Password)
			};

			await _userRepository.AddAccountAsync(user);
			return new AuthResponse { Account = user };
		}

		private string HashPassword(string password)
		{
			return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 12);
		}

		private bool VerifyPassword(string password, string storedHash)
		{
			return BCrypt.Net.BCrypt.Verify(password, storedHash);
		}
	}
}
