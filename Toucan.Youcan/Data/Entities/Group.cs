using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Toucan.Youcan.Data.Entities
{
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public int id_category { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public int type { get; set; }
        [Required]
        public DateOnly date_start { get; set; }
        [Required]
        public DateOnly date_end { get; set; }
        public int? period { get; set; }
        [Required]
        public bool repeat { get; set; }
        [Required]
        public TimeOnly time_start { get; set; }
        [Required]
        public TimeOnly time_end { get; set; }
    }
}
