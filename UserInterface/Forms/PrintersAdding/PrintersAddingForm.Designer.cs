
namespace SmayDbEditor.UserInterface.Forms.PrintersAdding
{
    partial class PrintersAddingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintersAddingForm));
            this.tlpPrintersAdding = new System.Windows.Forms.TableLayoutPanel();
            this.pPrintersAdding = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnRemove = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnModify = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvPrintersAdding = new System.Windows.Forms.DataGridView();
            this.bsPrintersAdding = new System.Windows.Forms.BindingSource(this.components);
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PrinterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpPrintersAdding.SuspendLayout();
            this.pPrintersAdding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintersAdding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrintersAdding)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrintersAdding
            // 
            this.tlpPrintersAdding.ColumnCount = 1;
            this.tlpPrintersAdding.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrintersAdding.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrintersAdding.Controls.Add(this.pPrintersAdding, 0, 0);
            this.tlpPrintersAdding.Controls.Add(this.dgvPrintersAdding, 0, 1);
            this.tlpPrintersAdding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrintersAdding.Location = new System.Drawing.Point(0, 0);
            this.tlpPrintersAdding.Name = "tlpPrintersAdding";
            this.tlpPrintersAdding.RowCount = 2;
            this.tlpPrintersAdding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPrintersAdding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrintersAdding.Size = new System.Drawing.Size(800, 450);
            this.tlpPrintersAdding.TabIndex = 0;
            // 
            // pPrintersAdding
            // 
            this.pPrintersAdding.Controls.Add(this.btnRefresh);
            this.pPrintersAdding.Controls.Add(this.splitter1);
            this.pPrintersAdding.Controls.Add(this.btnRemove);
            this.pPrintersAdding.Controls.Add(this.splitter2);
            this.pPrintersAdding.Controls.Add(this.btnModify);
            this.pPrintersAdding.Controls.Add(this.splitter3);
            this.pPrintersAdding.Controls.Add(this.btnCreate);
            this.pPrintersAdding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrintersAdding.Location = new System.Drawing.Point(3, 3);
            this.pPrintersAdding.Name = "pPrintersAdding";
            this.pPrintersAdding.Size = new System.Drawing.Size(794, 34);
            this.pPrintersAdding.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::SmayDbEditor.UserInterface.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(445, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 34);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(435, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 34);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Image = global::SmayDbEditor.UserInterface.Properties.Resources.delete_24;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(300, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 34);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Usuń komputer";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(290, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 34);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Image = global::SmayDbEditor.UserInterface.Properties.Resources.edit_24;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(150, 0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(140, 34);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Edytuj komputer";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(140, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(10, 34);
            this.splitter3.TabIndex = 6;
            this.splitter3.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(140, 34);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Dodaj komputer";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvPrintersAdding
            // 
            this.dgvPrintersAdding.AllowUserToAddRows = false;
            this.dgvPrintersAdding.AllowUserToDeleteRows = false;
            this.dgvPrintersAdding.AutoGenerateColumns = false;
            this.dgvPrintersAdding.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrintersAdding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrintersAdding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_PrinterName,
            this.col_hostname});
            this.dgvPrintersAdding.DataSource = this.bsPrintersAdding;
            this.dgvPrintersAdding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrintersAdding.Location = new System.Drawing.Point(3, 43);
            this.dgvPrintersAdding.Name = "dgvPrintersAdding";
            this.dgvPrintersAdding.ReadOnly = true;
            this.dgvPrintersAdding.RowHeadersVisible = false;
            this.dgvPrintersAdding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrintersAdding.Size = new System.Drawing.Size(794, 404);
            this.dgvPrintersAdding.TabIndex = 1;
            // 
            // bsPrintersAdding
            // 
            this.bsPrintersAdding.DataSource = typeof(SmayDbEditor.DataAccessLayer.ViewModel.PrinterAddingViewModel);
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "id";
            this.col_id.HeaderText = "id";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Visible = false;
            // 
            // col_PrinterName
            // 
            this.col_PrinterName.DataPropertyName = "PrinterName";
            this.col_PrinterName.HeaderText = "PrinterName";
            this.col_PrinterName.Name = "col_PrinterName";
            this.col_PrinterName.ReadOnly = true;
            this.col_PrinterName.ToolTipText = "Nazwa drukarki";
            this.col_PrinterName.Width = 250;
            // 
            // col_hostname
            // 
            this.col_hostname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_hostname.DataPropertyName = "hostname";
            this.col_hostname.HeaderText = "hostname";
            this.col_hostname.Name = "col_hostname";
            this.col_hostname.ReadOnly = true;
            this.col_hostname.ToolTipText = "Nazwa komputera";
            // 
            // PrintersAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpPrintersAdding);
            this.Name = "PrintersAddingForm";
            this.Text = "Dodanie drukarki";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrintersAddingForm_FormClosed);
            this.tlpPrintersAdding.ResumeLayout(false);
            this.pPrintersAdding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintersAdding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrintersAdding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrintersAdding;
        private System.Windows.Forms.Panel pPrintersAdding;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.DataGridView dgvPrintersAdding;
        private System.Windows.Forms.BindingSource bsPrintersAdding;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PrinterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hostname;
    }
}