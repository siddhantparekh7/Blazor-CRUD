using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options) 
            : base(options)    
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
