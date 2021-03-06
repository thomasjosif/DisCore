﻿using System.Threading.Tasks;
using DSharpPlus.Entities;

namespace DisCore.Shared.Config
{
    public interface IConfigManager
    {
        Task<IConfig> GetUserConfig(DiscordUser user);

        Task<IConfig> GetChannelConfig(DiscordChannel channel);

        Task<IConfig> GetGuildConfig(DiscordGuild guild);

        Task<IConfig> GetGlobalConfig();

    }
}
