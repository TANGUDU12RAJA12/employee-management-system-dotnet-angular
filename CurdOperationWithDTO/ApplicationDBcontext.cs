using CurdOperationWithDTO.Model;
using Microsoft.EntityFrameworkCore;

namespace CurdOperationWithDTO
{
    public class ApplicationDBcontext: DbContext
    {
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }

}
