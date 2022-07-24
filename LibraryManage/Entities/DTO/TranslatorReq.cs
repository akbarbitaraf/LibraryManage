using System.ComponentModel.DataAnnotations;

namespace LibraryManage.Entities.DTO
{
    public class TranslatorReq
    {
        public int? Translator_ID { get; set; }
        [Required(ErrorMessage = "FirstName_Empty")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName_Empty")]
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public bool Gender { get; set; }

    }
}
