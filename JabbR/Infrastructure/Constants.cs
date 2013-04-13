﻿using System;
namespace JabbR.Infrastructure
{
    public static class Constants
    {
        public static readonly string UserTokenCookie = "jabbr.userToken";
        public static readonly Version JabbRVersion = typeof(Constants).Assembly.GetName().Version;
        public static readonly string JabbRAuthType = "JabbR";
    }

    public static class JabbRClaimTypes
    {
        public static readonly string Identifier = "urn:jabbr:id";
    }
}