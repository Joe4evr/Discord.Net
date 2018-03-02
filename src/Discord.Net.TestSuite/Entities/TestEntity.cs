using System;

namespace Discord.TestSuite.Models
{
    internal abstract class TestEntity<TId> : IEntity<TId>
        where TId : IEquatable<TId>
    {
        internal TestDiscordClient Client { get; }
        public TId Id { get; }

        public TestEntity(TestDiscordClient client, TId id)
        {
            Client = client;
            Id = id;
        }
    }
}
