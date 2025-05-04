namespace BertonIM.Server.Data
{
	using BertonIM.Core.Enums;
	using BertonIM.Core.Models.Accounts;
	using BertonIM.Core.Models.Base;
	using BertonIM.Core.Models.Chats;
	using BertonIM.Core.Models.Messages;
	using Microsoft.EntityFrameworkCore;

	public class AppDbContext : DbContext
	{
		public DbSet<BaseAccount> Accounts { get; set; }
		public DbSet<BaseChat> Chats { get; set; }
		public DbSet<BaseMessage> Messages { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Конфигурация для Account
			modelBuilder.Entity<BaseAccount>()
				.HasDiscriminator<AccountType>(a => a.AccountType)
				.HasValue<User>(AccountType.User)
				.HasValue<Admin>(AccountType.Admin);

			// Конфигурация для Chat
			modelBuilder.Entity<BaseChat>()
				.HasDiscriminator<ChatType>(c => c.ChatType)
				.HasValue<PrivateChat>(ChatType.Private)
				.HasValue<GroupChat>(ChatType.Group);

			modelBuilder.Entity<BaseChat>()
				.HasOne(c => c.Owner)
				.WithMany(a => a.Chats)
				.HasForeignKey(c => c.OwnerId);

			// Конфигурация для Message
			modelBuilder.Entity<BaseMessage>()
				.HasDiscriminator<MessageType>(m => m.MessageType)
				.HasValue<TextMessage>(MessageType.Text)
				.HasValue<ImageMessage>(MessageType.Image);

			modelBuilder.Entity<BaseMessage>()
				.HasOne(m => m.Chat)
				.WithMany(c => c.Messages)
				.HasForeignKey(m => m.ChatId);

			modelBuilder.Entity<BaseMessage>()
				.HasOne(m => m.Sender)
				.WithMany()
				.HasForeignKey(m => m.SenderId);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyAppDb;Trusted_Connection=True;");
	}
}
