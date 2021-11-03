using SmayDbEditor.UserInterface.Forms.StatusChanges;
using SmayDbEditor.UserInterface.Forms.OrdersCorrection;
using SmayDbEditor.UserInterface.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmayDbEditor.UserInterface.Forms.KanbansRemove;
using SmayDbEditor.UserInterface.Forms.OrdersAddressChange;
using SmayDbEditor.UserInterface.Forms.PrintersAdding;
using SmayDbEditor.UserInterface.Forms.Logs;

namespace SmayDbEditor.UserInterface.Forms
{
    public partial class MainForm : Form
    {
        #region Fields

        private TabPage _tpOrdersCorrection;
        private TabPage _tpStatusChanges;
        private TabPage _tpKanbansRemove;
        private TabPage _tpOrdersAddressChange;
        private TabPage _tpPrintersAdding;
        //private TabPage _tpLogs;
        //private TabPage _tpCancelWzDoc;

        #endregion
        #region Ctor
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion
        #region Events

        private void btnOrdersCorrection_Click(object sender, EventArgs e)
        {
            if (OrdersCorrectionForm.IsNull)
            {
                _tpOrdersCorrection = new TabPage();
                ShowFormInTabPage(_tpOrdersCorrection, OrdersCorrectionForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpOrdersCorrection;
            }
        }

        private void btnStatusChanges_Click(object sender, EventArgs e)
        {
            if (StatusChangesForm.IsNull)
            {
                _tpStatusChanges = new TabPage();
                ShowFormInTabPage(_tpStatusChanges, StatusChangesForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpStatusChanges;
            }
        }

        private void btnKanbansRemove_Click(object sender, EventArgs e)
        {
            if (KanbansRemoveForm.IsNull)
            {
                _tpKanbansRemove = new TabPage();
                ShowFormInTabPage(_tpKanbansRemove, KanbansRemoveForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpKanbansRemove;
            }
        }

        private void btnOrdersAddressChange_Click(object sender, EventArgs e)
        {
            if (OrdersAddressChangeForm.IsNull)
            {
                _tpOrdersAddressChange = new TabPage();
                ShowFormInTabPage(_tpOrdersAddressChange, OrdersAddressChangeForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpOrdersAddressChange;
            }
        }

        private void btnPrintersAdding_Click(object sender, EventArgs e)
        {
            if (PrintersAddingForm.IsNull)
            {
                _tpPrintersAdding = new TabPage();
                ShowFormInTabPage(_tpPrintersAdding, PrintersAddingForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpPrintersAdding;
            }
        }

        //private void btnLogs_Click(object sender, EventArgs e)
        //{
        //    if (LogsForm.IsNull)
        //    {
        //        _tpLogs = new TabPage();
        //        ShowFormInTabPage(_tpLogs, LogsForm.Instance);
        //    }
        //    else
        //    {
        //        tcTabs.SelectedTab = _tpLogs;
        //    }
        //}


        // Red X button to close tabs on MainForm
        private void tcTabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.tcTabs.TabPages[e.Index];
                var tabRect = this.tcTabs.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);

                var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.CloseButtonName}");
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                    tabRect, tabPage.ForeColor, TextFormatFlags.Left);

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void tcTabs_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.tcTabs.TabPages.Count; i++)
            {
                var tabRect = this.tcTabs.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.CloseButtonName}");
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    var frm = tcTabs.TabPages[i].Controls[0] as Form;
                    frm.Close();

                    this.tcTabs.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        #endregion
        #region Private Methods

        // Wyświetlanie zakładek 
        private void ShowFormInTabPage(TabPage tpTab, Form frm)
        {
            tcTabs.Controls.Add(tpTab);

            tpTab.Text = frm.Text;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tpTab.Controls.Add(frm);
            tcTabs.SelectedTab = tpTab;
        }


        #endregion        
    }
}