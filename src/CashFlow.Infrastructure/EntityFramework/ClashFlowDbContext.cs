using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.EntityFramework;

public class ClashFlowDbContext : DbContext
{
    public ClashFlowDbContext() { }

    public ClashFlowDbContext(DbContextOptions<ClashFlowDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "DataSource=cashflow.db;Cache=Shared";
        optionsBuilder.UseSqlite(connectionString);
    }

    public DbSet<Expense> Expenses { get; set; }

    #region Required
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //}
    #endregion
}
