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
    public class UnlockProductionRepository : BaseRepository, IUnlockProductionRepository
    {
        public UnlockProductionRepository(IDbConnection connection) : base(connection)
        {
        }

        public UnlockProductionModel GetDocument(int procCode)
        {
            var sql = $"select * from [SmayDB].[dbo].[P000_Locks01] where proccode = @procCode";

            return _wmsConnection.QueryFirst<UnlockProductionModel>(sql, new { procCode = procCode});
        }

        public IEnumerable<UnlockProductionModel> GetDocuments()
        {
            var sql = $"select * from [SmayDB].[dbo].[P000_Locks01]";            

            return _wmsConnection.Query<UnlockProductionModel>(sql);
        }

        public void DeleteDocument(int procCode)
        {
            var sql = $"delete from [SmayDB].[dbo].[P000_Locks01] where proccode = @procCode";
            _wmsConnection.Execute(sql, new { procCode = procCode });
        }
    }
}
