using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Audio;

namespace Discord.TestSuite.Models
{
    internal class TestGuild : TestEntity<ulong>, IGuild
    {
        internal IEnumerable<IGuildChannel> AllChannels => TextChannels.Concat<IGuildChannel>(VoiceChannels);
        internal ICollection<IVoiceChannel> VoiceChannels { get; } = new HashSet<IVoiceChannel>(DiscordComparers.ChannelComparer);
        internal ICollection<TestTextChannel> TextChannels { get; } = new HashSet<TestTextChannel>(DiscordComparers.ChannelComparer);
        internal ICollection<TestGuildUser> Users { get; } = new HashSet<TestGuildUser>(DiscordComparers.UserComparer);

        internal TestGuild(TestDiscordClient client, ulong id)
            : base(client, id)
        {
        }

        public string Name { get; internal set; }
        public int AFKTimeout { get; internal set; }
        public bool IsEmbeddable { get; internal set; }
        public VerificationLevel VerificationLevel { get; internal set; }
        public MfaLevel MfaLevel { get; internal set; }
        public DefaultMessageNotifications DefaultMessageNotifications { get; internal set; }

        public IGuildUser Owner { get; internal set; }
        public ulong OwnerId => Owner.Id;
        Task<IGuildUser> IGuild.GetOwnerAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
            => Task.FromResult(Owner);

        public ulong? SystemChannelId { get; internal set; }

        public string IconId => throw new NotImplementedException();
        public string IconUrl => throw new NotImplementedException();
        public string SplashId => throw new NotImplementedException();
        public string SplashUrl => throw new NotImplementedException();
        public bool Available => throw new NotImplementedException();
        public ulong? AFKChannelId => throw new NotImplementedException();
        public ulong DefaultChannelId => throw new NotImplementedException();
        public ulong? EmbedChannelId => throw new NotImplementedException();
        public string VoiceRegionId => throw new NotImplementedException();
        public IAudioClient AudioClient => throw new NotImplementedException();
        public IRole EveryoneRole => throw new NotImplementedException();
        public IReadOnlyCollection<GuildEmote> Emotes => throw new NotImplementedException();
        public IReadOnlyCollection<string> Features => throw new NotImplementedException();
        public IReadOnlyCollection<IRole> Roles => throw new NotImplementedException();
        public DateTimeOffset CreatedAt => throw new NotImplementedException();

        public Task AddBanAsync(IUser user, int pruneDays = 0, string reason = null, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task AddBanAsync(ulong userId, int pruneDays = 0, string reason = null, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IGuildIntegration> CreateIntegrationAsync(ulong id, string type, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IRole> CreateRoleAsync(string name, GuildPermissions? permissions = default(GuildPermissions?), Color? color = default(Color?), bool isHoisted = false, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ITextChannel> CreateTextChannelAsync(string name, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IVoiceChannel> CreateVoiceChannelAsync(string name, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task DownloadUsersAsync()
        {
            return Task.FromResult(0);
        }

        public Task<IVoiceChannel> GetAFKChannelAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<IBan>> GetBansAsync(RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IGuildChannel> GetChannelAsync(ulong id, CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<IGuildChannel>> GetChannelsAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            return Task.FromResult<IReadOnlyCollection<IGuildChannel>>(AllChannels.ToImmutableArray());
        }

        public Task<IGuildUser> GetCurrentUserAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ITextChannel> GetDefaultChannelAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IGuildChannel> GetEmbedChannelAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<IGuildIntegration>> GetIntegrationsAsync(RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<IInviteMetadata>> GetInvitesAsync(RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public IRole GetRole(ulong id)
            => Roles.SingleOrDefault(r => r.Id == id);

        public Task<ITextChannel> GetTextChannelAsync(ulong id, CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<ITextChannel>> GetTextChannelsAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            return Task.FromResult<IReadOnlyCollection<ITextChannel>>(TextChannels.ToImmutableArray());
        }

        public Task<IGuildUser> GetUserAsync(ulong id, CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<IGuildUser>> GetUsersAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            return Task.FromResult<IReadOnlyCollection<IGuildUser>>(Users.ToImmutableArray());
        }

        public Task<IVoiceChannel> GetVoiceChannelAsync(ulong id, CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<IVoiceChannel>> GetVoiceChannelsAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task LeaveAsync(RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task ModifyAsync(Action<GuildProperties> func, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task ModifyEmbedAsync(Action<GuildEmbedProperties> func, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> PruneUsersAsync(int days = 30, bool simulate = false, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task RemoveBanAsync(IUser user, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task RemoveBanAsync(ulong userId, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task ReorderChannelsAsync(IEnumerable<ReorderChannelProperties> args, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task ReorderRolesAsync(IEnumerable<ReorderRoleProperties> args, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<ICategoryChannel>> GetCategoriesAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null) => throw new NotImplementedException();
        public Task<ITextChannel> GetSystemChannelAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null) => throw new NotImplementedException();
        public Task<ICategoryChannel> CreateCategoryAsync(string name, RequestOptions options = null) => throw new NotImplementedException();
        public Task<IWebhook> GetWebhookAsync(ulong id, RequestOptions options = null) => throw new NotImplementedException();
        public Task<IReadOnlyCollection<IWebhook>> GetWebhooksAsync(RequestOptions options = null) => throw new NotImplementedException();
        public Task<GuildEmote> GetEmoteAsync(ulong id, RequestOptions options = null) => throw new NotImplementedException();
        public Task<GuildEmote> CreateEmoteAsync(string name, Image image, Optional<IEnumerable<IRole>> roles = default(Optional<IEnumerable<IRole>>), RequestOptions options = null) => throw new NotImplementedException();
        public Task<GuildEmote> ModifyEmoteAsync(GuildEmote emote, Action<EmoteProperties> func, RequestOptions options = null) => throw new NotImplementedException();
        public Task DeleteEmoteAsync(GuildEmote emote, RequestOptions options = null) => throw new NotImplementedException();
    }
}
