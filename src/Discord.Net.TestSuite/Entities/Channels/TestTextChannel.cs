using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Discord;

namespace Discord.TestSuite.Models
{
    internal class TestTextChannel : TestMessageChannel, ITextChannel
    {
        public string Topic { get; internal set; }

        public string Mention => throw new NotImplementedException();

        public int Position => throw new NotImplementedException();

        public IGuild Guild { get; }
        ulong IGuildChannel.GuildId => Guild.Id;

        public IReadOnlyCollection<Overwrite> PermissionOverwrites => throw new NotImplementedException();

        public ulong? CategoryId { get; internal set; }

        internal TestTextChannel(TestGuild guild, TestDiscordClient client, ulong id)
            : base(client, id)
        {
            Guild = guild;
        }

        public Task AddPermissionOverwriteAsync(IRole role, OverwritePermissions permissions, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task AddPermissionOverwriteAsync(IUser user, OverwritePermissions permissions, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IInviteMetadata> CreateInviteAsync(int? maxAge = 1800, int? maxUses = default(int?), bool isTemporary = false, bool isUnique = false, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<IInviteMetadata>> GetInvitesAsync(RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public OverwritePermissions? GetPermissionOverwrite(IRole role)
        {
            throw new NotImplementedException();
        }

        public OverwritePermissions? GetPermissionOverwrite(IUser user)
        {
            throw new NotImplementedException();
        }

        public Task ModifyAsync(Action<TextChannelProperties> func, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task ModifyAsync(Action<GuildChannelProperties> func, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task RemovePermissionOverwriteAsync(IRole role, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task RemovePermissionOverwriteAsync(IUser user, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        Task<IGuildUser> IGuildChannel.GetUserAsync(ulong id, CacheMode mode, RequestOptions options)
        {
            throw new NotImplementedException();
        }

        IAsyncEnumerable<IReadOnlyCollection<IGuildUser>> IGuildChannel.GetUsersAsync(CacheMode mode, RequestOptions options)
        {
            throw new NotImplementedException();
        }

        public Task<IWebhook> CreateWebhookAsync(string name, Stream avatar = null, RequestOptions options = null) => throw new NotImplementedException();
        public Task<IWebhook> GetWebhookAsync(ulong id, RequestOptions options = null) => throw new NotImplementedException();
        public Task<IReadOnlyCollection<IWebhook>> GetWebhooksAsync(RequestOptions options = null) => throw new NotImplementedException();
        public Task<ICategoryChannel> GetCategoryAsync() => throw new NotImplementedException();
    }
}
