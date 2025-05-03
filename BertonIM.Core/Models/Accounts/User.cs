namespace BertonIM.Core.Models.Accounts
{
    using BertonIM.Core.Models.Base;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class User : BaseAccount
    {
        public string Username { get; set; } = string.Empty;

        public string AvatarUrl { get; set; } = string.Empty;
    }
}
