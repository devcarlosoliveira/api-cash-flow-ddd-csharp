using AutoMapper;
using CashFlow.Domain.Entities;
using CashFlow.Domain.Enums;
using CashFlow.Domain.Repositories.Expenses;
using ClosedXML.Excel;

namespace CashFlow.Application.UseCases.Expenses.Reports.Excel
{
    public class GenerateExpensesReportExcelUseCase : IGenerateExpensesReportExcelUseCase
    {
        //TODO REFACTOR
        private const string CURRENCY_SYMBOL = "R$";

        private readonly IExpensesReadOnlyRepository _repository;
        private readonly IMapper _mapper;

        public GenerateExpensesReportExcelUseCase(IExpensesReadOnlyRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<byte[]> Execute(DateOnly month)
        {
            var expenses = await _repository.ListByMonth(month);

            if (expenses.Count == 0)
            {
                return [];
            }

            using var workbook = new XLWorkbook();

            workbook.Author = "Company Name";
            workbook.Style.Font.FontSize = 12;
            workbook.Style.Font.FontName = "Times New Roman";

            var worksheet = workbook.Worksheets.Add(month.ToString("Y"));

            InsertHeader(worksheet);
            InsertBody(worksheet, expenses);

            worksheet.Columns().AdjustToContents();

            var file = new MemoryStream();
            workbook.SaveAs(file);

            return file.ToArray();
        }

        private void InsertBody(IXLWorksheet worksheet, List<Expense> expenses)
        {
            

            var raw = 2;
            foreach (var expense in expenses)
            {
                worksheet.Cell($"A{raw}").Value = expense.Title;
                worksheet.Cell($"B{raw}").Value = expense.Date;
                worksheet.Cell($"C{raw}").Value = ConvertPaymentType(expense.PaymentType);
                
                worksheet.Cell($"D{raw}").Value = expense.Amount;
                worksheet.Cell($"D{raw}").Style.NumberFormat.Format = $"-{CURRENCY_SYMBOL} #,###.00";

                worksheet.Cell($"E{raw}").Value = expense.Description;

                raw++;
            }
        }

        private void InsertHeader(IXLWorksheet worksheet)
        {
            worksheet.Cells("A1:E1").Style.Font.Bold = true;
            worksheet.Cells("A1:E1").Style.Fill.BackgroundColor = XLColor.FromHtml("#F5C2B6");

            worksheet.Cells("A1").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            worksheet.Cells("B1").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            worksheet.Cells("C1").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            worksheet.Cells("D1").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            worksheet.Cells("E1").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right);

            worksheet.Cell("A1").Value = ResourceReportGenerationMessage.TITLE;
            worksheet.Cell("B1").Value = ResourceReportGenerationMessage.DATE;
            worksheet.Cell("C1").Value = ResourceReportGenerationMessage.PAYMENT_TYPE;
            worksheet.Cell("D1").Value = ResourceReportGenerationMessage.AMOUNT;
            worksheet.Cell("E1").Value = ResourceReportGenerationMessage.DESCRIPTION;
        }

        private string ConvertPaymentType(PaymentType paymentType)
        {
            //TODO REFACTOR
            return paymentType switch
            {
                PaymentType.Cash => "Dinheiro",
                PaymentType.CreditCard => "Cartão de Crédito",
                PaymentType.DebitCard => "Cartão de Débito",
                PaymentType.EletronicTransfer => "Transferência Bancária",
                PaymentType.None => "Não Informado",
                _ => string.Empty
            };
        }
    }
}