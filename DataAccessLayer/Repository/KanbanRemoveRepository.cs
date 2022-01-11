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
    public class KanbanRemoveRepository : BaseRepository, IKanbanRemoveRepository
    {
        public KanbanRemoveRepository(IDbConnection connection) : base(connection)
        {
        }

        public KanbanRemoveModel GetKanban(int kbtrId)
        {
            var sql = $"select * from [dbo].[kbtr_rel] where kbtr_id = @kbtrId";

            return _wmsConnection.QueryFirst<KanbanRemoveModel>(sql, new { kbtrId = kbtrId });
        }

        public IEnumerable<KanbanRemoveModel> GetKanbans()
        {
            var sql = $"select * from [WmsSmayDb_Conn].[dbo].[kbtr_rel]";

            return _wmsConnection.Query<KanbanRemoveModel>(sql);
        }

        public void DeleteKanban(int kbtrId)
        {
            var sql = $"delete from dbo.kbtr_rel where kbtr_id = @kbtrId";
            _wmsConnection.Execute(sql, new { kbtrId = kbtrId });
        }   
    }
}
