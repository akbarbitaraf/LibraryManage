namespace LibraryManage.Entities.DTO
{
    public class BooksReq
    {
        public string Title { get; set; }
        public int? Bookstatus_ID { get; set; }
        public int? Author_ID { get; set; }
        public int? Publisher_ID { get; set; }
        public int? CurrentStock { get; set; }


    }
}
