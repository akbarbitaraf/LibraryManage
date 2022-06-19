namespace LibraryManage.Entities.DTO
{
    public class MemberLoginRes
    {
        public MemberLoginRes()
        {

        }
        public long memberId { get; set; }
        public string accessToken { get; set; }
        public string userName { get; set; }

    }
}
