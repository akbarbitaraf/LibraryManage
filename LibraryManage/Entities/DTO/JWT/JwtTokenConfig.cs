namespace LibraryManage.Entities.DTO.JWT
{
    public class JwtTokenConfig
    {
        public string secret { get; set; }
        public string issuer { get; set; }
        public string audience { get; set; }
        public int access_token_expiration { get; set; }
        public int refresh_token_expiration { get; set; }
    }
}
