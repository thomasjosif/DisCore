﻿using System;
using DisCore.Core.Permissions;

namespace DisCore.Core.Commands.Timeouts
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TimeoutAttribute : Attribute
    {
        public readonly PermissionLevels BypassLevel;

        public TimeoutAttribute(PermissionLevels bypassLevel = PermissionLevels.Moderator)
        {
            BypassLevel = bypassLevel;
        }
    }
}
