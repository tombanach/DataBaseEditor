using SmayDbEditor.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.DataAccessLayer.Interfaces
{
    public interface IOrderCorrectionRepository
    {
        IEnumerable<OrderCorrectionModel> GetOrders();
        OrderCorrectionModel GetOrder(int porelId);
        void UpdateOrder(OrderCorrectionModel order);
        void DeleteOrder(int porelId);
    }
}
