using SmayDbEditor.UserInterface.Forms.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmayDbEditor.UserInterface.Forms.OrdersStatistics
{
    public partial class OrdersStatisticsForm : BaseForm
    {

        private static OrdersStatisticsForm _instance = null;

        public static OrdersStatisticsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OrdersStatisticsForm();
                }
                return _instance;
            }
        }

        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        public OrdersStatisticsForm()
        {
            InitializeComponent();
        }

        private void OrdersStatisticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
