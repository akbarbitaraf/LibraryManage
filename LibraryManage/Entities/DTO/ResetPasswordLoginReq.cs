namespace LibraryManage.Entities.DTO
{
    public class ResetPasswordLoginReq
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
