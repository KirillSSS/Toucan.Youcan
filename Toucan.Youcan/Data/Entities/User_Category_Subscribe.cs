using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace Toucan.Youcan.Data.Entities
{
    [PrimaryKey(nameof(id_user), nameof(id_category))]
    public class User_Category_Subscribe
    {
        public int id_category { get; set; }
        public int id_user { get; set; }
    }
}
