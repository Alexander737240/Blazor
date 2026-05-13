using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    public class StudyDay
    {
        [Key]
        public int day_id { get; set; }
        public string? day_name { get; set; } 
        public string? day_short { get; set; } 
        public int day_order { get; set; } 
    }
}