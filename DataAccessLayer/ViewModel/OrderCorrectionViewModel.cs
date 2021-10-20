using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.ViewModel
{
    public class OrderCorrectionViewModel
    {
        public int porel_id { get; set; }        
        public string podet_id { get; set; }
        public string porel_itemcode { get; set; }
        public string porel_pono { get; set; }
        public string porel_poline { get; set; }
        public string porel_qty { get; set; }
        public DateTime porel_tstamp { get; set; }
    }
}
