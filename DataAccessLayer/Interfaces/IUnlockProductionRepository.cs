using SmayDbEditor.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Interfaces
{
    public interface IUnlockProductionRepository
    {
        IEnumerable<UnlockProductionModel> GetDocuments();
        UnlockProductionModel GetDocument(int procCode);
        void DeleteDocument(int procCode);
    }
}
