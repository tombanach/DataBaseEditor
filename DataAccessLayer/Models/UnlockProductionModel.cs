using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Models
{
    public class UnlockProductionModel : EntityModel
    {
        public int ProcCode { get; set; }
        public string ProcName { get; set; }
        public string UserName { get; set; }
        public DateTime TimeStarted { get; set; }
    }
}
