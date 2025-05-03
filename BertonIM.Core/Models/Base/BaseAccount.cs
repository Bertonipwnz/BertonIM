namespace BertonIM.Core.Models.Base
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class BaseAccount
    {
        public long Id { get; set; }

        public string Email { get; set; } = string.Empty;
    }
}
