using System.Security.Claims;
using LibraryManage.Entities.DTO.JWT;

namespace LibraryManage.Contract.IServices
{
    public interface IJwtAuthManager
    {
        JwtAuthRes GenerateTokens(string user_name, Claim[] claims, DateTime now);

    }
}
