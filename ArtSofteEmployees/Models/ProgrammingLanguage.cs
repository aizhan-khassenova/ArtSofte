using System.ComponentModel.DataAnnotations;

namespace ArtSofteEmployees.Models
{
    public class ProgrammingLanguage
    {
        public int ProgrammingLanguageId { get; set; }

        [Required(ErrorMessage ="Напишите язык программирования")]
        [Display(Name ="Язык программирования")]
        [MaxLength(50)]
        [MinLength(1)]
        public string LanguageName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}