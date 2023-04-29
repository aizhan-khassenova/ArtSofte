using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace ArtSofteEmployees.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        [Display(Name = "Название отдела")]
        public string NameDepartment { get; set; }
        [Required]
        [Range(0, 42, ErrorMessage = "Этаж должен быть между 0 и 42")]
        [Display(Name = "Номер этажа")]
        public int Floor { get; set; }
        public virtual ICollection<Employee>? Employees { get; set; } = new HashSet<Employee>();
    }
}