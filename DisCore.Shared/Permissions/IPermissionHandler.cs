﻿using DisCore.Shared.Commands;
using DSharpPlus.Entities;

namespace DisCore.Shared.Permissions
{
    public interface IPermissionHandler
    {

        PermissionLevels GetPermissionLevel(DiscordMember member, DiscordGuild guild);
        PermissionLevels GetPermissionLevel(DiscordUser user);

        PermissionLevels GetPermissionOverrides(ICommand cmd, DiscordMember member, DiscordGuild guild);

        bool CanDoAction(ICommand cmd, DiscordMember member, DiscordGuild guild);
        bool CanDoAction(ICommand cmd, DiscordUser user);
    }
}
