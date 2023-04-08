using Toucan.Youcan.Models.Abstractions;

namespace Toucan.Youcan.Models
{
    public class BaseEntity : IEntity
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
