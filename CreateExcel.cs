using ClosedXML.Excel;

namespace ExportExcel;

public class CreateExcel
{
    /*public void FirstExample()
    {
        using (var workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Hoja1");
            
            worksheet.Cell(1, 1).Value = "Nombre";
            worksheet.Cell(1, 2).Value = "Edad";
            worksheet.Cell(2, 1).Value = "Juan";
            worksheet.Cell(2, 2).Value = 28;
            
            workbook.SaveAs("/Users/robertoflores/Downloads/archivo.xlsx");
        }
    }
*/
    /*public void SecondExample()
    {
        using (var workbook = new XLWorkbook("/Users/robertoflores/Downloads/archivo.xlsx"))
        {
            var worksheet = workbook.Worksheet(1);

            worksheet.Cell(2, 2).Value = 30;
            
            workbook.Save();
        }
    }
    public void ThirdExample()
    {
        using (var workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Datos");
            
            worksheet.Cell(1, 1).Value = "ID";
            worksheet.Cell(1, 2).Value = "Nombre";
            worksheet.Cell(1, 3).Value = "Edad";
            
            worksheet.Cell(2,1).Value = 1;
            worksheet.Cell(2,2).Value = "Juan";
            worksheet.Cell(2,3).Value = 28;
            
            worksheet.Cell(3,1).Value = 2;
            worksheet.Cell(3,2).Value = "Maria";
            worksheet.Cell(3,3).Value = 34;
            
            var range = worksheet.Range("A1:C3");
            range.CreateTable();
            
            workbook.SaveAs("/Users/robertoflores/Downloads/tabla.xlsx");
        }
    }
    */
    public void FourthExample()
    {
        using (var workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Estilos");
            
            var headerRow = worksheet.Row(1);
            headerRow.Style.Font.Bold = true;
            headerRow.Style.Fill.BackgroundColor = XLColor.Cyan;
            headerRow.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            worksheet.Cell(1, 1).Value = "ID";
            worksheet.Cell(1, 2).Value = "Nombre";
            worksheet.Cell(1, 3).Value = "Edad";
            
            worksheet.Cell(2,1).Value = 1;
            worksheet.Cell(2,2).Value = "Juan";
            worksheet.Cell(2,3).Value = 28;
            
            workbook.SaveAs("/Users/robertoflores/Downloads/archivo_con_estilos.xlsx");
        }
    }
}