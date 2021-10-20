using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Models
{
    public class OrderAddressChangeModel : EntityModel
    {        
        public string SOno { get; set; }
        public string SOnoWMS { get; set; }
        public string SOline { get; set; }
        public string SOsubline { get; set; }
        public int OrderStatus { get; set; }
        public int ExportCode { get; set; }
        public int TermsOfDeliveryCode { get; set; }
        public int WayOfDeliveryCode { get; set; }
        public string CustCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemName1 { get; set; }
        public string ItemName2 { get; set; }
        public string textline1 { get; set; }
        public string WarehouseNo { get; set; }
        public string SOdeliveryline { get; set; }
        public string BatchID { get; set; }
        public float QtyOrdered { get; set; }
        public float QtyDelivered { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime orddate { get; set; }
        public float weight { get; set; }
        public float grossweight { get; set; }
        public string crossordernumber { get; set; }
        public string crossorderlinenumber { get; set; }
        public string DeliveryCode { get; set; }
        public int QC { get; set; }
        public string DestName { get; set; }
        public string DestCity { get; set; }
        public string DestAddress { get; set; }
        public string DestCountry { get; set; }
        public int PR { get; set; }
        public string DeliveryRouteNo { get; set; }
        public string Truck { get; set; }
        public string DriverName { get; set; }
        public string Shipper { get; set; }
        public string CustPONo { get; set; }
        public string DestZipCode { get; set; }
        public string SOremarks { get; set; }
        public string DestTelNo { get; set; }
        public string TaxRegNo { get; set; }
        public string TermsOfDelivery { get; set; }
        public string WayOfDelivery { get; set; }
        public string DestWhNo { get; set; }
        public DateTime tstamp { get; set; }
        public int status { get; set; }
        public string indexWMS { get; set; }
        public int dok_knalpWMS { get; set; }
        public string TELEFON_DHL { get; set; }
        public string KwotaPobrania_DHL { get; set; }
        public string OSOBA_DHL { get; set; }
        public string ProductCategory { get; set; }
        public int func { get; set; }
        public string DanePrzewoznika { get; set; }
    }
}
