# Client Basics Questions

## My client keeps returning 401 upon logging in!

  There are few possible reasons why this may occur.
   1. You are not using the appropriate `TokenType`. If you are using a bot account created from the Discord Developer portal, you should be using `TokenType.Bot`. 
   2. You are not using the correct login credentials. Please keep in mind that tokens start with `Mj*`. If it starts with any other characters, chances are, you are using the *client secret*, which has nothing to do with the login token.

## How do I do X, Y, Z when my bot connects/logs on? Why do I get a `NullReferenceException` upon calling any client methods after connect?

   Your bot should not attempt to interact in any way with guilds/servers until the `Ready` event fires. When the bot connects, it first has to download guild information from Discord in order for you to get access to any server information; the client is not ready at this point. Technically, the `GuildAvailable` event fires once the data for a particular guild has downloaded; however, it's best to wait for all guilds to be downloaded. Once all downloads are complete, the `Ready` event is triggered, then you can proceed to do whatever you like.

## How do I get a message's previous content when that message is edited?

   If you need to do anything with messages (e.g. checking Reactions, checking the content of edited/deleted messages), you must set the `MessageCacheSize` in your `DiscordSocketConfig` settings in order to use the cached message entity. Read more about it [here](https://discord.foxbot.me/docs/guides/concepts/events.html#cacheable).
   1. Message Cache must be enabled.
   2. Hook the `MessageUpdated` event. This event provides a *before* and *after* object.
   3. Only messages received *AFTER* the bot comes online will be available in the cache.