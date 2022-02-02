namespace SmayDbEditor.UserInterface.Forms.Logs
{
    partial class LogsForm
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
            this.tlpLogs = new System.Windows.Forms.TableLayoutPanel();
            this.pLogs = new System.Windows.Forms.Panel();
            this.LogsSearchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.bsLogs = new System.Windows.Forms.BindingSource(this.components);
            this.col_log_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_log_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_log_descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_log_tstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_log_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpLogs.SuspendLayout();
            this.pLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpLogs
            // 
            this.tlpLogs.ColumnCount = 1;
            this.tlpLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLogs.Controls.Add(this.pLogs, 0, 0);
            this.tlpLogs.Controls.Add(this.dgvLogs, 0, 1);
            this.tlpLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLogs.Location = new System.Drawing.Point(0, 0);
            this.tlpLogs.Name = "tlpLogs";
            this.tlpLogs.RowCount = 2;
            this.tlpLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogs.Size = new System.Drawing.Size(778, 365);
            this.tlpLogs.TabIndex = 0;
            // 
            // pLogs
            // 
            this.pLogs.Controls.Add(this.LogsSearchBar);
            this.pLogs.Controls.Add(this.label1);
            this.pLogs.Controls.Add(this.splitter1);
            this.pLogs.Controls.Add(this.btnRefresh);
            this.pLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLogs.Location = new System.Drawing.Point(3, 3);
            this.pLogs.Name = "pLogs";
            this.pLogs.Size = new System.Drawing.Size(772, 34);
            this.pLogs.TabIndex = 0;
            // 
            // LogsSearchBar
            // 
            this.LogsSearchBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogsSearchBar.Location = new System.Drawing.Point(617, 3);
            this.LogsSearchBar.Name = "LogsSearchBar";
            this.LogsSearchBar.Size = new System.Drawing.Size(152, 27);
            this.LogsSearchBar.TabIndex = 3;
            this.LogsSearchBar.TextChanged += new System.EventHandler(this.LogsSearchBar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(475, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numer dokumentu:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(109, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(206, 34);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::SmayDbEditor.UserInterface.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 34);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.AutoGenerateColumns = false;
            this.dgvLogs.BackgroundColor = System.Drawing.Color.White;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_log_id,
            this.col_log_num,
            this.col_log_descr,
            this.col_log_tstamp,
            this.col_log_error});
            this.dgvLogs.DataSource = this.bsLogs;
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.Location = new System.Drawing.Point(3, 43);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.RowHeadersVisible = false;
            this.dgvLogs.Size = new System.Drawing.Size(772, 319);
            this.dgvLogs.TabIndex = 1;
            // 
            // bsLogs
            // 
            this.bsLogs.DataSource = typeof(SmayDbEditor.DataAccessLayer.ViewModel.LogViewModel);
            // 
            // col_log_id
            // 
            this.col_log_id.DataPropertyName = "log_id";
            this.col_log_id.HeaderText = "log_id";
            this.col_log_id.Name = "col_log_id";
            this.col_log_id.ReadOnly = true;
            this.col_log_id.Visible = false;
            // 
            // col_log_num
            // 
            this.col_log_num.DataPropertyName = "log_num";
            this.col_log_num.HeaderText = "log_num";
            this.col_log_num.Name = "col_log_num";
            this.col_log_num.ReadOnly = true;
            this.col_log_num.Width = 140;
            // 
            // col_log_descr
            // 
            this.col_log_descr.DataPropertyName = "log_descr";
            this.col_log_descr.HeaderText = "log_descr";
            this.col_log_descr.Name = "col_log_descr";
            this.col_log_descr.ReadOnly = true;
            this.col_log_descr.Width = 300;
            // 
            // col_log_tstamp
            // 
            this.col_log_tstamp.DataPropertyName = "log_tstamp";
            this.col_log_tstamp.HeaderText = "log_tstamp";
            this.col_log_tstamp.Name = "col_log_tstamp";
            this.col_log_tstamp.ReadOnly = true;
            this.col_log_tstamp.Width = 140;
            // 
            // col_log_error
            // 
            this.col_log_error.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_log_error.DataPropertyName = "log_error";
            this.col_log_error.HeaderText = "log_error";
            this.col_log_error.Name = "col_log_error";
            this.col_log_error.ReadOnly = true;
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 365);
            this.Controls.Add(this.tlpLogs);
            this.Name = "LogsForm";
            this.Text = "Logi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogsForm_FormClosed);
            this.tlpLogs.ResumeLayout(false);
            this.pLogs.ResumeLayout(false);
            this.pLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLogs;
        private System.Windows.Forms.Panel pLogs;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox LogsSearchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.BindingSource bsLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_log_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_log_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_log_descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_log_tstamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_log_error;
    }
}