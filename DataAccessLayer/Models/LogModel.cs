using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Models
{
    public class LogModel
    {
        public int log_num { get; set; }
        public string log_descr { get; set; }
        public DateTime log_tstamp { get; set; }
        public int log_error { get; set; }
    }
}
