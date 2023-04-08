using Toucan.Youcan.Models.Abstractions;

namespace Toucan.Youcan.Models
{
    public class Category : BaseEntity
    {
        public string? Description { get; set; } = null;

        public string? PreviousCategoryId { get; set; }

        public List<string>? NextCategoriesIDs { get; set; }
    }
}
