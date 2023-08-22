using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WebApiEFCoreUnableCreateController.Domain.Data;

public partial class ContosoUniversityContextFactory : IDesignTimeDbContextFactory<ContosoUniversityContext>
{
    public ContosoUniversityContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ContosoUniversityContext>();

        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ContosoUniversity;Integrated Security=True");

        return new ContosoUniversityContext(optionsBuilder.Options);
    }
}