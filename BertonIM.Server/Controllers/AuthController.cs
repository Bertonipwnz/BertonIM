namespace BertonIM.Server.Controllers
{
	using BertonIM.Contracts.Auth.Interfaces;
	using BertonIM.Core.Auth.Requests;
	using Microsoft.AspNetCore.Mvc;

	/// <summary>
	/// Контроллер аутенфикации.
	/// </summary>
	[ApiController]
	[Route("api/auth")]
	public class AuthController : ControllerBase
	{
		#region Private Fields

		/// <summary>
		/// Сервис аутенфикации.
		/// </summary>
		private readonly IAuthService _authService;

		#endregion Private Fields

		#region Public Constructors

		/// <summary>
		/// Создает экземпляр <see cref="AuthController"/>
		/// </summary>
		/// <param name="authService">Сервис аутенфикации.</param>
		public AuthController(IAuthService authService)
		{
			_authService = authService;
		}

		#endregion Public Constructors

		#region Public Methods

		/// <summary>
		/// Регистрация.
		/// </summary>
		/// <param name="request">Запрос для регистрации.</param>
		[HttpPost("register")]
		public async Task<IActionResult> Register([FromBody] RegisterRequest request)
		{
			var result = await _authService.RegisterAsync(request);
			return Ok(result);
		}

		/// <summary>
		/// Логин.
		/// </summary>
		/// <param name="request">Запрос для логина.</param>
		[HttpPost("login")]
		public async Task<IActionResult> Login([FromBody] LoginRequest request)
		{
			var result = await _authService.LoginAsync(request);
			return Ok(result);
		}

		#endregion Public Methods
	}
}
