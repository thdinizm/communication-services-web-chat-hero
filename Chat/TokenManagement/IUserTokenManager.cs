﻿// © Microsoft Corporation. All rights reserved.

using System.Threading.Tasks;

namespace Chat
{
	public interface IUserTokenManager
    {
        Task<(string userMri, string skypeToken, long expiresDateUtc)> GenerateTokenAsync(string resourceConnectionString);
        Task<(string userMri, string skypeToken, long expiresDateUtc)> RefreshTokenAsync(string resourceConnectionString, string expiredToken);
    }
}
