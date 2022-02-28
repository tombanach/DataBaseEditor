using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Models
{
    public class PrinterAddingModel : EntityModel
    {
        public int id { get; set; }
        public string PrinterName { get; set; }
        public string hostname { get; set; }
    }
}
