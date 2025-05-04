namespace BertonIM.Server.Repositories
{
	using BertonIM.Core.Interfaces;
	using BertonIM.Core.Models.Accounts;
	using BertonIM.Server.Data;
	using Microsoft.EntityFrameworkCore;
	using System;

	public class UserRepository : IUserRepository
	{
		private readonly AppDbContext _dbContext;

		public UserRepository(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<User?> GetUserByEmailAsync(string email)
		{
			return await _dbContext.Accounts.OfType<User>().FirstOrDefaultAsync(u => u.Email == email);
		}

		public async Task AddUserAsync(User user)
		{
			await _dbContext.Accounts.AddAsync(user);
			await _dbContext.SaveChangesAsync();
		}
	}
}
