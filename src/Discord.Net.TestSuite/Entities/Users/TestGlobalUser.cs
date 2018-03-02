using System;
using System.Collections.Generic;
using System.Text;

namespace Discord.TestSuite.Models
{
    internal class TestGlobalUser : TestUser
    {
        public override bool IsBot { get; internal set; }
        public override string Username { get; internal set; }
        public override ushort DiscriminatorValue { get; internal set; }
        public override string AvatarId { get; internal set; }

        public override bool IsWebhook => false;
        internal override TestGlobalUser GlobalUser => this;
        internal override TestPresence Presence { get; set; }

        internal TestGlobalUser(TestDiscordClient client, ulong id)
            : base(client, id)
        {
        }
    }
}
