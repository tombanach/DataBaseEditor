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
    public class LogRepository : ILogRepository
    {
        private readonly IDbConnection _connection;

        public LogRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public LogModel GetLog(int logId)
        {
            var sql = $"select * form [dbo].[logi] where log_id = @logId";

            return _connection.QueryFirst<LogModel>(sql, new { logId = logId });
        }

        public IEnumerable<LogModel> GetLogs()
        {
            var sql = $"select * form [dbo].[logi]";

            return _connection.Query<LogModel>(sql);
        }
    }
}
