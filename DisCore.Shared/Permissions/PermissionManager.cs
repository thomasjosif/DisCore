﻿using System;
using DisCore.Shared.Commands;
using DSharpPlus.Entities;

namespace DisCore.Shared.Permissions
{
    public class PermissionHandler : IPermissionHandler
    {
        public PermissionLevels GetPermissionLevel(DiscordMember member, DiscordGuild guild)
        {
            throw new NotImplementedException();
        }

        public PermissionLevels GetPermissionLevel(DiscordUser user)
        {
            throw new NotImplementedException();
        }

        public PermissionLevels GetPermissionOverrides(ICommand cmd, DiscordMember member, DiscordGuild guild)
        {
            throw new NotImplementedException();
        }

        public bool CanDoAction(ICommand cmd, DiscordMember member, DiscordGuild guild)
        {
            throw new NotImplementedException();
        }

        public bool CanDoAction(ICommand cmd, DiscordUser user)
        {
            throw new NotImplementedException();
        }
    }
}
