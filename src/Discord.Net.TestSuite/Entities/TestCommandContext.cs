using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace Discord.TestSuite
{
    internal sealed class TestCommandContext : ICommandContext, IOverrrideReply
    {
        public IDiscordClient Client { get; }
        public IGuild Guild { get; }
        public IMessageChannel Channel { get; }
        public IUser User { get; }
        public IUserMessage Message { get; }

        public IUserMessage Reply { get; private set; }

        public TestCommandContext(IDiscordClient client, IUserMessage msg)
        {
            Client = client;
            Message = msg;
            User = msg.Author;
            Channel = msg.Channel;
            Guild = (msg.Channel as IGuildChannel)?.Guild;
        }

        async Task<IUserMessage> IOverrrideReply.ReplyAsync(string text, bool isTTS, Embed embed, RequestOptions options)
        {
            return (Reply = await Channel.SendMessageAsync(text, isTTS, embed, options));
        }
    }
}
