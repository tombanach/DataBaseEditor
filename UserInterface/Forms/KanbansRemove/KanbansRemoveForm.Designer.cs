
namespace SmayDbEditor.UserInterface.Forms.KanbansRemove
{
    partial class KanbansRemoveForm
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
            this.tlpKanbansRemove = new System.Windows.Forms.TableLayoutPanel();
            this.pKanbansRemove = new System.Windows.Forms.Panel();
            this.KanbansRemoveSearchBar = new System.Windows.Forms.TextBox();
            this.lblKanbanNumber = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvKanbansRemove = new System.Windows.Forms.DataGridView();
            this.col_kbtr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_kbtr_polecNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_kbtr_dokID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_kbtr_polecDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_kbtr_relDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_kbtr_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_kbtr_tstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsKanbansRemove = new System.Windows.Forms.BindingSource(this.components);
            this.tlpKanbansRemove.SuspendLayout();
            this.pKanbansRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKanbansRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKanbansRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpKanbansRemove
            // 
            this.tlpKanbansRemove.ColumnCount = 1;
            this.tlpKanbansRemove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKanbansRemove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpKanbansRemove.Controls.Add(this.pKanbansRemove, 0, 0);
            this.tlpKanbansRemove.Controls.Add(this.dgvKanbansRemove, 0, 1);
            this.tlpKanbansRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKanbansRemove.Location = new System.Drawing.Point(0, 0);
            this.tlpKanbansRemove.Name = "tlpKanbansRemove";
            this.tlpKanbansRemove.RowCount = 2;
            this.tlpKanbansRemove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpKanbansRemove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKanbansRemove.Size = new System.Drawing.Size(800, 450);
            this.tlpKanbansRemove.TabIndex = 0;
            // 
            // pKanbansRemove
            // 
            this.pKanbansRemove.Controls.Add(this.KanbansRemoveSearchBar);
            this.pKanbansRemove.Controls.Add(this.lblKanbanNumber);
            this.pKanbansRemove.Controls.Add(this.splitter2);
            this.pKanbansRemove.Controls.Add(this.btnRefresh);
            this.pKanbansRemove.Controls.Add(this.splitter1);
            this.pKanbansRemove.Controls.Add(this.btnRemove);
            this.pKanbansRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pKanbansRemove.Location = new System.Drawing.Point(3, 3);
            this.pKanbansRemove.Name = "pKanbansRemove";
            this.pKanbansRemove.Size = new System.Drawing.Size(794, 34);
            this.pKanbansRemove.TabIndex = 0;
            // 
            // KanbansRemoveSearchBar
            // 
            this.KanbansRemoveSearchBar.Location = new System.Drawing.Point(639, 7);
            this.KanbansRemoveSearchBar.Name = "KanbansRemoveSearchBar";
            this.KanbansRemoveSearchBar.Size = new System.Drawing.Size(146, 20);
            this.KanbansRemoveSearchBar.TabIndex = 12;
            this.KanbansRemoveSearchBar.TextChanged += new System.EventHandler(this.KanbansRemoveSearchBar_TextChanged);
            // 
            // lblKanbanNumber
            // 
            this.lblKanbanNumber.AutoSize = true;
            this.lblKanbanNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKanbanNumber.Location = new System.Drawing.Point(512, 7);
            this.lblKanbanNumber.Name = "lblKanbanNumber";
            this.lblKanbanNumber.Size = new System.Drawing.Size(121, 20);
            this.lblKanbanNumber.TabIndex = 11;
            this.lblKanbanNumber.Text = "Numer kanbana";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(240, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(266, 34);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::SmayDbEditor.UserInterface.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(140, 0);
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
            this.splitter1.Location = new System.Drawing.Point(130, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 34);
            this.splitter1.TabIndex = 2;
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
            this.btnRemove.Size = new System.Drawing.Size(130, 34);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Usuń kanbana";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvKanbansRemove
            // 
            this.dgvKanbansRemove.AllowUserToAddRows = false;
            this.dgvKanbansRemove.AllowUserToDeleteRows = false;
            this.dgvKanbansRemove.AutoGenerateColumns = false;
            this.dgvKanbansRemove.BackgroundColor = System.Drawing.Color.White;
            this.dgvKanbansRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKanbansRemove.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_kbtr_id,
            this.col_kbtr_polecNo,
            this.col_kbtr_dokID,
            this.col_kbtr_polecDate,
            this.col_kbtr_relDate,
            this.col_kbtr_status,
            this.col_kbtr_tstamp});
            this.dgvKanbansRemove.DataSource = this.bsKanbansRemove;
            this.dgvKanbansRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKanbansRemove.Location = new System.Drawing.Point(3, 43);
            this.dgvKanbansRemove.Name = "dgvKanbansRemove";
            this.dgvKanbansRemove.ReadOnly = true;
            this.dgvKanbansRemove.RowHeadersVisible = false;
            this.dgvKanbansRemove.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKanbansRemove.Size = new System.Drawing.Size(794, 404);
            this.dgvKanbansRemove.TabIndex = 1;
            // 
            // col_kbtr_id
            // 
            this.col_kbtr_id.DataPropertyName = "kbtr_id";
            this.col_kbtr_id.HeaderText = "kbtr_id";
            this.col_kbtr_id.Name = "col_kbtr_id";
            this.col_kbtr_id.ReadOnly = true;
            this.col_kbtr_id.Visible = false;
            // 
            // col_kbtr_polecNo
            // 
            this.col_kbtr_polecNo.DataPropertyName = "kbtr_polecNo";
            this.col_kbtr_polecNo.HeaderText = "kbtr_polecNo";
            this.col_kbtr_polecNo.Name = "col_kbtr_polecNo";
            this.col_kbtr_polecNo.ReadOnly = true;
            // 
            // col_kbtr_dokID
            // 
            this.col_kbtr_dokID.DataPropertyName = "kbtr_dokID";
            this.col_kbtr_dokID.HeaderText = "kbtr_dokID";
            this.col_kbtr_dokID.Name = "col_kbtr_dokID";
            this.col_kbtr_dokID.ReadOnly = true;
            // 
            // col_kbtr_polecDate
            // 
            this.col_kbtr_polecDate.DataPropertyName = "kbtr_polecDate";
            this.col_kbtr_polecDate.HeaderText = "kbtr_polecDate";
            this.col_kbtr_polecDate.Name = "col_kbtr_polecDate";
            this.col_kbtr_polecDate.ReadOnly = true;
            // 
            // col_kbtr_relDate
            // 
            this.col_kbtr_relDate.DataPropertyName = "kbtr_relDate";
            this.col_kbtr_relDate.HeaderText = "kbtr_relDate";
            this.col_kbtr_relDate.Name = "col_kbtr_relDate";
            this.col_kbtr_relDate.ReadOnly = true;
            // 
            // col_kbtr_status
            // 
            this.col_kbtr_status.DataPropertyName = "kbtr_status";
            this.col_kbtr_status.HeaderText = "kbtr_status";
            this.col_kbtr_status.Name = "col_kbtr_status";
            this.col_kbtr_status.ReadOnly = true;
            // 
            // col_kbtr_tstamp
            // 
            this.col_kbtr_tstamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_kbtr_tstamp.DataPropertyName = "kbtr_tstamp";
            this.col_kbtr_tstamp.HeaderText = "kbtr_tstamp";
            this.col_kbtr_tstamp.Name = "col_kbtr_tstamp";
            this.col_kbtr_tstamp.ReadOnly = true;
            // 
            // bsKanbansRemove
            // 
            this.bsKanbansRemove.DataSource = typeof(SmayDbEditor.DataAccessLayer.ViewModel.KanbanRemoveViewModel);
            // 
            // KanbansRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpKanbansRemove);
            this.Name = "KanbansRemoveForm";
            this.Text = "Usuwanie kanbanów";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KanbansRemoveForm_FormClosed);
            this.tlpKanbansRemove.ResumeLayout(false);
            this.pKanbansRemove.ResumeLayout(false);
            this.pKanbansRemove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKanbansRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKanbansRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpKanbansRemove;
        private System.Windows.Forms.Panel pKanbansRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dgvKanbansRemove;
        private System.Windows.Forms.BindingSource bsKanbansRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kbtr_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kbtr_polecNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kbtr_dokID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kbtr_polecDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kbtr_relDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kbtr_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kbtr_tstamp;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label lblKanbanNumber;
        private System.Windows.Forms.TextBox KanbansRemoveSearchBar;
    }
}