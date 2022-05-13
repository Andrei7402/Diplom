using System.ComponentModel.DataAnnotations;

namespace Menu.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}