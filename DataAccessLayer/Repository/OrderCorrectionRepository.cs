using Dapper;
using SmayDbEditor.DataAccessLayer.Interfaces;
using SmayDbEditor.DataAccessLayer.Models;
using SmayDbEditor.DataAccessLayer.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Repository
{
    public class OrderCorrectionRepository : BaseRepository, IOrderCorrectionRepository
    {
        public OrderCorrectionRepository(IDbConnection connection): base(connection)
        {
        }

        public void DeleteOrder(int porelId)
        {
            MultiConnectionDbUtil.Do(() =>
            {
                var smayConn = GetSmayDbConnection();
                smayConn.Open();

                var order = GetOrder(porelId);

                var sql = $"delete from dbo.podet_rel where porel_id = @porelId";
                _wmsConnection.Execute(sql, new { @porelId = porelId });

                sql = $"delete from dbo.podet_orders where ord_num = @porelPono";
                smayConn.Execute(sql, new { @porelPono = order.Porel_Pono });

                smayConn.Close();
            });
            
        }

        /*
        _connection.Open();
        using(var trans = _connection.BeginTransaction())
        {
            int records Updated = cnn.Execute(sql, p, trans);
            Console.WriteLine($"Records Updated: { recordsUpdated }");

            try
            {
                _connection.Execute("update dbo.podet_rel set Id = 1", transaction: trans);
                trans.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: { ex.Message }");
                trans.Rollback();
            }
        }
        */

        public OrderCorrectionModel GetOrder(int porelId)
        {
            var sql = $"select * from [dbo].[podet_rel] where porel_id = @porelId";

            return _wmsConnection.QueryFirst<OrderCorrectionModel>(sql, new { porelId = porelId });
        }

        public IEnumerable<OrderCorrectionModel> GetOrders()
        {
            var sql = $"select * from [dbo].[podet_rel]";

            return _wmsConnection.Query<OrderCorrectionModel>(sql);
        }

        public void UpdateOrder(OrderCorrectionModel order)
        {
            MultiConnectionDbUtil.Do(() =>
            {
                var smayConn = GetSmayDbConnection();
                smayConn.Open();

                var sb = new StringBuilder();
                sb.Append($"update dbo.[podet_rel] set ");
                sb.Append($"porel_qty = @porelQty ");
                sb.Append($"where porel_id = @porelId");

                var rowsAffected = _wmsConnection.Execute(sb.ToString(), new { @porelQty = order.Porel_Qty, @porelId = order.porel_id });

                sb.Clear();

                sb.Append($"update dbo.[podet_orders] set ");
                sb.Append($"ord_qty = @ordQty ");
                sb.Append($"where ord_num = @ordNum");

                var rowsAffected2 = smayConn.Execute(sb.ToString(), new { @ordQty = order.Porel_Qty, @ordNum = order.Porel_Pono });

                smayConn.Close();
            });
        }
    }
}
