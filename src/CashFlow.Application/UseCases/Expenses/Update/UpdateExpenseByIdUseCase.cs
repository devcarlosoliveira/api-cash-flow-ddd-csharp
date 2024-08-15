using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Domain.Repositories;
using CashFlow.Communication.Response;
using CashFlow.Communication.Requests;
using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Domain.Entities;
using CashFlow.Exception.ExceptionBase;
using AutoMapper;
using CashFlow.Exception;

namespace CashFlow.Application.UseCases.Expenses.Update;

public class UpdateExpenseByIdUseCase : IUpdateExpenseByIdUseCase
{
    private readonly IExpensesUpdateOnlyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateExpenseByIdUseCase(IExpensesUpdateOnlyRepository repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task Execute(long id, RequestExpenseJson request)
    {
        Validation(request);

        var expense = await _repository.GetById(id);
        if (expense is null)
        {
            throw new NotFoundException(ResourceErrorMessages.EXPENSE_NOT_FOUND);
        }

        _mapper.Map(request, expense);

        _repository.Update(expense);
        await _unitOfWork.CommitChanges();
    }

    private void Validation(RequestExpenseJson request)
    {
        var validator = new ExpenseValidator();

        var result = validator.Validate(request);

        if (!result.IsValid)
        {
            var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();
            throw new ErrorOnValidationException(errorMessages);
        }


    }
}
