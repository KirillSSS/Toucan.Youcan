using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Toucan.Youcan.Data.Entities
{
    [PrimaryKey(nameof(id_user), nameof(id_category))]
    public class Admins
    {
        public int id_user { get; set; }
        public int id_category { get; set; }
    }
}
