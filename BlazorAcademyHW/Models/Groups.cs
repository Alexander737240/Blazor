using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    public class Groups
    {
       [Key] public int group_id { get; set; }

        public string? group_name { get; set; }

        public byte ? direction { get; set; }
    }
}
