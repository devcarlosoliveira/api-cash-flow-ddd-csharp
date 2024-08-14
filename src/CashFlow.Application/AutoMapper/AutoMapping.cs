﻿using AutoMapper;
using CashFlow.Communication.Requests;
using CashFlow.Domain.Entities;

namespace CashFlow.Application.AutoMapper;

public class AutoMapping :Profile
{
    public AutoMapping() { }
    private void RequestToEntity()
    {
        CreateMap<RequestRegisterExpenseJson, Expense>();
    }
    private void EntityToResponse()
    {
        CreateMap<Expense, RequestRegisterExpenseJson>();
    }
}
