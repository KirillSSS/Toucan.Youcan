using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Toucan.Youcan.Data.Entities
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? code { get; set; }
        [Required]
        public string name { get; set; }
        public int? dad_id { get; set; }
        public int? owner_id { get; set; }
    }
}
