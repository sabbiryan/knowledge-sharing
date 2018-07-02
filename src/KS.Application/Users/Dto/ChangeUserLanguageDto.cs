using System.ComponentModel.DataAnnotations;

namespace KS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}