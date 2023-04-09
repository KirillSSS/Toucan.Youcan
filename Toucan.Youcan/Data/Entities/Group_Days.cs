using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Toucan.Youcan.Data.Entities
{
    public class Group_Days
    {
        [Required]
        public int id_day { get; set; }
        [Key]
        public int id_group { get; set; }
    }
}
