using ExportExcel.Application.Reports.Queries;
using ExportExcel.Infrastructure.Excel;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ExportExcel.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ReportsController(IMediator _mediator, IExcelExporter _exporter) : ControllerBase
{
    [HttpGet("client-sales")]
    public async Task<IActionResult> GetClientSalesReport() {
        var data = await _mediator.Send(new GetClientSalesReportQuery());
        var fileContent = _exporter.ExportClientSales(data);
        return File(fileContent, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ClientSales.xlsx");
    }
    [HttpGet("product-sales")]
    public async Task<IActionResult> GetProductSalesReport()
    {
        var data = await _mediator.Send(new GetProductSalesReportQuery());
        var fileContent = _exporter.ExportProductSales(data);

        return File(fileContent,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            "ProductSales.xlsx");
    }
}