using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Toucan.Youcan.Data.Entities
{
    public class Once_Year_Number_Month
    {
        [Required]
        public int id_month { get; set; }
        [Key]
        public int id_group { get; set; }
        [Required]
        public int number { get; set; }
    }
}
