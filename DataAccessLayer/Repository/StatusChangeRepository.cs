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
    public class StatusChangeRepository : IStatusChangeRepository
    {
        private readonly IDbConnection _connection;

        public StatusChangeRepository(IDbConnection connection)
        {
            _connection = connection;
        }        

        public StatusChangeModel GetStatus(int imphId)
        {
            var sql = $"select * from [dbo].[imphead] where imph_id = @imphId";

            return _connection.QueryFirst<StatusChangeModel>(sql, new { imphId = imphId });
        }

        public IEnumerable<StatusChangeModel> GetStatuses()
        {
            var sql = $"select * from [dbo].[imphead]";

            return _connection.Query<StatusChangeModel>(sql);
        }

        public void UpdateStatus(StatusChangeModel statusChange)
        {
            var sb = new StringBuilder();
            sb.Append($"update dbo.[imphead] set ");
            sb.Append($"imph_status = @imph_status ");
            sb.Append($"where imph_id = @imphId");

            _connection.Execute(sb.ToString(), new { @imph_status = statusChange.imph_status, @imphId = statusChange.imph_id });
        }
    }
}
