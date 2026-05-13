using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyHW.Models
{
    public class GroupsDay
    {
        [Key]
        public int groups_day_id { get; set; }

        public int group_id { get; set; }
        [ForeignKey("group_id")]
        public Groups? Group { get; set; }

        public int day_id { get; set; }
        [ForeignKey("day_id")]
        public StudyDay? StudyDay { get; set; }
    }
}