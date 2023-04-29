using System.ComponentModel.DataAnnotations;

namespace ArtSofteEmployees.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Не указано имя сотрудника")]
        [MinLength(2)]
        [MaxLength(30)]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указана фамилия сотрудника")]
        [MinLength(2)]
        [MaxLength(30)]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Не указан возраст")]
        [Range(18, 100, ErrorMessage ="Недопустимый возраст")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Не указан пол")]
        [RegularExpression(@"(?i)(\W|^)(М|Ж)$", ErrorMessage = "Написать М или Ж")]
        [Display(Name = "Пол")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Отдел не выбран")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Язык программирования не выбран")]
        public int ProgrammingLanguageId { get; set; }
       
        [Display(Name = "Отдел")]
        public virtual Department? Department { get; set; }
       
        [Display(Name = "Я/П")]
        public virtual ProgrammingLanguage? ProgrammingLanguage { get; set; } 
    }
}
