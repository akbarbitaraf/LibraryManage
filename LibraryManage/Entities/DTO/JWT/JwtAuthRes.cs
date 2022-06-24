namespace LibraryManage.Entities.DTO.JWT
{
    public class JwtAuthRes
    {
        public string access_token { get; set; }
        public RefreshToken refresh_token { get; set; }
    }
}
