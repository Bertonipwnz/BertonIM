namespace BertonIM.Server.Controllers
{
	using BertonIM.Contracts.Auth.Interfaces;
	using BertonIM.Core.Auth.Requests;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	[Route("api/auth")]
	public class AuthController : ControllerBase
	{
		private readonly IAuthService _authService;

		public AuthController(IAuthService authService)
		{
			_authService = authService;
		}

		[HttpPost("register")]
		public async Task<IActionResult> Register([FromBody] RegisterRequest request)
		{
			var result = await _authService.RegisterAsync(request);
			return Ok(result);
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login([FromBody] LoginRequest request)
		{
			var result = await _authService.LoginAsync(request);
			return Ok(result);
		}
	}
}
