using SmayDbEditor.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.UserInterface.Classes
{
    public class PrinterAddingEventArgs : EventArgs
    {
        public PrinterAddingModel PrinterAdding { private set; get; }

        public PrinterAddingEventArgs(PrinterAddingModel printerAdding)
        {
            PrinterAdding = printerAdding;
        }
    }
}
