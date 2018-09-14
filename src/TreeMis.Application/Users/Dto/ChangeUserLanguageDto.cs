using System.ComponentModel.DataAnnotations;

namespace TreeMis.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}