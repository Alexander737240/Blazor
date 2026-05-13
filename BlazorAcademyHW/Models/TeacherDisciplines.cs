using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyHW.Models
{
    public class TeacherDiscipline
    {
        [Key]
        public int teacher_discipline_id { get; set; }

        public short teacher_id { get; set; }
        [ForeignKey("teacher_id")]
        public Teachers? Teacher { get; set; }

        public short discipline_id { get; set; }
        [ForeignKey("discipline_id")]
        public Disciplines? Discipline { get; set; }
    }
}