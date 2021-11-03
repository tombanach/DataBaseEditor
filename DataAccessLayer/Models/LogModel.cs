using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Models
{
    public class LogModel : EntityModel
    {
        public string Log_Num { get; set; }
        public string Log_Descr { get; set; }
        public DateTime Log_Tstamp { get; set; }
        public string Log_Error { get; set; }
    }
}
