using ArtSofteEmployees.Models;
using System.ComponentModel.DataAnnotations;

namespace ArtSofteEmployees.ViewModels
{
    public class DisplayEmployeeViewModel
    {
        public int Id { get; set; }
        [Display(Name="Имя")]
        public string Name { get; set; }
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        [Display(Name = "Возраст")]
        public int Age { get; set; }
        [Display(Name = "Пол")]
        public string Gender { get; set; }
        [Display(Name = "Отдел")]
        public string NameDepartment { get; set; }
        [Display(Name = "Я/П")]
        public string NameProgrammingLanguage { get; set; }
    }
}
