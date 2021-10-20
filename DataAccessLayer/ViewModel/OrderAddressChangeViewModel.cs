using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.ViewModel
{
    public class OrderAddressChangeViewModel
    {
        public int SOid { get; set; }
        public string SOno { get; set; }
        public string SOnoWMS { get; set; }
        public string SOline { get; set; }
        public string CustCode { get; set; }
        public string ItemCode { get; set; }
        public string textline1 { get; set; }
        public float QtyOrdered { get; set; }
        public float QtyDelivered { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime orddate { get; set; }
        public string DestName { get; set; }
        public string DestCity { get; set; }
        public string DestAddress { get; set; }
        public string DestCountry { get; set; }
        public string WayOfDelivery { get; set; }
    }
}
