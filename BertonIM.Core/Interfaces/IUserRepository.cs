namespace BertonIM.Core.Interfaces
{
	using BertonIM.Core.Models.Accounts;
	using System.Threading.Tasks;

	public interface IUserRepository
	{
		Task<User?> GetUserByEmailAsync(string email);
		Task AddUserAsync(User user);
	}
}
