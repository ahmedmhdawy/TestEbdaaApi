using EbdaaApi.Models;
using Microsoft.EntityFrameworkCore;


namespace EbdaaApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Value> TbValues { get; set; }
    }
}
