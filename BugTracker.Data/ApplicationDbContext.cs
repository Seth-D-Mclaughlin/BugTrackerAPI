using Microsoft.EntityFrameworkCore;

namespace BugTracker.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
    }
}