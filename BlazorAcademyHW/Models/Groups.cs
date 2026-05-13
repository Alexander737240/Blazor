using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyHW.Models
{

    public class Groups
    {
       [Key] public int group_id { get; set; }

        public string? group_name { get; set; }

        public byte ? direction { get; set; }
        //public Disciplines Discipline { get; set; }  // Навигационное свойств
    }
}

