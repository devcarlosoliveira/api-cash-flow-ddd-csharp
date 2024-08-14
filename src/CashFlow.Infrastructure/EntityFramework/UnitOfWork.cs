using CashFlow.Application.EntityFramework;
using CashFlow.Domain.Repositories;

namespace CashFlow.Infrastructure.EntityFramework;

internal class UnitOfWork : IUnitOfWork
{
    private readonly CashFlowDbContext _dbContext;

    public UnitOfWork(CashFlowDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task CommitChanges()
    {
        await _dbContext.SaveChangesAsync();
    }
}
