using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Toucan.Youcan.Data.Entities
{
    public class Repeat_first_day
    {
        [Key]
        public int id_group { get; set; }
        [Required]
        public int id_day { get; set; }
        [Required]
        public int number { get; set; }
    }
}
