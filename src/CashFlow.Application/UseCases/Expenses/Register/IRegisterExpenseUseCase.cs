﻿using CashFlow.Communication.Requests;
using CashFlow.Communication.Response;

namespace CashFlow.Application.UseCases.Expenses.Register;

public interface IRegisterExpenseUseCase
{
    public Task<ResponseRegisterExpenseJson> Execute(RequestExpenseJson request);
}
