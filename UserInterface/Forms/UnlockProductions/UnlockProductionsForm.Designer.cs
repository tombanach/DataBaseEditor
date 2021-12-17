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
            this.tlpUnlockProductions = new System.Windows.Forms.TableLayoutPanel();
            this.pUnlockProductions = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvUnlockProductions = new System.Windows.Forms.DataGridView();
            this.tlpUnlockProductions.SuspendLayout();
            this.pUnlockProductions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnlockProductions)).BeginInit();
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
            this.pUnlockProductions.Controls.Add(this.btnDelete);
            this.pUnlockProductions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUnlockProductions.Location = new System.Drawing.Point(3, 3);
            this.pUnlockProductions.Name = "pUnlockProductions";
            this.pUnlockProductions.Size = new System.Drawing.Size(794, 34);
            this.pUnlockProductions.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Image = global::SmayDbEditor.UserInterface.Properties.Resources.delete_24;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 34);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(100, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 34);
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
            this.btnRefresh.Location = new System.Drawing.Point(108, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 34);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvUnlockProductions
            // 
            this.dgvUnlockProductions.AllowUserToAddRows = false;
            this.dgvUnlockProductions.AllowUserToDeleteRows = false;
            this.dgvUnlockProductions.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnlockProductions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnlockProductions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnlockProductions.Location = new System.Drawing.Point(3, 43);
            this.dgvUnlockProductions.Name = "dgvUnlockProductions";
            this.dgvUnlockProductions.ReadOnly = true;
            this.dgvUnlockProductions.Size = new System.Drawing.Size(794, 404);
            this.dgvUnlockProductions.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUnlockProductions;
        private System.Windows.Forms.Panel pUnlockProductions;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvUnlockProductions;
    }
}