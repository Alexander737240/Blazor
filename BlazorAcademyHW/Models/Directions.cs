using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    public class Directions
    {
        [Key] public byte direction_id { get; set; }

        public string? direction_name { get; set; }

    }
}
