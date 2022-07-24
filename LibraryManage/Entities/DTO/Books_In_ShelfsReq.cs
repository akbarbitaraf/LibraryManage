namespace LibraryManage.Entities.DTO
{
    public class Books_In_ShelfsReq
    {
        public int BookID { get; set; }
        public int ShelfID { get; set; }
        public int Bookstatus_ID { get; set; }
        public string ISBN { get; set; }


    }
}
