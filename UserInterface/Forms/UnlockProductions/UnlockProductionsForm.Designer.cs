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
            this.bsUnlockProductions = new System.Windows.Forms.BindingSource(this.components);
            this.col_timestarted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_procname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_proccode = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.col_proccode,
            this.col_procname,
            this.col_username,
            this.col_timestarted});
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
            // bsUnlockProductions
            // 
            this.bsUnlockProductions.DataSource = typeof(SmayDbEditor.DataAccessLayer.ViewModel.UnlockProductionViewModel);
            // 
            // col_timestarted
            // 
            this.col_timestarted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_timestarted.DataPropertyName = "timestarted";
            this.col_timestarted.HeaderText = "timestarted";
            this.col_timestarted.Name = "col_timestarted";
            this.col_timestarted.ReadOnly = true;
            // 
            // col_username
            // 
            this.col_username.DataPropertyName = "username";
            this.col_username.HeaderText = "username";
            this.col_username.Name = "col_username";
            this.col_username.ReadOnly = true;
            this.col_username.Width = 120;
            // 
            // col_procname
            // 
            this.col_procname.DataPropertyName = "procname";
            this.col_procname.HeaderText = "procname";
            this.col_procname.Name = "col_procname";
            this.col_procname.ReadOnly = true;
            this.col_procname.Width = 120;
            // 
            // col_proccode
            // 
            this.col_proccode.DataPropertyName = "proccode";
            this.col_proccode.HeaderText = "proccode";
            this.col_proccode.Name = "col_proccode";
            this.col_proccode.ReadOnly = true;
            this.col_proccode.Width = 120;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn col_proccode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_procname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_timestarted;
    }
}