namespace BertonIM.Contracts.Auth.Interfaces
{
	using BertonIM.Core.Auth.Requests;
	using BertonIM.Core.Auth.Responses;
	using System.Threading.Tasks;

	public interface IAuthService
	{
		Task<AuthResponse> RegisterAsync(RegisterRequest request);
		Task<AuthResponse> LoginAsync(LoginRequest request);
	}
}
