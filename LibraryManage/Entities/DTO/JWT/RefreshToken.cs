namespace LibraryManage.Entities.DTO.JWT
{
    public class RefreshToken
    {
        public string user_name { get; set; }
        public string token_string { get; set; }
        public DateTime expire_at { get; set; }
    }
}
