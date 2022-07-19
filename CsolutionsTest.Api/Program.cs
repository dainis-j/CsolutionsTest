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

app.MapGet("/audit", (TestDbContext dbContext, DateTime? from, DateTime? to) =>
{
    if (dbContext.AuditOperations == null)
    {
        throw new ArgumentNullException($"Table {nameof(dbContext.AuditOperations)} hasn't been loaded.");
    }

    List<AuditOperation> result = dbContext.AuditOperations

        // Normally we wouldn't load the entire audit in memory but otherwise
        // OrderByDescending doesn't work. Possible issue with SQLite
        .ToList() 

        .OrderByDescending(ao => ao.Date)
        .ToList();

    return result;
});

app.Run();