using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Models
{
    public class OrderCorrectionModel : EntityModel
    {
        public string Podet_Id { get; set; }
        public string Porel_Itemcode { get; set; }
        public string Porel_Pono { get; set; }
        public string Porel_Poline { get; set; }
        public string Porel_Qty { get; set; }
        public DateTime Porel_Tstamp { get; set; }  
        
        // Dotatkowe kolumny z tabeli
        public decimal porel_qtyWait { get; set; }
        public int porel_status { get; set; }
        public int realizele_id { get; set; }
        public int porel_nadw { get; set; }
        public DateTime porel_wms_time { get; set; }
        public string batchID { get; set; }
        public string porel_weight { get; set; }
        public string porel_qc { get; set; }
        public int wp_status { get; set; }        
    }
}
