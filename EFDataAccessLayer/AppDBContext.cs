using EFDataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLayer
{
    //1.Code First Approach (First Code Create than Data Base create Automatically)
    //2.DB First Approach   (First data base  Create than code create Automatically)
    public class AppDBContext : DbContext
    {
        public DbSet <Employee > Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }


    }
}
