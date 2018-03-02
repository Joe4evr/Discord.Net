using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;

namespace Discord.TestSuite.Models
{
    internal class TestUserMessage : TestMessage, IUserMessage
    {
        internal TestUserMessage(TestDiscordClient client, ulong id)
            : base(client, id)
        {
        }

        public IReadOnlyDictionary<IEmote, ReactionMetadata> Reactions => throw new NotImplementedException();

        public Task AddReactionAsync(IEmote emote, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<IUser>> GetReactionUsersAsync(string emoji, int limit = 100, ulong? afterUserId = null, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<IUser>> GetReactionUsersAsync(IEmote emoji, int limit = 100, ulong? afterUserId = null, RequestOptions options = null) => throw new NotImplementedException();

        public Task ModifyAsync(Action<MessageProperties> func, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task PinAsync(RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAllReactionsAsync(RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task RemoveReactionAsync(IEmote emote, IUser user, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public string Resolve(TagHandling userHandling = TagHandling.Name, TagHandling channelHandling = TagHandling.Name, TagHandling roleHandling = TagHandling.Name, TagHandling everyoneHandling = TagHandling.Ignore, TagHandling emojiHandling = TagHandling.Name)
        {
            throw new NotImplementedException();
        }

        public Task UnpinAsync(RequestOptions options = null)
        {
            throw new NotImplementedException();
        }
    }
}
