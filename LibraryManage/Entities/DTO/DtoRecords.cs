namespace LibraryManage.Entities.DTO
{
    public record MemberLoginReq(string UserName, string Password);
    public record MemberLoginRes(string MemberId, string MemberName, string Access_token);
}