﻿using System;
using Events.ValueObjects;

namespace Events
{
    public class UpdatedUserEvent : BaseUserEvent
    {
        protected UpdatedUserEvent(UserInformation userInfo, string userName, DateTime eventDate, string source, 
                                   string version) : base(userName, eventDate, source, version)
        {
            UserInformation = userInfo;
        }

        public UserInformation UserInformation { get; }
    }
}
