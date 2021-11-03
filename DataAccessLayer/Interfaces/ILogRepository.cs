using SmayDbEditor.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Interfaces
{
    public interface ILogRepository
    {
        IEnumerable<LogModel> GetLogs();
        LogModel GetLog(int logId);
    }
}
