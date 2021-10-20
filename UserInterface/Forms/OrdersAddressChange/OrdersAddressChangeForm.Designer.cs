
namespace SmayDbEditor.UserInterface.Forms.OrdersAddressChange
{
    partial class OrdersAddressChangeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpOrdersAddressChange = new System.Windows.Forms.TableLayoutPanel();
            this.pOrdersAddressChange = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnModify = new System.Windows.Forms.Button();
            this.dgvOrdersAddressChange = new System.Windows.Forms.DataGridView();
            this.col_SOid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SOno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SOnoWMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SOline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CustCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_textline1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_QtyOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_QtyDelivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_orddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DestCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DestAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DestCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WayOfDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOrdersAddressChange = new System.Windows.Forms.BindingSource(this.components);
            this.tlpOrdersAddressChange.SuspendLayout();
            this.pOrdersAddressChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersAddressChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdersAddressChange)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpOrdersAddressChange
            // 
            this.tlpOrdersAddressChange.ColumnCount = 1;
            this.tlpOrdersAddressChange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrdersAddressChange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOrdersAddressChange.Controls.Add(this.pOrdersAddressChange, 0, 0);
            this.tlpOrdersAddressChange.Controls.Add(this.dgvOrdersAddressChange, 0, 1);
            this.tlpOrdersAddressChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOrdersAddressChange.Location = new System.Drawing.Point(0, 0);
            this.tlpOrdersAddressChange.Name = "tlpOrdersAddressChange";
            this.tlpOrdersAddressChange.RowCount = 2;
            this.tlpOrdersAddressChange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpOrdersAddressChange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrdersAddressChange.Size = new System.Drawing.Size(800, 450);
            this.tlpOrdersAddressChange.TabIndex = 0;
            // 
            // pOrdersAddressChange
            // 
            this.pOrdersAddressChange.Controls.Add(this.btnRefresh);
            this.pOrdersAddressChange.Controls.Add(this.splitter1);
            this.pOrdersAddressChange.Controls.Add(this.btnModify);
            this.pOrdersAddressChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOrdersAddressChange.Location = new System.Drawing.Point(3, 3);
            this.pOrdersAddressChange.Name = "pOrdersAddressChange";
            this.pOrdersAddressChange.Size = new System.Drawing.Size(794, 34);
            this.pOrdersAddressChange.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::SmayDbEditor.UserInterface.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(135, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 34);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(125, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 34);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Image = global::SmayDbEditor.UserInterface.Properties.Resources.edit_24;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(0, 0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(125, 34);
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "Zmień adres";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dgvOrdersAddressChange
            // 
            this.dgvOrdersAddressChange.AllowUserToAddRows = false;
            this.dgvOrdersAddressChange.AllowUserToDeleteRows = false;
            this.dgvOrdersAddressChange.AutoGenerateColumns = false;
            this.dgvOrdersAddressChange.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrdersAddressChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersAddressChange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SOid,
            this.col_SOno,
            this.col_SOnoWMS,
            this.col_SOline,
            this.col_CustCode,
            this.col_ItemCode,
            this.col_textline1,
            this.col_QtyOrdered,
            this.col_QtyDelivered,
            this.col_DeliveryDate,
            this.col_orddate,
            this.col_DestName,
            this.col_DestCity,
            this.col_DestAddress,
            this.col_DestCountry,
            this.col_WayOfDelivery});
            this.dgvOrdersAddressChange.DataSource = this.bsOrdersAddressChange;
            this.dgvOrdersAddressChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdersAddressChange.Location = new System.Drawing.Point(3, 43);
            this.dgvOrdersAddressChange.Name = "dgvOrdersAddressChange";
            this.dgvOrdersAddressChange.ReadOnly = true;
            this.dgvOrdersAddressChange.RowHeadersVisible = false;
            this.dgvOrdersAddressChange.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdersAddressChange.Size = new System.Drawing.Size(794, 404);
            this.dgvOrdersAddressChange.TabIndex = 1;
            // 
            // col_SOid
            // 
            this.col_SOid.DataPropertyName = "SOid";
            this.col_SOid.HeaderText = "SOid";
            this.col_SOid.Name = "col_SOid";
            this.col_SOid.ReadOnly = true;
            this.col_SOid.Visible = false;
            // 
            // col_SOno
            // 
            this.col_SOno.DataPropertyName = "SOno";
            this.col_SOno.HeaderText = "SOno";
            this.col_SOno.Name = "col_SOno";
            this.col_SOno.ReadOnly = true;
            // 
            // col_SOnoWMS
            // 
            this.col_SOnoWMS.DataPropertyName = "SOnoWMS";
            this.col_SOnoWMS.HeaderText = "SOnoWMS";
            this.col_SOnoWMS.Name = "col_SOnoWMS";
            this.col_SOnoWMS.ReadOnly = true;
            this.col_SOnoWMS.Width = 180;
            // 
            // col_SOline
            // 
            this.col_SOline.DataPropertyName = "SOline";
            this.col_SOline.HeaderText = "SOline";
            this.col_SOline.Name = "col_SOline";
            this.col_SOline.ReadOnly = true;
            // 
            // col_CustCode
            // 
            this.col_CustCode.DataPropertyName = "CustCode";
            this.col_CustCode.HeaderText = "CustCode";
            this.col_CustCode.Name = "col_CustCode";
            this.col_CustCode.ReadOnly = true;
            // 
            // col_ItemCode
            // 
            this.col_ItemCode.DataPropertyName = "ItemCode";
            this.col_ItemCode.HeaderText = "ItemCode";
            this.col_ItemCode.Name = "col_ItemCode";
            this.col_ItemCode.ReadOnly = true;
            // 
            // col_textline1
            // 
            this.col_textline1.DataPropertyName = "textline1";
            this.col_textline1.HeaderText = "textline1";
            this.col_textline1.Name = "col_textline1";
            this.col_textline1.ReadOnly = true;
            // 
            // col_QtyOrdered
            // 
            this.col_QtyOrdered.DataPropertyName = "QtyOrdered";
            this.col_QtyOrdered.HeaderText = "QtyOrdered";
            this.col_QtyOrdered.Name = "col_QtyOrdered";
            this.col_QtyOrdered.ReadOnly = true;
            // 
            // col_QtyDelivered
            // 
            this.col_QtyDelivered.DataPropertyName = "QtyDelivered";
            this.col_QtyDelivered.HeaderText = "QtyDelivered";
            this.col_QtyDelivered.Name = "col_QtyDelivered";
            this.col_QtyDelivered.ReadOnly = true;
            // 
            // col_DeliveryDate
            // 
            this.col_DeliveryDate.DataPropertyName = "DeliveryDate";
            this.col_DeliveryDate.HeaderText = "DeliveryDate";
            this.col_DeliveryDate.Name = "col_DeliveryDate";
            this.col_DeliveryDate.ReadOnly = true;
            // 
            // col_orddate
            // 
            this.col_orddate.DataPropertyName = "orddate";
            this.col_orddate.HeaderText = "orddate";
            this.col_orddate.Name = "col_orddate";
            this.col_orddate.ReadOnly = true;
            // 
            // col_DestName
            // 
            this.col_DestName.DataPropertyName = "DestName";
            this.col_DestName.HeaderText = "DestName";
            this.col_DestName.Name = "col_DestName";
            this.col_DestName.ReadOnly = true;
            // 
            // col_DestCity
            // 
            this.col_DestCity.DataPropertyName = "DestCity";
            this.col_DestCity.HeaderText = "DestCity";
            this.col_DestCity.Name = "col_DestCity";
            this.col_DestCity.ReadOnly = true;
            // 
            // col_DestAddress
            // 
            this.col_DestAddress.DataPropertyName = "DestAddress";
            this.col_DestAddress.HeaderText = "DestAddress";
            this.col_DestAddress.Name = "col_DestAddress";
            this.col_DestAddress.ReadOnly = true;
            // 
            // col_DestCountry
            // 
            this.col_DestCountry.DataPropertyName = "DestCountry";
            this.col_DestCountry.HeaderText = "DestCountry";
            this.col_DestCountry.Name = "col_DestCountry";
            this.col_DestCountry.ReadOnly = true;
            // 
            // col_WayOfDelivery
            // 
            this.col_WayOfDelivery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_WayOfDelivery.DataPropertyName = "WayOfDelivery";
            this.col_WayOfDelivery.HeaderText = "WayOfDelivery";
            this.col_WayOfDelivery.Name = "col_WayOfDelivery";
            this.col_WayOfDelivery.ReadOnly = true;
            // 
            // bsOrdersAddressChange
            // 
            this.bsOrdersAddressChange.DataSource = typeof(SmayDbEditor.DataAccessLayer.ViewModel.OrderAddressChangeViewModel);
            // 
            // OrdersAddressChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpOrdersAddressChange);
            this.Name = "OrdersAddressChangeForm";
            this.Text = "Zmiana adresu dostawy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdersAddressChangeForm_FormClosed);
            this.tlpOrdersAddressChange.ResumeLayout(false);
            this.pOrdersAddressChange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersAddressChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdersAddressChange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpOrdersAddressChange;
        private System.Windows.Forms.Panel pOrdersAddressChange;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dgvOrdersAddressChange;
        private System.Windows.Forms.BindingSource bsOrdersAddressChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SOid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SOno;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SOnoWMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SOline;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_textline1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_QtyOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_QtyDelivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_orddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DestCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DestAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DestCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WayOfDelivery;
    }
}