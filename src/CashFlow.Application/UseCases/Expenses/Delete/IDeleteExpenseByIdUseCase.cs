using CashFlow.Communication.Response;

namespace CashFlow.Application.UseCases.Expenses.Delelte;

public interface IDeleteExpenseByIdUseCase
{
    Task Execute(long id);
}
