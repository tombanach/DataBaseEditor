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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.bsLogs = new System.Windows.Forms.BindingSource(this.components);
            this.logidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lognumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logdescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logtstampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logerrorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tlpLogs.Size = new System.Drawing.Size(661, 455);
            this.tlpLogs.TabIndex = 0;
            // 
            // pLogs
            // 
            this.pLogs.Controls.Add(this.textBox1);
            this.pLogs.Controls.Add(this.label1);
            this.pLogs.Controls.Add(this.splitter1);
            this.pLogs.Controls.Add(this.btnRefresh);
            this.pLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLogs.Location = new System.Drawing.Point(3, 3);
            this.pLogs.Name = "pLogs";
            this.pLogs.Size = new System.Drawing.Size(655, 34);
            this.pLogs.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(500, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 27);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(358, 6);
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
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::SmayDbEditor.UserInterface.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 34);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.AutoGenerateColumns = false;
            this.dgvLogs.BackgroundColor = System.Drawing.Color.White;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logidDataGridViewTextBoxColumn,
            this.lognumDataGridViewTextBoxColumn,
            this.logdescrDataGridViewTextBoxColumn,
            this.logtstampDataGridViewTextBoxColumn,
            this.logerrorDataGridViewTextBoxColumn});
            this.dgvLogs.DataSource = this.bsLogs;
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.Location = new System.Drawing.Point(3, 43);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.Size = new System.Drawing.Size(655, 409);
            this.dgvLogs.TabIndex = 1;
            // 
            // bsLogs
            // 
            this.bsLogs.DataSource = typeof(SmayDbEditor.DataAccessLayer.ViewModel.LogViewModel);
            // 
            // logidDataGridViewTextBoxColumn
            // 
            this.logidDataGridViewTextBoxColumn.DataPropertyName = "log_id";
            this.logidDataGridViewTextBoxColumn.HeaderText = "log_id";
            this.logidDataGridViewTextBoxColumn.Name = "logidDataGridViewTextBoxColumn";
            this.logidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lognumDataGridViewTextBoxColumn
            // 
            this.lognumDataGridViewTextBoxColumn.DataPropertyName = "log_num";
            this.lognumDataGridViewTextBoxColumn.HeaderText = "log_num";
            this.lognumDataGridViewTextBoxColumn.Name = "lognumDataGridViewTextBoxColumn";
            this.lognumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logdescrDataGridViewTextBoxColumn
            // 
            this.logdescrDataGridViewTextBoxColumn.DataPropertyName = "log_descr";
            this.logdescrDataGridViewTextBoxColumn.HeaderText = "log_descr";
            this.logdescrDataGridViewTextBoxColumn.Name = "logdescrDataGridViewTextBoxColumn";
            this.logdescrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logtstampDataGridViewTextBoxColumn
            // 
            this.logtstampDataGridViewTextBoxColumn.DataPropertyName = "log_tstamp";
            this.logtstampDataGridViewTextBoxColumn.HeaderText = "log_tstamp";
            this.logtstampDataGridViewTextBoxColumn.Name = "logtstampDataGridViewTextBoxColumn";
            this.logtstampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logerrorDataGridViewTextBoxColumn
            // 
            this.logerrorDataGridViewTextBoxColumn.DataPropertyName = "log_error";
            this.logerrorDataGridViewTextBoxColumn.HeaderText = "log_error";
            this.logerrorDataGridViewTextBoxColumn.Name = "logerrorDataGridViewTextBoxColumn";
            this.logerrorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 455);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn logidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lognumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logdescrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logtstampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logerrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsLogs;
    }
}