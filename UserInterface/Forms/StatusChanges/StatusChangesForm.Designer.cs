
namespace SmayDbEditor.UserInterface.Forms.StatusChanges
{
    partial class StatusChangesForm
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
            this.tlpStatusChanges = new System.Windows.Forms.TableLayoutPanel();
            this.pStatusChanges = new System.Windows.Forms.Panel();
            this.btnStatusChangeInfo = new System.Windows.Forms.Button();
            this.StatusChangesSearchBar = new System.Windows.Forms.TextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnModify = new System.Windows.Forms.Button();
            this.dgvStatusChanges = new System.Windows.Forms.DataGridView();
            this.col_imph_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_imph_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_imph_tstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_imph_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_imph_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStatusChanges = new System.Windows.Forms.BindingSource(this.components);
            this.tlpStatusChanges.SuspendLayout();
            this.pStatusChanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatusChanges)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpStatusChanges
            // 
            this.tlpStatusChanges.BackColor = System.Drawing.Color.White;
            this.tlpStatusChanges.ColumnCount = 1;
            this.tlpStatusChanges.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStatusChanges.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStatusChanges.Controls.Add(this.pStatusChanges, 0, 0);
            this.tlpStatusChanges.Controls.Add(this.dgvStatusChanges, 0, 1);
            this.tlpStatusChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStatusChanges.Location = new System.Drawing.Point(0, 0);
            this.tlpStatusChanges.Name = "tlpStatusChanges";
            this.tlpStatusChanges.RowCount = 2;
            this.tlpStatusChanges.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpStatusChanges.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStatusChanges.Size = new System.Drawing.Size(800, 450);
            this.tlpStatusChanges.TabIndex = 0;
            // 
            // pStatusChanges
            // 
            this.pStatusChanges.BackColor = System.Drawing.Color.White;
            this.pStatusChanges.Controls.Add(this.btnStatusChangeInfo);
            this.pStatusChanges.Controls.Add(this.StatusChangesSearchBar);
            this.pStatusChanges.Controls.Add(this.splitter2);
            this.pStatusChanges.Controls.Add(this.lblOrderNumber);
            this.pStatusChanges.Controls.Add(this.btnRefresh);
            this.pStatusChanges.Controls.Add(this.splitter1);
            this.pStatusChanges.Controls.Add(this.btnModify);
            this.pStatusChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pStatusChanges.Location = new System.Drawing.Point(3, 3);
            this.pStatusChanges.Name = "pStatusChanges";
            this.pStatusChanges.Size = new System.Drawing.Size(794, 34);
            this.pStatusChanges.TabIndex = 0;
            // 
            // btnStatusChangeInfo
            // 
            this.btnStatusChangeInfo.BackColor = System.Drawing.Color.White;
            this.btnStatusChangeInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStatusChangeInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatusChangeInfo.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnStatusChangeInfo.Location = new System.Drawing.Point(293, 0);
            this.btnStatusChangeInfo.Name = "btnStatusChangeInfo";
            this.btnStatusChangeInfo.Size = new System.Drawing.Size(34, 34);
            this.btnStatusChangeInfo.TabIndex = 11;
            this.btnStatusChangeInfo.Text = "?";
            this.btnStatusChangeInfo.UseVisualStyleBackColor = false;
            this.btnStatusChangeInfo.Click += new System.EventHandler(this.btnStatusChangeInfo_Click);
            // 
            // StatusChangesSearchBar
            // 
            this.StatusChangesSearchBar.Location = new System.Drawing.Point(639, 7);
            this.StatusChangesSearchBar.Name = "StatusChangesSearchBar";
            this.StatusChangesSearchBar.Size = new System.Drawing.Size(146, 20);
            this.StatusChangesSearchBar.TabIndex = 10;
            this.StatusChangesSearchBar.TextChanged += new System.EventHandler(this.StatusChangesSearchBar_TextChanged);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(230, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(63, 34);
            this.splitter2.TabIndex = 9;
            this.splitter2.TabStop = false;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOrderNumber.Location = new System.Drawing.Point(488, 7);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(145, 20);
            this.lblOrderNumber.TabIndex = 8;
            this.lblOrderNumber.Text = "Numer zamówienia";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::SmayDbEditor.UserInterface.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(130, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 34);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(120, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 34);
            this.splitter1.TabIndex = 1;
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
            this.btnModify.Size = new System.Drawing.Size(120, 34);
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "Zmień status";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dgvStatusChanges
            // 
            this.dgvStatusChanges.AllowUserToAddRows = false;
            this.dgvStatusChanges.AllowUserToDeleteRows = false;
            this.dgvStatusChanges.AutoGenerateColumns = false;
            this.dgvStatusChanges.BackgroundColor = System.Drawing.Color.White;
            this.dgvStatusChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatusChanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_imph_id,
            this.col_imph_num,
            this.col_imph_tstamp,
            this.col_imph_status,
            this.col_imph_type});
            this.dgvStatusChanges.DataSource = this.bsStatusChanges;
            this.dgvStatusChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatusChanges.Location = new System.Drawing.Point(3, 43);
            this.dgvStatusChanges.Name = "dgvStatusChanges";
            this.dgvStatusChanges.ReadOnly = true;
            this.dgvStatusChanges.RowHeadersVisible = false;
            this.dgvStatusChanges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatusChanges.Size = new System.Drawing.Size(794, 404);
            this.dgvStatusChanges.TabIndex = 1;
            // 
            // col_imph_id
            // 
            this.col_imph_id.DataPropertyName = "imph_id";
            this.col_imph_id.HeaderText = "imph_id";
            this.col_imph_id.Name = "col_imph_id";
            this.col_imph_id.ReadOnly = true;
            this.col_imph_id.Visible = false;
            // 
            // col_imph_num
            // 
            this.col_imph_num.DataPropertyName = "imph_num";
            this.col_imph_num.HeaderText = "imph_num";
            this.col_imph_num.Name = "col_imph_num";
            this.col_imph_num.ReadOnly = true;
            // 
            // col_imph_tstamp
            // 
            this.col_imph_tstamp.DataPropertyName = "imph_tstamp";
            this.col_imph_tstamp.HeaderText = "imph_tstamp";
            this.col_imph_tstamp.Name = "col_imph_tstamp";
            this.col_imph_tstamp.ReadOnly = true;
            // 
            // col_imph_status
            // 
            this.col_imph_status.DataPropertyName = "imph_status";
            this.col_imph_status.HeaderText = "imph_status";
            this.col_imph_status.Name = "col_imph_status";
            this.col_imph_status.ReadOnly = true;
            // 
            // col_imph_type
            // 
            this.col_imph_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_imph_type.DataPropertyName = "imph_type";
            this.col_imph_type.HeaderText = "imph_type";
            this.col_imph_type.Name = "col_imph_type";
            this.col_imph_type.ReadOnly = true;
            // 
            // bsStatusChanges
            // 
            this.bsStatusChanges.DataSource = typeof(SmayDbEditor.DataAccessLayer.ViewModel.StatusChangeViewModel);
            // 
            // StatusChangesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpStatusChanges);
            this.Name = "StatusChangesForm";
            this.Text = "Zmiana statusu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatusChangesForm_FormClosed);
            this.tlpStatusChanges.ResumeLayout(false);
            this.pStatusChanges.ResumeLayout(false);
            this.pStatusChanges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatusChanges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpStatusChanges;
        private System.Windows.Forms.Panel pStatusChanges;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dgvStatusChanges;
        private System.Windows.Forms.BindingSource bsStatusChanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_imph_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_imph_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_imph_tstamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_imph_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_imph_type;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TextBox StatusChangesSearchBar;
        private System.Windows.Forms.Button btnStatusChangeInfo;
    }
}