
namespace SmayDbEditor.UserInterface.Forms.OrdersCorrection
{
    partial class OrdersCorrectionForm
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
            this.tlpOrdersCorrection = new System.Windows.Forms.TableLayoutPanel();
            this.pOrdersCorrection = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OrdersCorrectionSearchBar = new System.Windows.Forms.TextBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnRemove = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnModify = new System.Windows.Forms.Button();
            this.dgvOrdersCorrection = new System.Windows.Forms.DataGridView();
            this.col_porel_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_podet_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_porel_itemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_porel_pono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_porel_poline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_porel_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_porel_tstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOrdersCorrection = new System.Windows.Forms.BindingSource(this.components);
            this.tlpOrdersCorrection.SuspendLayout();
            this.pOrdersCorrection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersCorrection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdersCorrection)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpOrdersCorrection
            // 
            this.tlpOrdersCorrection.ColumnCount = 1;
            this.tlpOrdersCorrection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrdersCorrection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOrdersCorrection.Controls.Add(this.pOrdersCorrection, 0, 0);
            this.tlpOrdersCorrection.Controls.Add(this.dgvOrdersCorrection, 0, 1);
            this.tlpOrdersCorrection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOrdersCorrection.Location = new System.Drawing.Point(0, 0);
            this.tlpOrdersCorrection.Name = "tlpOrdersCorrection";
            this.tlpOrdersCorrection.RowCount = 2;
            this.tlpOrdersCorrection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpOrdersCorrection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrdersCorrection.Size = new System.Drawing.Size(800, 450);
            this.tlpOrdersCorrection.TabIndex = 0;
            // 
            // pOrdersCorrection
            // 
            this.pOrdersCorrection.BackColor = System.Drawing.Color.White;
            this.pOrdersCorrection.Controls.Add(this.label1);
            this.pOrdersCorrection.Controls.Add(this.OrdersCorrectionSearchBar);
            this.pOrdersCorrection.Controls.Add(this.splitter3);
            this.pOrdersCorrection.Controls.Add(this.btnRefresh);
            this.pOrdersCorrection.Controls.Add(this.splitter2);
            this.pOrdersCorrection.Controls.Add(this.btnRemove);
            this.pOrdersCorrection.Controls.Add(this.splitter1);
            this.pOrdersCorrection.Controls.Add(this.btnModify);
            this.pOrdersCorrection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOrdersCorrection.Location = new System.Drawing.Point(3, 3);
            this.pOrdersCorrection.Name = "pOrdersCorrection";
            this.pOrdersCorrection.Size = new System.Drawing.Size(794, 34);
            this.pOrdersCorrection.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(497, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numer zamówienia";
            // 
            // OrdersCorrectionSearchBar
            // 
            this.OrdersCorrectionSearchBar.Location = new System.Drawing.Point(645, 6);
            this.OrdersCorrectionSearchBar.Name = "OrdersCorrectionSearchBar";
            this.OrdersCorrectionSearchBar.Size = new System.Drawing.Size(146, 20);
            this.OrdersCorrectionSearchBar.TabIndex = 6;
            this.OrdersCorrectionSearchBar.TextChanged += new System.EventHandler(this.OrdersCorrectionSearchBar_TextChanged);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(315, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(160, 34);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::SmayDbEditor.UserInterface.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(220, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 34);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(210, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 34);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Image = global::SmayDbEditor.UserInterface.Properties.Resources.delete_24;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(120, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 34);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(110, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 34);
            this.splitter1.TabIndex = 3;
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
            this.btnModify.Size = new System.Drawing.Size(110, 34);
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "Modyfikuj";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dgvOrdersCorrection
            // 
            this.dgvOrdersCorrection.AllowUserToAddRows = false;
            this.dgvOrdersCorrection.AllowUserToDeleteRows = false;
            this.dgvOrdersCorrection.AutoGenerateColumns = false;
            this.dgvOrdersCorrection.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrdersCorrection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersCorrection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_porel_id,
            this.col_podet_id,
            this.col_porel_itemcode,
            this.col_porel_pono,
            this.col_porel_poline,
            this.col_porel_qty,
            this.col_porel_tstamp});
            this.dgvOrdersCorrection.DataSource = this.bsOrdersCorrection;
            this.dgvOrdersCorrection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdersCorrection.Location = new System.Drawing.Point(3, 43);
            this.dgvOrdersCorrection.Name = "dgvOrdersCorrection";
            this.dgvOrdersCorrection.ReadOnly = true;
            this.dgvOrdersCorrection.RowHeadersVisible = false;
            this.dgvOrdersCorrection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdersCorrection.Size = new System.Drawing.Size(794, 404);
            this.dgvOrdersCorrection.TabIndex = 1;
            // 
            // col_porel_id
            // 
            this.col_porel_id.DataPropertyName = "porel_id";
            this.col_porel_id.HeaderText = "porel_id";
            this.col_porel_id.Name = "col_porel_id";
            this.col_porel_id.ReadOnly = true;
            this.col_porel_id.Visible = false;
            // 
            // col_podet_id
            // 
            this.col_podet_id.DataPropertyName = "podet_id";
            this.col_podet_id.HeaderText = "podet_id";
            this.col_podet_id.Name = "col_podet_id";
            this.col_podet_id.ReadOnly = true;
            // 
            // col_porel_itemcode
            // 
            this.col_porel_itemcode.DataPropertyName = "porel_itemcode";
            this.col_porel_itemcode.HeaderText = "porel_itemcode";
            this.col_porel_itemcode.Name = "col_porel_itemcode";
            this.col_porel_itemcode.ReadOnly = true;
            // 
            // col_porel_pono
            // 
            this.col_porel_pono.DataPropertyName = "porel_pono";
            this.col_porel_pono.HeaderText = "porel_pono";
            this.col_porel_pono.Name = "col_porel_pono";
            this.col_porel_pono.ReadOnly = true;
            // 
            // col_porel_poline
            // 
            this.col_porel_poline.DataPropertyName = "porel_poline";
            this.col_porel_poline.HeaderText = "porel_poline";
            this.col_porel_poline.Name = "col_porel_poline";
            this.col_porel_poline.ReadOnly = true;
            // 
            // col_porel_qty
            // 
            this.col_porel_qty.DataPropertyName = "porel_qty";
            this.col_porel_qty.HeaderText = "porel_qty";
            this.col_porel_qty.Name = "col_porel_qty";
            this.col_porel_qty.ReadOnly = true;
            // 
            // col_porel_tstamp
            // 
            this.col_porel_tstamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_porel_tstamp.DataPropertyName = "porel_tstamp";
            this.col_porel_tstamp.HeaderText = "porel_tstamp";
            this.col_porel_tstamp.Name = "col_porel_tstamp";
            this.col_porel_tstamp.ReadOnly = true;
            // 
            // bsOrdersCorrection
            // 
            this.bsOrdersCorrection.DataSource = typeof(SmayDbEditor.DataAccessLayer.ViewModel.OrderCorrectionViewModel);
            // 
            // OrdersCorrectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpOrdersCorrection);
            this.Name = "OrdersCorrectionForm";
            this.Text = "Korekta zamówienia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdersCorrectionForm_FormClosed);
            this.tlpOrdersCorrection.ResumeLayout(false);
            this.pOrdersCorrection.ResumeLayout(false);
            this.pOrdersCorrection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersCorrection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdersCorrection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpOrdersCorrection;
        private System.Windows.Forms.Panel pOrdersCorrection;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView dgvOrdersCorrection;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.BindingSource bsOrdersCorrection;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_porel_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_podet_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_porel_itemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_porel_pono;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_porel_poline;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_porel_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_porel_tstamp;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrdersCorrectionSearchBar;
    }
}