using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;

namespace Discord.TestSuite.Models
{
    internal abstract class TestChannel : TestEntity<ulong>, IChannel
    {
        internal TestChannel(TestDiscordClient client, ulong id)
            : base(client, id)
        {
        }

        public string Name { get; internal set; }

        public bool IsNsfw => throw new NotImplementedException();

        public DateTimeOffset CreatedAt => SnowflakeUtils.FromSnowflake(Id);

        public Task<IUser> GetUserAsync(ulong id, CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<IReadOnlyCollection<IUser>> GetUsersAsync(CacheMode mode = CacheMode.AllowDownload, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }
    }
}
