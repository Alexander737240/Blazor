using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    public class Disciplines
    {
        [Key] public short discipline_id { get; set; }
        public string? discipline_name { get; set; }
        public byte number_of_lessons { get; set; }
    }
}
