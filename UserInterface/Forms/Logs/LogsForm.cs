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

namespace SmayDbEditor.UserInterface.Forms.Logs
{
    public partial class LogsForm : BaseForm
    {
        private static LogsForm _instance = null;

        public static LogsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LogsForm();
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

        private LogsForm()
        {
            InitializeComponent();
        }

        private void LogsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
