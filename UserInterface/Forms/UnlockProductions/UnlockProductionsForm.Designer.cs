namespace SmayDbEditor.UserInterface.Forms.UnlockProductions
{
    partial class UnlockProductionsForm
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
            this.tlpUnlockProductions = new System.Windows.Forms.TableLayoutPanel();
            this.pUnlockProductions = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvUnlockProductions = new System.Windows.Forms.DataGridView();
            this.proccodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestartedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsUnlockProductions = new System.Windows.Forms.BindingSource(this.components);
            this.tlpUnlockProductions.SuspendLayout();
            this.pUnlockProductions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnlockProductions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnlockProductions)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpUnlockProductions
            // 
            this.tlpUnlockProductions.ColumnCount = 1;
            this.tlpUnlockProductions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUnlockProductions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUnlockProductions.Controls.Add(this.pUnlockProductions, 0, 0);
            this.tlpUnlockProductions.Controls.Add(this.dgvUnlockProductions, 0, 1);
            this.tlpUnlockProductions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUnlockProductions.Location = new System.Drawing.Point(0, 0);
            this.tlpUnlockProductions.Name = "tlpUnlockProductions";
            this.tlpUnlockProductions.RowCount = 2;
            this.tlpUnlockProductions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpUnlockProductions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUnlockProductions.Size = new System.Drawing.Size(800, 450);
            this.tlpUnlockProductions.TabIndex = 0;
            // 
            // pUnlockProductions
            // 
            this.pUnlockProductions.Controls.Add(this.btnRefresh);
            this.pUnlockProductions.Controls.Add(this.splitter1);
            this.pUnlockProductions.Controls.Add(this.btnRemove);
            this.pUnlockProductions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUnlockProductions.Location = new System.Drawing.Point(3, 3);
            this.pUnlockProductions.Name = "pUnlockProductions";
            this.pUnlockProductions.Size = new System.Drawing.Size(794, 34);
            this.pUnlockProductions.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::SmayDbEditor.UserInterface.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(108, 0);
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
            this.splitter1.Location = new System.Drawing.Point(100, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 34);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Image = global::SmayDbEditor.UserInterface.Properties.Resources.delete_24;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(0, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 34);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvUnlockProductions
            // 
            this.dgvUnlockProductions.AllowUserToAddRows = false;
            this.dgvUnlockProductions.AllowUserToDeleteRows = false;
            this.dgvUnlockProductions.AutoGenerateColumns = false;
            this.dgvUnlockProductions.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnlockProductions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnlockProductions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proccodeDataGridViewTextBoxColumn,
            this.procnameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.timestartedDataGridViewTextBoxColumn});
            this.dgvUnlockProductions.DataSource = this.bsUnlockProductions;
            this.dgvUnlockProductions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnlockProductions.Location = new System.Drawing.Point(3, 43);
            this.dgvUnlockProductions.Name = "dgvUnlockProductions";
            this.dgvUnlockProductions.ReadOnly = true;
            this.dgvUnlockProductions.RowHeadersVisible = false;
            this.dgvUnlockProductions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnlockProductions.Size = new System.Drawing.Size(794, 404);
            this.dgvUnlockProductions.TabIndex = 1;
            // 
            // proccodeDataGridViewTextBoxColumn
            // 
            this.proccodeDataGridViewTextBoxColumn.DataPropertyName = "proccode";
            this.proccodeDataGridViewTextBoxColumn.HeaderText = "proccode";
            this.proccodeDataGridViewTextBoxColumn.Name = "proccodeDataGridViewTextBoxColumn";
            this.proccodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procnameDataGridViewTextBoxColumn
            // 
            this.procnameDataGridViewTextBoxColumn.DataPropertyName = "procname";
            this.procnameDataGridViewTextBoxColumn.HeaderText = "procname";
            this.procnameDataGridViewTextBoxColumn.Name = "procnameDataGridViewTextBoxColumn";
            this.procnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timestartedDataGridViewTextBoxColumn
            // 
            this.timestartedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timestartedDataGridViewTextBoxColumn.DataPropertyName = "timestarted";
            this.timestartedDataGridViewTextBoxColumn.HeaderText = "timestarted";
            this.timestartedDataGridViewTextBoxColumn.Name = "timestartedDataGridViewTextBoxColumn";
            this.timestartedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsUnlockProductions
            // 
            this.bsUnlockProductions.DataSource = typeof(SmayDbEditor.DataAccessLayer.ViewModel.UnlockProductionViewModel);
            // 
            // UnlockProductionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpUnlockProductions);
            this.Name = "UnlockProductionsForm";
            this.Text = "Odblokowanie prod.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UnlockProductionsForm_FormClosed);
            this.tlpUnlockProductions.ResumeLayout(false);
            this.pUnlockProductions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnlockProductions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnlockProductions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUnlockProductions;
        private System.Windows.Forms.Panel pUnlockProductions;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvUnlockProductions;
        private System.Windows.Forms.BindingSource bsUnlockProductions;
        private System.Windows.Forms.DataGridViewTextBoxColumn proccodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestartedDataGridViewTextBoxColumn;
    }
}