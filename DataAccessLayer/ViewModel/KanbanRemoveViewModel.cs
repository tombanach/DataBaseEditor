using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.ViewModel
{
    public class KanbanRemoveViewModel
    {
        public int kbtr_id { get; set; }
        public string kbtr_polecNo { get; set; }
        public int kbtr_dokID { get; set; }
        public DateTime kbtr_polecDate { get; set; }
        public DateTime kbtr_relDate { get; set; }
        public int kbtr_status { get; set; }
        public DateTime kbtr_tstamp { get; set; }
    }
}
