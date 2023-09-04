using Microsoft.EntityFrameworkCore;

namespace eticket.Data
{
    public class AddDbContextcs:DbContext
    {
        public AddDbContextcs(DbContextOptions<AddDbContextcs> Options ):base(Options)//Constructor
        {
            
        }
    }
}
