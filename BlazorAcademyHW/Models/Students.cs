using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    public class Students
    {
        
       [Key] public int stud_id { get; set; }

        [Display(Name = "Фамилия")] 
        public string? last_name { get; set; }

        [Display(Name = "Имя")]
        public string? first_name { get; set; }

        [Display(Name = "Отчество")]
        public string? middle_name { get; set; }

        [Display(Name = "Дата рождения")]
        public DateOnly? birth_date { get; set; }

        [Display(Name = "Группа")]
        public int group { get; set; }

    }
}
