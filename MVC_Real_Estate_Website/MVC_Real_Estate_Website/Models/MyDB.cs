using System.Data.Entity;

namespace BaiTapTuan01.Models
{
    public partial class MyDB : DbContext
    {
        public MyDB() : base("name=MyDB") { }

        public DbSet<Category> Categories { get; set; }
    }
}
