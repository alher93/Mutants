using Microsoft.EntityFrameworkCore;

namespace Mutants.Tests.Controllers
{
    public class TestBase
    {
        protected ApplicationDBContext BuildContext(string dbName) 
        {
            var options = new DbContextOptionsBuilder<ApplicationDBContext>()
                                                    .UseInMemoryDatabase(dbName).Options;
            
            return new ApplicationDBContext(options);
        }
    }
}
