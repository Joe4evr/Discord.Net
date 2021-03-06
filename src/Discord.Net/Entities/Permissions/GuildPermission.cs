﻿namespace Discord
{
    public enum GuildPermission : byte
    {
        //General
        CreateInstantInvite = 0,
        KickMembers = 1,
        BanMembers = 2,
        Administrator = 3,
        ManageChannels = 4,
        ManageGuild = 5,

        //Text
        ReadMessages = 10,
        SendMessages = 11,
        SendTTSMessages = 12,
        ManageMessages = 13,
        EmbedLinks = 14,
        AttachFiles = 15,
        ReadMessageHistory = 16,
        MentionEveryone = 17,

        //Voice
        Connect = 20,
        Speak = 21,
        MuteMembers = 22,
        DeafenMembers = 23,
        MoveMembers = 24,
        UseVAD = 25,

        //Nicknames
        ChangeNickname = 26,
        ManageNicknames = 27,
        ManageRoles = 28,
    }
}
