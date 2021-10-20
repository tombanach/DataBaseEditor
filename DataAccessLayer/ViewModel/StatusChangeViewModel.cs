using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.ViewModel
{
    public class StatusChangeViewModel
    {
        public int imph_id { get; set; }
        public string imph_num { get; set; }
        public DateTime imph_tstamp { get; set; }
        public string imph_status { get; set; }
        public string imph_type { get; set; }
    }
}
