using SmayDbEditor.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.UserInterface.Classes
{
    public class OrderAddressChangeEventArgs : EventArgs
    {
        public OrderAddressChangeModel OrderAddressChange { private set; get; }

        public OrderAddressChangeEventArgs(OrderAddressChangeModel orderAddressChange)
        {
            OrderAddressChange = orderAddressChange;
        }
    }
}
