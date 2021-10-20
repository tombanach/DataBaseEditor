using SmayDbEditor.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Interfaces
{
    public interface IStatusChangeRepository
    {
        IEnumerable<StatusChangeModel> GetStatuses();
        StatusChangeModel GetStatus(int imph_id);
        void UpdateStatus(StatusChangeModel status);
    }
}
