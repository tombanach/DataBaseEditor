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
    public class OrderCorrectionRepository : IOrderCorrectionRepository
    {
        private readonly IDbConnection _connection;

        public OrderCorrectionRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void DeleteOrder(int porelId)
        {
            var sql = $"delete from dbo.podet_rel where porel_id = @porelId";
            _connection.Execute(sql, new { porelId = porelId });
        }

        public OrderCorrectionModel GetOrder(int porelId)
        {
            var sql = $"select * from [dbo].[podet_rel] where porel_id = @porelId";

            return _connection.QueryFirst<OrderCorrectionModel>(sql, new { porelId = porelId });
        }

        public IEnumerable<OrderCorrectionModel> GetOrders()
        {
            var sql = $"select * from [dbo].[podet_rel]";

            return _connection.Query<OrderCorrectionModel>(sql);
        }

        public void UpdateOrder(OrderCorrectionModel order)
        {
            var sb = new StringBuilder();
            sb.Append($"update dbo.[podet_rel] set ");
            sb.Append($"porel_qty = @porelQty ");
            sb.Append($"where porel_id = @porelId");

            _connection.Execute(sb.ToString(), new { @porelQty = order.Porel_Qty, @porelId = order.porel_id });
        }
    }
}
