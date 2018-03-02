using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord.TestSuite
{
    public interface IOverrrideReply
    {
        Task<IUserMessage> ReplyAsync(string text, bool isTTS = false, Embed embed = null, RequestOptions options = null);
    }
}
