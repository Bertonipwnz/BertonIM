namespace BertonIM.Server.Repositories
{
	using BertonIM.Core.Interfaces;
	using BertonIM.Core.Models.Accounts;
	using BertonIM.Server.Data;
	using Microsoft.EntityFrameworkCore;
	using System;

	public class AccountRepository : IAccountRepository
	{
		private readonly AppDbContext _dbContext;

		public AccountRepository(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<User?> GetAccountByEmailAsync(string email)
		{
			return await _dbContext.Accounts.OfType<User>().FirstOrDefaultAsync(u => u.Email == email);
		}

		public async Task AddAccountAsync(User user)
		{
			await _dbContext.Accounts.AddAsync(user);
			await _dbContext.SaveChangesAsync();
		}
	}
}
