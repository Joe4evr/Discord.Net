using System;
using System.Collections.Generic;
using System.Text;

namespace Discord.TestSuite.Models
{
    internal class TestPresence : IPresence
    {
        public UserStatus Status { get; }
        public IActivity Activity { get; }

        internal TestPresence(UserStatus status, IActivity activity)
        {
            Status = status;
            Activity = activity;
        }

        //internal static TestPresence Create(Model model)
        //{
        //    return new TestPresence(model.Status, model.Game != null ? model.Game.ToEntity() : (Game?)null);
        //}

        public override string ToString() => Status.ToString();
        //private string DebuggerDisplay => $"{Status}{(Game != null ? $", {Game.Value.Name} ({Game.Value.StreamType})" : "")}";
    }
}
