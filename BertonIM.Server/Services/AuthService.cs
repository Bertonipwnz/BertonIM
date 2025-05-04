namespace BertonIM.Server.Services
{
	using BertonIM.Contracts.Auth.Interfaces;
	using BertonIM.Core.Auth.Requests;
	using BertonIM.Core.Auth.Responses;
	using System.Threading.Tasks;

	public class AuthService : IAuthService
	{
		public Task<AuthResponse> LoginAsync(LoginRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<AuthResponse> RegisterAsync(RegisterRequest request)
		{
			throw new NotImplementedException();
		}
	}
}
