namespace BertonIM.Server.Services
{
	using BertonIM.Core.Models.Accounts;
	using Microsoft.IdentityModel.Tokens;
	using System.IdentityModel.Tokens.Jwt;
	using System.Security.Claims;
	using System.Text;

	/// <summary>
	/// Хелпер по работе с JWT.
	/// </summary>
	public class JwtHelper
	{
		#region Private Fields

		/// <summary>
		/// Экземпляр конфига.
		/// </summary>
		private readonly IConfiguration _config;

		#endregion Private Fields

		#region Public Constructors

		/// <summary>
		/// Создает экземпляр <see cref="JwtHelper"/>
		/// </summary>
		/// <param name="config">Конфиг.</param>
		public JwtHelper(IConfiguration config)
		{
			_config = config;
		}

		#endregion Public Constructors

		#region Public Methods

		/// <summary>
		/// Генерирует JWT конфиг.
		/// </summary>
		/// <param name="user">Модель пользователя.</param>
		/// <returns>JWT токен.</returns>
		public string GenerateJwtToken(User user)
		{
			var key = Encoding.UTF8.GetBytes(_config["Jwt:Key"]);
			var securityKey = new SymmetricSecurityKey(key);
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

			var claims = new List<Claim>
		{
			new Claim(JwtRegisteredClaimNames.Sub, user.Username),
			new Claim(JwtRegisteredClaimNames.Email, user.Email),
			new Claim("UserId", user.Id.ToString())
		};

			var token = new JwtSecurityToken(
				issuer: _config["Jwt:Issuer"],
				audience: _config["Jwt:Audience"],
				claims: claims,
				expires: DateTime.UtcNow.AddDays(_config.GetValue<int>("Jwt:ExpiryDays")),
				signingCredentials: credentials
			);

			return new JwtSecurityTokenHandler().WriteToken(token);
		}

		#endregion Public Methods
	}
}
