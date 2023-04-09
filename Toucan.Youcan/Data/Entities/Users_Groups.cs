using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Toucan.Youcan.Data.Entities
{
    [PrimaryKey(nameof(id_user), nameof(id_group))]
    public class Users_Groups
    {
        public int id_user { get; set; }
        public int id_group { get; set;}
    }
}
