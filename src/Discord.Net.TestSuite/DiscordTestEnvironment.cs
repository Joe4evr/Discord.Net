using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.TestSuite.Models;

namespace Discord.TestSuite
{
    public sealed class DiscordTestEnvironment
    {
        public TestDiscordClient Client { get; }
        public IReadOnlyCollection<IGuild> Guilds => Client.Guilds.ToImmutableArray();

        public DiscordTestEnvironment(uint guilds = 1, uint textChannelsPerGuild = 3, uint usersPerGuild = 5)
        {
            var rng = new Random();

            Client = new TestDiscordClient();

            var gu = new TestGlobalUser(Client, Utils.RandomId(rng))
            {
                Username = "Test Client"
            };
            Client.CurrentUser = new TestSelfUser(gu, Client, gu.Id);

            for (int i = 0; i < guilds; i++)
            {
                var g = new TestGuild(Client, Utils.RandomId(rng))
                {
                    Name = $"Test-Guild-{i}"
                };
                Client.Guilds.Add(g);

                for (int j = 0; j < usersPerGuild; j++)
                {
                    var glob = new TestGlobalUser(Client, Utils.RandomId(rng));
                    var u = new TestGuildUser(glob, g, Client)
                    {
                        Username = $"Test User {j}",
                    };
                    g.Users.Add(u);
                    if (j == 0)
                    {
                        g.Owner = u;
                    }
                }
                g.Users.Add(new TestGuildUser(gu, g, Client));

                for (int j = 0; j < textChannelsPerGuild; j++)
                {
                    var c = new TestTextChannel(g, Client, Utils.RandomId(rng))
                    {
                        Name = $"g{i}-test-channel-{j}"
                    };
                    g.TextChannels.Add(c);
                }
            }
        }

        public ICommandContext CreateContext(IUserMessage message)
            => new TestCommandContext(Client, message);
    }
}
