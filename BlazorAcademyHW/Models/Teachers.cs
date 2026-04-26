using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    public class Teachers
    {
        [Key] public short teacher_id { get; set; }

        public string? last_name { get; set; }

        public string? first_name { get; set; }

        public string? middle_name { get; set; }

        public DateOnly? birth_date { get; set; }

        public DateOnly? work_since { get; set; }

        public decimal? rate { get; set; }
    }
}
