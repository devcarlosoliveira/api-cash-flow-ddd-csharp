namespace CashFlow.Exception.ExceptionBase;

public class ErrorOnValidationException : CashFlowException
{
    public List<string> ErrorMessages { get; set; }

    public ErrorOnValidationException(List<string> errorMessages)
    {
        ErrorMessages = errorMessages;
    }
}