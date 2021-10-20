using SmayDbEditor.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Interfaces
{
    public interface IKanbanRemoveRepository
    {
        IEnumerable<KanbanRemoveModel> GetKanbans();
        KanbanRemoveModel GetKanban(int kbtrId);
        void DeleteKanban(int kbtrId);
    }
}
