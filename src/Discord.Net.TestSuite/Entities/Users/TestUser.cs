using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;

namespace Discord.TestSuite.Models
{
    internal abstract class TestUser : TestEntity<ulong>, IUser
    {
        public abstract bool IsBot { get; internal set; }
        public abstract string Username { get; internal set; }
        public abstract ushort DiscriminatorValue { get; internal set; }
        public abstract string AvatarId { get; internal set; }
        public abstract bool IsWebhook { get; }
        internal abstract TestGlobalUser GlobalUser { get; }
        internal abstract TestPresence Presence { get; set; }

        public DateTimeOffset CreatedAt => SnowflakeUtils.FromSnowflake(Id);
        public string Discriminator => DiscriminatorValue.ToString("D4");
        public string Mention => MentionUtils.MentionUser(Id);
        public UserStatus Status => Presence.Status;
        public IActivity Activity => Presence.Activity;

        internal TestUser(TestDiscordClient client, ulong id)
            : base(client, id)
        {
        }

        public string GetAvatarUrl(ImageFormat format = ImageFormat.Auto, ushort size = 128)
        {
            throw new NotImplementedException();
        }

        public Task<IDMChannel> GetOrCreateDMChannelAsync(RequestOptions options = null)
        {
            return Task.FromResult<IDMChannel>(new TestDMChannel(Client, Utils.RandomId(new Random()), this));
        }
    }
}
