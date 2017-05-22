﻿using System;
using System.Diagnostics;

namespace Octokit.GraphQL.Core.IntegrationTests
{
    public static class Helper
    {
        public static string Username => Environment.GetEnvironmentVariable("OCTOKIT_GQL_GITHUBUSERNAME");

        public static string OAuthToken => Environment.GetEnvironmentVariable("OCTOKIT_GQL_OAUTHTOKEN");

        public static bool HasCredentials => !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(OAuthToken);
    }
}
