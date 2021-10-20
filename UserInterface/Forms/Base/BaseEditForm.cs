﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmayDbEditor.UserInterface.Forms.Base
{
    public partial class BaseEditForm : BaseForm
    {
        public BaseEditForm()
        {
            InitializeComponent();
        }

        private void BaseEditForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            {
                Save();
            }

            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.X)
            {
                Cancel();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        protected virtual void Save() { }

        protected virtual void Cancel() { }
    }
}
