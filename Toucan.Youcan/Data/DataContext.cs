using Microsoft.EntityFrameworkCore;
using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Admins> Admins { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Days> Days { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Group_Days> Group_Days { get; set; }
        public DbSet<Month> Month { get; set; }
        public DbSet<Once_Month_Number> Once_Month_Number { get; set; }
        public DbSet<Once_Year_Number_Month> Once_Year_Number_Month { get; set; }
        public DbSet<Repeat_first_day> Repeat_first_day { get; set; }
        public DbSet<Type_Repeat> Type_Repeat { get; set; }
        public DbSet<User_Category_Subscribe> User_Category_Subscribe { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Users_Groups> Users_Groups { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            //Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.LogTo(Console.WriteLine);
        //    optionsBuilder.UseNpgsql("server=localhost; Port=5602; database=Scheduler; Username=postgres; password=justsomepassword");
        //}

    }
}
