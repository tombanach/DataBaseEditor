using SmayDbEditor.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.ViewModel
{
    public class UnlockProductionViewModel
    {
        public int proccode { get; set; }
        public string procname { get; set; }
        public string username { get; set; }
        public DateTime timestarted { get; set; }
    }
}
