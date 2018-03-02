using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Discord.TestSuite.Models
{
    internal class TestDMChannel : TestMessageChannel, IDMChannel
    {
        public IUser Recipient { get; }

        internal TestDMChannel(TestDiscordClient client, ulong id, IUser recipient)
            : base (client, id)
        {
            Recipient = recipient;
        }

        public IReadOnlyCollection<IUser> Recipients => throw new NotImplementedException();

        public Task CloseAsync(RequestOptions options = null)
        {
            throw new NotImplementedException();
        }
    }
}
