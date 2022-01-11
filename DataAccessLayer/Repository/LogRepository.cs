using Dapper;
using SmayDbEditor.DataAccessLayer.Interfaces;
using SmayDbEditor.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Repository
{
    public class LogRepository : BaseRepository, ILogRepository
    {
        public LogRepository(IDbConnection connection) : base(connection)
        {

        }

        public LogModel GetLog(int logId)
        {
            var sql = $"select * form [dbo].[logi] where log_id = @logId";

            return _wmsConnection.QueryFirst<LogModel>(sql, new { logId = logId });
        }

        public IEnumerable<LogModel> GetLogs()
        {
            var sql = $"select * form [dbo].[logi]";

            return _wmsConnection.Query<LogModel>(sql);
        }
    }
}
