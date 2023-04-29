using ArtSofteEmployees.Models;

namespace ArtSofteEmployees.Data
{
    public class DbInitializer
    {
        public static void Initialize(EmployeeContext context)
        {
            context.Database.EnsureCreated();
            if (context.Departments.Any())
            {
                return;
            }
            var departments = new Department[]
            {
               new Department{NameDepartment = "Отдел 1", Floor=2},
               new Department{NameDepartment = "Отдел 2", Floor=3},
               new Department{NameDepartment = "Отдел 3", Floor=4}
            };
            foreach (Department d in departments)
            {
                context.Departments.Add(d);
            }
            context.SaveChanges();

            var programmingLanguages = new ProgrammingLanguage[]
           {
              new ProgrammingLanguage{LanguageName="C#" },
              new ProgrammingLanguage{LanguageName="C++" },
              new ProgrammingLanguage{LanguageName="Python" },
              new ProgrammingLanguage{LanguageName="JavaScript" },
              new ProgrammingLanguage{LanguageName="PHP" },
           };
            foreach (ProgrammingLanguage p in programmingLanguages)
            {
                context.ProgrammingLanguages.Add(p);
            }
            context.SaveChanges();
        }
    }
}
