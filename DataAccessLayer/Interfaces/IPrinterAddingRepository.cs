using SmayDbEditor.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Interfaces
{
    public interface IPrinterAddingRepository
    {
        IEnumerable<PrinterAddingModel> GetPrinters();
        PrinterAddingModel GetPrinter(int id);
        void AddPrinter(PrinterAddingModel printer);
        void UpdatePrinter(PrinterAddingModel printer);
        void DeletePrinter(int id);
    }
}
