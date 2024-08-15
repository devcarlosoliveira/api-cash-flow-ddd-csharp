using CashFlow.Communication.Requests;
using CashFlow.Communication.Response;

namespace CashFlow.Application.UseCases.Expenses.Update;

public interface IUpdateExpenseByIdUseCase
{
    public Task Execute(long id, RequestExpenseJson request);
}
