using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace Discord.TestSuite.Models
{
    public sealed class TestDiscordClient : IDiscordClient
    {
        internal ICollection<TestGuild> Guilds { get; } = new HashSet<TestGuild>(DiscordComparers.GuildComparer);

        public ConnectionState ConnectionState { get; internal set; }

        public ISelfUser CurrentUser { get; internal set; }

        public TokenType TokenType => TokenType.Bot;

        public Task<IGuild> CreateGuildAsync(string name, IVoiceRegion region, Stream jpegIcon = null, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IApplication> GetApplicationInfoAsync(RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IChannel> GetChannelAsync(ulong id, CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            return Task.FromResult(Guilds.SelectMany(g => g.AllChannels)
                .SingleOrDefault<IChannel>(ch => ch.Id == id));
        }

        public Task<IReadOnlyCollection<IConnection>> GetConnectionsAsync(RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<IDMChannel>> GetDMChannelsAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<IGroupChannel>> GetGroupChannelsAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IGuild> GetGuildAsync(ulong id, CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            return Task.FromResult(Guilds.SingleOrDefault<IGuild>(g => g.Id == id));
        }

        public Task<IReadOnlyCollection<IGuild>> GetGuildsAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IInvite> GetInviteAsync(string inviteId, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<IPrivateChannel>> GetPrivateChannelsAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IUser> GetUserAsync(ulong id, CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IUser> GetUserAsync(string username, string discriminator, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IVoiceRegion> GetVoiceRegionAsync(string id, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<IVoiceRegion>> GetVoiceRegionsAsync(RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IWebhook> GetWebhookAsync(ulong id, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task StartAsync()
        {
            throw new NotImplementedException();
        }

        public Task StopAsync()
        {
            throw new NotImplementedException();
        }

        // needed to fire MessageReceived with a specified user
        public async Task<TestResult> TriggerMsgReceived(IMessageChannel channel, string text, IUser sender = null)
        {
            var message = (await channel.SendMessageAsync(text)) as TestUserMessage;
            message.Author = sender ?? CurrentUser;

            var (ctx, result) = await MessageReceived(message);
            return TestResult.FromCommandResult(ctx as TestCommandContext, result);
        }

        public event Func<IMessage, Task<(ICommandContext, IResult)>> MessageReceived;

        #region IDisposable Support
        private bool _disposedValue = false; // To detect redundant calls

        private void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                _disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~TestDiscordClient() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
