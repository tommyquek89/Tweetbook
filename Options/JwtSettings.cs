﻿using System;

namespace Tweetbook.Options
{
    public class JwtSettings
    {
        public string Secret { get; set; }

        public TimeSpan TokenLifeTime { get; set; }
    }
}
