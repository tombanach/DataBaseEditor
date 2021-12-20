using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.ViewModel
{
    public class LogViewModel
    {
        public int log_id { get; set; }
        public string log_num { get; set; }
        public string log_descr { get; set; }
        public DateTime log_tstamp { get; set; }
        public string log_error { get; set; }
    }
}
