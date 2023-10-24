using Microsoft.EntityFrameworkCore;

namespace ASPDotNetCoreStudy.Model
{

    //1.Code First Approach (First Code Create than Data Base create Automatically)
    //2.DB First Approach   (First data base  Create than code create Automatically)
    //command run -
    //1. (add-migration fileName), (generate migration file )
    //2. (update-database) , (migration code convert database file create) 

    public class AppDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {

        // }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }


    }
}
