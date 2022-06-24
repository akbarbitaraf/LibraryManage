using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using LibraryManage.Contract.IServices;
using LibraryManage.Entities.DTO.JWT;
using Microsoft.IdentityModel.Tokens;

namespace LibraryManage.Services
{
    public class JwtAuthManager : IJwtAuthManager
    {
        //public IImmutableDictionary<string, RefreshToken> UsersRefreshTokensReadOnlyDictionary => _usersRefreshTokens.ToImmutableDictionary();
        private readonly ConcurrentDictionary<string, RefreshToken> _usersRefreshTokens;  // can store in a database or a distributed cache
        private readonly JwtTokenConfig _jwtTokenConfig;
        private readonly byte[] _secret;
        public JwtAuthManager(JwtTokenConfig jwtTokenConfig)
        {
            _jwtTokenConfig = jwtTokenConfig;
            _usersRefreshTokens = new ConcurrentDictionary<string, RefreshToken>();
            _secret = Encoding.ASCII.GetBytes(jwtTokenConfig.secret);
        }
        public JwtAuthRes GenerateTokens(string user_name, Claim[] claims, DateTime now)
        {
            var shouldAddAudienceClaim = string.IsNullOrWhiteSpace(claims?.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Aud)?.Value);
            var jwtToken = new JwtSecurityToken(
                _jwtTokenConfig.issuer,
                shouldAddAudienceClaim ? _jwtTokenConfig.audience : string.Empty,
                claims,
                expires: now.AddDays(_jwtTokenConfig.access_token_expiration),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(_secret), SecurityAlgorithms.HmacSha256Signature));
            var accessToken = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            var refreshToken = new RefreshToken
            {
                user_name = user_name,
                token_string = GenerateRefreshTokenString(),
                expire_at = now.AddDays(_jwtTokenConfig.refresh_token_expiration)
            };
            _usersRefreshTokens.AddOrUpdate(refreshToken.token_string, refreshToken, (s, t) => refreshToken);

            return new JwtAuthRes
            {
                access_token = accessToken,
                refresh_token = refreshToken
            };
        }

        private static string GenerateRefreshTokenString()
        {
            var randomNumber = new byte[32];
            using var randomNumberGenerator = RandomNumberGenerator.Create();
            randomNumberGenerator.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }
    }
}
