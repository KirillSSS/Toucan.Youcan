namespace Toucan.Youcan.Models.Abstractions
{
    public interface IEntity
    {
        int Id { get; set; }

        string Name { get; set; }
    }
}
