using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Models
{
    public class EntityModel
    {
        public int porel_id { get; set; } //OrdersCorrection
        public int imph_id { get; set; } //StatusChanges
        public int kbtr_id { get; set; } //KanbansRemove
        public int SOid { get; set; } //OrdersAddressChange
        public int id { get; set; } //PrintersAdding
        public int log_id { get; set; } //Logi
    }
}
