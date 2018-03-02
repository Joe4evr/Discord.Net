using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord.TestSuite.Models
{
    internal class TestSelfUser : TestUser, ISelfUser
    {
        public string Email { get; private set; }
        public bool IsVerified { get; private set; }
        public bool IsMfaEnabled { get; private set; }
        internal override TestGlobalUser GlobalUser { get; }

        internal TestSelfUser(TestGlobalUser globalUser, TestDiscordClient client, ulong id)
            : base(client, id)
        {
            GlobalUser = globalUser;
        }

        public override bool IsBot { get => GlobalUser.IsBot; internal set => GlobalUser.IsBot = value; }
        public override string Username { get => GlobalUser.Username; internal set => GlobalUser.Username = value; }
        public override ushort DiscriminatorValue { get => GlobalUser.DiscriminatorValue; internal set => GlobalUser.DiscriminatorValue = value; }
        public override string AvatarId { get => GlobalUser.AvatarId; internal set => GlobalUser.AvatarId = value; }
        internal override TestPresence Presence { get => GlobalUser.Presence; set => GlobalUser.Presence = value; }
        public override bool IsWebhook => false;

        public Task ModifyAsync(Action<SelfUserProperties> func, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }
    }
}
