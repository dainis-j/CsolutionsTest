using CsolutionsTest.Data;
using CsolutionsTest.Data.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<TestDbContext>(options =>
    options.UseSqlite(connectionString));

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGet("/audit", GetAuditOperations);

/// <summary>
/// Gets the latest audit operations from the database.
/// </summary>
/// <param name="dbContext">The database context.</param>
/// <param name="from">Minimum operation date.</param>
/// <param name="to">Maximum operation date.</param>
static List<AuditOperation> GetAuditOperations(TestDbContext dbContext, DateTime? from, DateTime? to)
{

    if (dbContext.AuditOperations == null)
    {
        throw new ArgumentNullException($"Table {nameof(dbContext.AuditOperations)} hasn't been loaded.");
    }

    var query = dbContext.AuditOperations
        .Where(ao => !from.HasValue || ao.Date >= from)
        .Where(ao => !to.HasValue || ao.Date >= to)
        .OrderByDescending(ao => ao.Date);

    // Only take top 10 records if no filters provided
    if (!from.HasValue && !to.HasValue)
        query = (IOrderedQueryable<AuditOperation>)query.Take(10);

    return query.ToList();
}

app.Run();