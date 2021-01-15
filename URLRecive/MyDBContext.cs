using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLRecive
{
    class MyDBContext : DbContext
    {
    public MyDBContext(): base("MyConnectionString"){
            }

        public DbSet<Article> Article { get; set; }
    }
}
   
    

