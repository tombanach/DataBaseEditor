using Dapper;
using SmayDbEditor.DataAccessLayer.Interfaces;
using SmayDbEditor.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Repository
{
    public class PrinterAddingRepository : BaseRepository, IPrinterAddingRepository
    {
        public PrinterAddingRepository(IDbConnection connection) : base(connection)
        {
        }       

        public PrinterAddingModel GetPrinter(int id)
        {
            var sql = $"select * from [dbo].[printers] where id = @Id";

            return GetSmayDbConnection().QueryFirst<PrinterAddingModel>(sql, new { id = id });
        }

        public IEnumerable<PrinterAddingModel> GetPrinters()
        {
            var sql = $"select * from [dbo].[printers]";

            return GetSmayDbConnection().Query<PrinterAddingModel>(sql);
        }

        //POPRAWIĆ - dodać edytowanie 2 pola
        public void UpdatePrinter(PrinterAddingModel printer)
        {
            var sb = new StringBuilder();
            sb.Append($"update dbo.[printers] set ");
            sb.Append($"PrinterName = @PrinterName ");
            sb.Append($"where id = @id");

            GetSmayDbConnection().Execute(sb.ToString(), new { @PrinterName = printer.PrinterName, id = printer.id });
        }

        public void DeletePrinter(int id)
        {
            var sql = $"delete from dbo.printers where id = @Id";
            GetSmayDbConnection().Execute(sql, new { id = id });
        }
    }
}
