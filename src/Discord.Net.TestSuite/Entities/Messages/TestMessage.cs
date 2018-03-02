using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord.TestSuite.Models
{
    internal abstract class TestMessage : TestEntity<ulong>, IMessage
    {
        internal TestMessage(TestDiscordClient client, ulong id)
            : base(client, id)
        {
        }

        public MessageType Type { get; internal set; } = MessageType.Default;

        public MessageSource Source { get; internal set; } = MessageSource.User;

        public bool IsTTS { get; internal set; } = false;

        public bool IsPinned { get; internal set; } = false;

        public string Content { get; internal set; }

        public DateTimeOffset Timestamp => SnowflakeUtils.FromSnowflake(Id);

        public DateTimeOffset? EditedTimestamp { get; internal set; }

        public IMessageChannel Channel { get; internal set; }

        public IUser Author { get; internal set; }

        public IReadOnlyCollection<IAttachment> Attachments { get; internal set; } = Array.Empty<IAttachment>();

        public IReadOnlyCollection<IEmbed> Embeds { get; internal set; } = Array.Empty<IEmbed>();

        public IReadOnlyCollection<ITag> Tags { get; internal set; } = Array.Empty<ITag>();

        public IReadOnlyCollection<ulong> MentionedChannelIds { get; internal set; } = Array.Empty<ulong>();

        public IReadOnlyCollection<ulong> MentionedRoleIds { get; internal set; } = Array.Empty<ulong>();

        public IReadOnlyCollection<ulong> MentionedUserIds { get; internal set; } = Array.Empty<ulong>();

        public DateTimeOffset CreatedAt => SnowflakeUtils.FromSnowflake(Id);

        public Task DeleteAsync(RequestOptions options = null)
        {
            throw new NotImplementedException();
        }
    }
}
