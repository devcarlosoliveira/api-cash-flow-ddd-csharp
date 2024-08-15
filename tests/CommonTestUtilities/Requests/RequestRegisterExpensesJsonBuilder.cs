using Bogus;
using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;

namespace CommonTestUtilities.Requests;

public class RequestRegisterExpensesJsonBuilder
{
    public static RequestExpenseJson Build()
    {
        return new Faker<RequestExpenseJson>()
            .RuleFor(rule => rule.Title, faker => faker.Commerce.ProductName())
            .RuleFor(rule => rule.Description, faker => faker.Commerce.ProductDescription())
            .RuleFor(rule => rule.Date, faker => faker.Date.Past())
            .RuleFor(rule => rule.PaymentType, faker => faker.PickRandom<PaymentType>())
            .RuleFor(rule => rule.Amount, faker => faker.Random.Decimal(0.01M, 9999.99M ));
    }
}