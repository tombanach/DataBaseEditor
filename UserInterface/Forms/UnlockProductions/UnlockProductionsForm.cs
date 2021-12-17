﻿using SmayDbEditor.UserInterface.Forms.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmayDbEditor.UserInterface.Forms.UnlockProductions
{
    public partial class UnlockProductionsForm : BaseForm
    {
        private static UnlockProductionsForm _instance = null;

        public static UnlockProductionsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UnlockProductionsForm();
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

        public UnlockProductionsForm()
        {
            InitializeComponent();
        }

        private void UnlockProductionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
