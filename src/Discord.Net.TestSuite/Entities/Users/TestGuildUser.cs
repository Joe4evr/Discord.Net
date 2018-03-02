using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using System.Collections.Immutable;

namespace Discord.TestSuite.Models
{
    internal class TestGuildUser : TestUser, IGuildUser
    {
#pragma warning disable CS0649
        private long? _joinedAtTicks;
#pragma warning restore CS0649
        private ImmutableArray<ulong> _roleIds = ImmutableArray<ulong>.Empty;

        internal override TestGlobalUser GlobalUser { get; }

        public TestGuild Guild { get; }
        IGuild IGuildUser.Guild => Guild;
        ulong IGuildUser.GuildId => Guild.Id;
        IReadOnlyCollection<ulong> IGuildUser.RoleIds => _roleIds;

        public string Nickname { get; private set; }

        public override bool IsBot { get => GlobalUser.IsBot; internal set => GlobalUser.IsBot = value; }
        public override string Username { get => GlobalUser.Username; internal set => GlobalUser.Username = value; }
        public override ushort DiscriminatorValue { get => GlobalUser.DiscriminatorValue; internal set => GlobalUser.DiscriminatorValue = value; }
        public override string AvatarId { get => GlobalUser.AvatarId; internal set => GlobalUser.AvatarId = value; }

        internal TestGuildUser(TestGlobalUser globalUser, TestGuild guild, TestDiscordClient client)
            : base(client, globalUser.Id)
        {
            GlobalUser = globalUser;
            Guild = guild;
        }

        public DateTimeOffset? JoinedAt => Utils.FromTicks(_joinedAtTicks);

        public GuildPermissions GuildPermissions => throw new NotImplementedException();

        public bool IsSelfDeafened => throw new NotImplementedException(); //VoiceState?.IsSelfDeafened ?? false;
        public bool IsSelfMuted => throw new NotImplementedException(); //VoiceState?.IsSelfMuted ?? false;
        public bool IsSuppressed => throw new NotImplementedException(); //VoiceState?.IsSuppressed ?? false;
        public bool IsDeafened => throw new NotImplementedException(); //VoiceState?.IsDeafened ?? false;
        public bool IsMuted => throw new NotImplementedException(); //VoiceState?.IsMuted ?? false;
        public IVoiceChannel VoiceChannel => throw new NotImplementedException();
        public string VoiceSessionId => throw new NotImplementedException();

        public override bool IsWebhook => false;

        internal override TestPresence Presence { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task AddRoleAsync(IRole role, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task AddRolesAsync(IEnumerable<IRole> roles, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public ChannelPermissions GetPermissions(IGuildChannel channel)
        {
            throw new NotImplementedException();
        }

        public Task KickAsync(string reason = null, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task ModifyAsync(Action<GuildUserProperties> func, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRoleAsync(IRole role, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRolesAsync(IEnumerable<IRole> roles, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }
    }
}
