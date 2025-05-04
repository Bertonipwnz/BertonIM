namespace BertonIM.Server.Data
{
	using BertonIM.Core.Enums;
	using BertonIM.Core.Models;
	using BertonIM.Core.Models.Accounts;
	using BertonIM.Core.Models.Base;
	using BertonIM.Core.Models.Chats;
	using BertonIM.Core.Models.Messages;
	using Microsoft.EntityFrameworkCore;
	using System.Diagnostics;

	/// <summary>
	/// Контекст базы данных.
	/// </summary>
	public class AppDbContext : DbContext
	{
		#region Public Properties

		/// <summary>
		/// Аккаунты.
		/// </summary>
		public DbSet<BaseAccount> Accounts { get; set; }

		/// <summary>
		/// Чаты.
		/// </summary>
		public DbSet<BaseChat> Chats { get; set; }

		/// <summary>
		/// Сообщения.
		/// </summary>
		public DbSet<BaseMessage> Messages { get; set; }

		#endregion Public Properties

		#region Protected Methods

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Конфигурация для Account
			modelBuilder.Entity<BaseAccount>()
				.HasDiscriminator<AccountType>(a => a.AccountType)
				.HasValue<User>(AccountType.User)
				.HasValue<Admin>(AccountType.Admin);

			// Конфигурация для Chat
			modelBuilder.Entity<BaseChat>(b =>
			{
				b.HasDiscriminator<ChatType>(c => c.ChatType)
					.HasValue<PrivateChat>(ChatType.Private)
					.HasValue<GroupChat>(ChatType.Group);

				b.HasOne(c => c.Owner)
					.WithMany(a => a.Chats)
					.HasForeignKey(c => c.OwnerId)
					.OnDelete(DeleteBehavior.Restrict);
			});

			// Конфигурация для PrivateChat
			modelBuilder.Entity<PrivateChat>(b =>
			{
				b.HasOne(p => p.Participant1)
					.WithMany()
					.HasForeignKey(p => p.Participant1Id)
					.OnDelete(DeleteBehavior.Restrict);

				b.HasOne(p => p.Participant2)
					.WithMany()
					.HasForeignKey(p => p.Participant2Id)
					.OnDelete(DeleteBehavior.Restrict);
			});

			// Конфигурация для участников чата
			modelBuilder.Entity<ChatParticipant>(b =>
			{
				b.HasKey(cp => new { cp.ChatId, cp.UserId });

				b.HasOne(cp => cp.Chat)
					.WithMany(c => c.Participants)
					.HasForeignKey(cp => cp.ChatId)
					.OnDelete(DeleteBehavior.Cascade);

				b.HasOne(cp => cp.User)
					.WithMany()
					.HasForeignKey(cp => cp.UserId)
					.OnDelete(DeleteBehavior.Restrict);
			});

			// Конфигурация для Message
			modelBuilder.Entity<BaseMessage>(b =>
			{
				b.HasDiscriminator<MessageType>(m => m.MessageType)
					.HasValue<TextMessage>(MessageType.Text)
					.HasValue<ImageMessage>(MessageType.Image);

				b.HasOne(m => m.Chat)
					.WithMany(c => c.Messages)
					.HasForeignKey(m => m.ChatId)
					.OnDelete(DeleteBehavior.Cascade);

				b.HasOne(m => m.Sender)
					.WithMany()
					.HasForeignKey(m => m.SenderId)
					.OnDelete(DeleteBehavior.Restrict);
			});
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyAppDb;Trusted_Connection=True;");

#if DEBUG
			if (Debugger.IsAttached)
			{
				options.EnableSensitiveDataLogging();
				this.Database.EnsureCreated();
			}
#endif
		}

		#endregion Protected Methods
	}
}
