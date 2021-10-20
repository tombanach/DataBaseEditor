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
    public class OrderAddressChangeRepository : IOrderAddressChangeRepository
    {
        private readonly IDbConnection _connection;

        public OrderAddressChangeRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public OrderAddressChangeModel GetOrderAddress(int soId)
        {
            var sql = $"select * from [dbo].[sodet] where SOid = @soId";

            return _connection.QueryFirst<OrderAddressChangeModel>(sql, new { SOid = soId });
        }

        public IEnumerable<OrderAddressChangeModel> GetOrdersAddress()
        {
            var sql = $"select * from [dbo].[sodet]";

            return _connection.Query<OrderAddressChangeModel>(sql);
        }

        public void UpdateOrderAddress(OrderAddressChangeModel orderAddress)
        {
            var sb = new StringBuilder();
            sb.Append($"update dbo.[sodet] set ");
            sb.Append($"DestAddress = @destAddress ");
            sb.Append($"where SOid = @soId");

            _connection.Execute(sb.ToString(), new { @destAddress = orderAddress.DestAddress , @soId = orderAddress.SOid });
        }
    }
}
